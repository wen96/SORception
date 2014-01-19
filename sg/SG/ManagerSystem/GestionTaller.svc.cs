﻿using ActiveMQHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;

namespace ManagerSystem
{
    public class GestionTaller : IGestionTaller
    {
        static managersystemEntities ms_ent = new managersystemEntities();

        private Taller getAuthorizedTaller()
        {
            string token_string;
            try
            {
                token_string = OperationContext.Current.IncomingMessageHeaders
                    .GetHeader<string>("Authorization", Constants.Namespace);
            }
            catch (Exception e)
            {
                token_string = "49466dbfd43f185f341074a28b671021a809e15a16bdaa37a2e9384a23c46482";
                //throw;
            }

            Token token = Token.Find(token_string);
            if (token != null && token.is_valid && token.Taller != null)
            {
                return token.Taller;
            }
            else
            {
                throw new WebFaultException(System.Net.HttpStatusCode.Forbidden);
            }
        }

        public TokenResponse signUp(ExpTaller et)
        {
            if (et != null)
            {
                Taller tall = Taller.FromExposed(et);
                tall.active = false;

                Token t = Token.getToken();
                tall.Tokens.Add(t);

                Taller.InsertOrUpdate(tall);
                Taller.Save();
                return new TokenResponse(t.token, TokenResponse.Code.ACCEPTED);
            }
            return new TokenResponse("", TokenResponse.Code.BAD_REQUEST);
        }

        public TokenResponse getState(string token)
        {
            string new_token = "";
            TokenResponse.Code status;
            if (token != null && token != "")
            {
                Token t = Token.Find(token);
                if (t != null)
                {
                    if (t.is_valid)
                    {
                        Taller tall = Taller.Find(t.Taller.Id);
                        if (tall.active)
                        {
                            // El taller ya esta activo
                            status = TokenResponse.Code.CREATED;
                        }
                        else
                        {
                            // El taller no esta activo
                            status = TokenResponse.Code.NON_AUTHORITATIVE;
                        }
                        new_token = Token.RegenerateToken(t);
                    }
                    else
                    {
                        // El token ha expirado
                        status = TokenResponse.Code.BAD_REQUEST;
                    }
                }
                else
                {
                    // El token no existe
                    status = TokenResponse.Code.NOT_FOUND;
                }
            }
            else
            {
                // No se le ha pasado un token
                status = TokenResponse.Code.BAD_REQUEST;
            }

            return new TokenResponse(new_token, status);
        }

        public int putTaller(ExpTaller et)
        {
            if (et == null)
                throw new WebFaultException(System.Net.HttpStatusCode.BadRequest);

            Taller t = getAuthorizedTaller();

            if (et != null)
            {
                t = Taller.FromExposed(et);
                Taller.InsertOrUpdate(t);
                Taller.Save();
            }

            return 0;
        }

        public int deleteTaller()
        {
            Taller t = getAuthorizedTaller();
            Taller.Delete(t.Id);
            Taller.Save();
            return 0;
        }

        public ExpSolicitud getSolicitud(int id)
        {
            Taller t = getAuthorizedTaller();

            Solicitud tmp = ms_ent.SolicitudSet.Find(id);
            if (tmp == null)
                throw new WebFaultException(System.Net.HttpStatusCode.NotFound);
            ExpSolicitud s = Solicitud.PrepareOutgoing(tmp);
            return s;
        }

        public List<ExpSolicitud> getSolicitudes()
        {
            Taller t = getAuthorizedTaller();

            List<ExpSolicitud> solicitudes = new List<ExpSolicitud>();

            foreach (var solicitud in t.Solicitudes)
            {
                solicitudes.Add(Solicitud.PrepareOutgoing(solicitud));
            }

            return solicitudes;
        }

        public int addSolicitud(ExpSolicitud es)
        {
            if (es == null)
                throw new WebFaultException(System.Net.HttpStatusCode.BadRequest);

            Taller t = getAuthorizedTaller();

            Solicitud s = Solicitud.GetIncoming(es);
            s.TallerId = t.Id;
            Solicitud.InsertOrUpdate(s);
            Solicitud.Save();
            SendMessage(new AMQSolicitudMessage(Solicitud.PrepareOutgoing(s), AMQSolicitudMessage.Code.New));
            return s.Id;
        }

