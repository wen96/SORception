﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Eggplant.ServiceTaller;
using Newtonsoft.Json.Linq;
using Microsoft.AspNet.Identity;
using Eggplant.Application;

namespace Eggplant.Controllers
{
    [Authorize]
    public class PedidoController : ApiController
    {
        //static BDBerenjenaContainer c_bd = EggplantContextFactory.getContext();
        //static Eggplant.ServiceTaller.GestionTallerClient svcTaller = new Eggplant.ServiceTaller.GestionTallerClient();

        public static string FAILED = "FAILED";
        public static string DELETED = "DELETED";
        public static string REQUESTED = "REQUESTED";

        private PedidoApplication pa;
        public PedidoController()
        {
            pa = new PedidoApplication();
        }

        // GET api/pedido
        public object Get()
        {
            return pa.getAll(User.Identity.GetUserId());

        }

        // GET api/pedido/5
        public object Get(int id)
        {
            return pa.getById(id, User.Identity.GetUserId());
        }

        // POST api/pedido
        public object Post([FromBody]JObject values)
        {
            /*
            int idPedido = 0;
            using (BDBerenjenaContainer c_bd = new BDBerenjenaContainer())
            {
                Pedido p = new Pedido();
                p.timeStamp = DateTime.Now;
                int idSolcitud = int.Parse(values["solicitud"].ToString());
                p.Solicitud = c_bd.SolicitudSet.FirstOrDefault(x => x.Id == idSolcitud);
                if (p.Solicitud == null)
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "La solicitud " + idSolcitud + " no existe en la DB interna");
                foreach (JObject item in values["lineas"])
                {
                    LineaPedido lp = new LineaPedido();
                    lp.linea_oferta_id = int.Parse(item["id_linea_oferta"].ToString());
                    lp.state = FAILED;
                    lp.sg_id = int.Parse(item["id_linea_solcitud"].ToString());
                    var lofer = getLineaOferta(lp.linea_oferta_id, p.Solicitud.sg_id);// ofer.lineas.FirstOrDefault(x => x.id == lp.linea_oferta_id);
                    if (lofer == null)
                        return Request.CreateResponse(HttpStatusCode.NotFound, "La linea " + lp.linea_oferta_id + " no existe en la oferta ");
                    lp.price = (decimal)lofer.price;
                    lp.quantity = int.Parse(item["cantidad"].ToString());
                    if (lp.quantity > lofer.quantity)
                        return Request.CreateResponse(HttpStatusCode.BadRequest, "No puedes pedir mas piezas de las ofertadas");
                    p.LineaPedido.Add(lp);
                }
                c_bd.PedidoSet.Add(p);
                c_bd.SaveChanges();
                idPedido = p.Id;

            }
            addPedidoToSG(idPedido);
            return idPedido; */
            return null;
        }

        /// Igual esta Funcion deberia esta en el SG
        private ExpOfertaLine getLineaOferta(int idLineaOferta, int idSolicitud)
        {
            /* var ofertas = svcTaller.getOfertas(idSolicitud);
             foreach (var oferta in ofertas)
             {
                 var linea = oferta.lineas.FirstOrDefault(x => x.id == idLineaOferta);
                 if (linea != null) return linea;
             }*/
            return null;
        }




        /// Recorremos el pedido y lo anyadimos el SG
        private void addPedidoToSG(int idPedido)
        {
            /*
            using (BDBerenjenaContainer c_bd = new BDBerenjenaContainer())
            {
                var pedido = c_bd.PedidoSet.FirstOrDefault(x => x.Id == idPedido);
                if (pedido != null)
                {
                    ExpPedido tr = new ExpPedido();
                    List<ExpPedidoLine> lineasHelper = new List<ExpPedidoLine>();
                    foreach (var lineaPedido in pedido.LineaPedido)
                    {
                        ExpPedidoLine sl = new ExpPedidoLine();
                        sl.linea_oferta_id = lineaPedido.linea_oferta_id;
                        sl.quantity = lineaPedido.quantity;

                        // Anyado la linea al pedido
                        lineasHelper.Add(sl);
                        lineaPedido.state = "SENDED";
                    }
                    tr.lineas = lineasHelper.ToArray();
                    svcTaller.selectOferta(tr);
                    c_bd.SaveChanges();
                }
            } */
        }

        //Recorremos todos los pedidos internos y los actualizamos con los datos del SG
        private void UpdatePedidosFromSG()
        {
            /*
            using (BDBerenjenaContainer c_bd = new BDBerenjenaContainer())
            {
                var pedidos = c_bd.PedidoSet.AsQueryable().ToList();
                foreach (var pedido in pedidos)
                {
                    foreach (var lineaPedido in pedido.LineaPedido)
                    {
                        int sgId = lineaPedido.sg_id;
                        //TODO var ofertaSelec = svcTaller.getOfertaSeleccionada(sgId);
                        //Actualizamos todo los campos
                        //lineaPedido.status = ofertaSelec.status; o algo asi
                    }
                }
            }*/
        }
    }
}