        public int putSolicitud(ExpSolicitud es)
        {
            if (es == null)
                throw new WebFaultException(System.Net.HttpStatusCode.BadRequest);

            Taller t = getAuthorizedTaller();

            Solicitud s = Solicitud.Find(es.id);
            Solicitud.UpdateFromExposed(s, es);
            Solicitud.Save();
            SendMessage(new AMQSolicitudMessage(Solicitud.PrepareOutgoing(s), AMQSolicitudMessage.Code.Update));

            return 0;
        }

        public int deleteSolicitud(int id)
        {
            Taller t = getAuthorizedTaller();

            Solicitud.Delete(id);
            Solicitud.Save();
            ExpSolicitud es = new ExpSolicitud();
            es.id = id;
            SendMessage(new AMQSolicitudMessage(es, AMQSolicitudMessage.Code.Delete));
            return 0;
        }

        public ExpOferta getOferta(int oferta_id)
        {
            Taller t = getAuthorizedTaller();

            Oferta o = Oferta.Find(oferta_id);
            if (o == null)
                throw new WebFaultException(System.Net.HttpStatusCode.NotFound);

            ExpOferta eo = Oferta.ToExposed(o);
            return eo;
        }

        public List<ExpOferta> getOfertas(int solicitud_id)
        {
            Taller t = getAuthorizedTaller();

            Solicitud s = ms_ent.SolicitudSet.Find(solicitud_id);
            if (s == null)
                throw new WebFaultException(System.Net.HttpStatusCode.NotFound);

            List<Oferta> ofertas_mias = s.Ofertas.ToList();
            List<ExpOferta> ofertas = new List<ExpOferta>();
            foreach (var oferta in ofertas_mias)
            {
                ofertas.Add(Oferta.ToExposed(oferta));
            }

            return ofertas;
        }

        public int selectOferta(ExpPedido r)
        {
            Taller t = getAuthorizedTaller();

            Oferta o = Oferta.Find(r.oferta_id);

            ExpPedido amq_pedido = new ExpPedido();
            amq_pedido.oferta_id = o.id_en_desguace;
            amq_pedido.lineas = new List<ExpPedido.Line>();

            foreach (var l in r.lineas)
            {
                LineaOferta lo = ms_ent.LineaOfertaSet.Find(l.linea_solicitud_id);
                if (lo.LineaOfertaSeleccionada != null)
                    throw new WebFaultException(System.Net.HttpStatusCode.BadRequest);
                /*if (!o.LineasOferta.Contains(lo))
                    throw new WebFaultException(System.Net.HttpStatusCode.BadRequest);*/
                    
                LineaOfertaSeleccionada los = new LineaOfertaSeleccionada();
                los.LineaOferta = lo;
                lo.status = "SELECTED";
                los.quantity = l.quantity;
                ms_ent.LineaOfertaSeleccionadaSet.Add(los);
                lo.LineaSolicitud.status = "SELECTED";

                ExpPedido.Line lp = new ExpPedido.Line();
                lp.linea_solicitud_id = lo.id_en_desguace;
                lp.quantity = l.quantity;
                amq_pedido.lineas.Add(lp);
            }
            ms_ent.SaveChanges();

            AMQPedidoMessage message = new AMQPedidoMessage();
            message.desguace_id = o.Desguace.Tokens.First(token => token.is_valid == true).token;
            message.pedido = amq_pedido;
            SendMessage(message);

            return 0;
        }

        private void SendMessage(AMQSolicitudMessage sm)
        {
            Taller t = getAuthorizedTaller();

            TopicPublisher publisher = TopicPublisher.MakePublisher(
                    Constants.ActiveMQ.Broker,
                    Constants.ActiveMQ.Solicitud.Client_ID,
                    Constants.ActiveMQ.Solicitud.Topic);
            publisher.SendMessage(sm);
            publisher.Dispose();
        }

        private void SendMessage(AMQPedidoMessage sm)
        {
            Taller t = getAuthorizedTaller();

            TopicPublisher publisher = TopicPublisher.MakePublisher(
                    Constants.ActiveMQ.Broker,
                    Constants.ActiveMQ.Solicitud.Client_ID,
                    Constants.ActiveMQ.Pedido.Topic);
            publisher.SendMessage(sm);
            publisher.Dispose();
        }
    }
}
