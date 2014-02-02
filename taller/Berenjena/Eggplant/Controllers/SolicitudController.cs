﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Eggplant.ServiceTaller;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Eggplant.Models;
using System.Web;
using Microsoft.AspNet.Identity;
using Eggplant.Application;
using Eggplant.DTO;

namespace Eggplant.Controllers
{
    [Authorize]
    [RoutePrefix("api/solicitud")]
    public class SolicitudController : ApiController
    {
        private SolicitudApplication sa;
        public SolicitudController()
        {
            sa = new SolicitudApplication();
        }


        // GET api/solicitud
        public object Get()
        {
            return sa.getByUser(User.Identity.GetUserId());
        }

        // GET api/solicitud/5
        public object Get(int id)
        {
            return sa.getDetailById(User.Identity.GetUserId(), id);
        }

        // POST api/solicitud
        public object Post(SolicitudPostDTO data)
        {
            return sa.Request(data, User.Identity.GetUserId());
        }

        // PUT api/solicitud/5
        public object Put(int id, [FromBody]JObject values)
        {
            /*
            using (BDBerenjenaContainer c_bd = new BDBerenjenaContainer())
            {
                Solicitud solInterna = c_bd.SolicitudSet.FirstOrDefault(x => x.Id == id);
                if (solInterna != null)
                {
                    ExpSolicitud solExterna = svcTaller.getSolicitud(solInterna.sg_id);
                    if (solExterna != null)
                    {
                        //Creo las lineas de la solicitud desde los datos pasado por json
                        List<ExpSolicitudLine> lineas = new List<ExpSolicitudLine>();
                        List<LineaSolicitud> lineasNuevas = new List<LineaSolicitud>();
                        foreach (JObject item in values["data"])
                        {
                            string efecto = item["update"].ToString();
                            //Si me envia datos que no sean totalmente inutiles que solo sirven para sobrecargar
                            if (efecto == LINEA_NEW || efecto == LINEA_UPDATED || efecto == LINEA_DELETE)
                            {
                                LineaSolicitud linIn = null;
                                // Modificacion interna
                                if (efecto == LINEA_NEW)
                                {
                                    linIn = new LineaSolicitud();
                                    linIn.descripcion = item["descripcion"].ToString();
                                    linIn.cantidad = int.Parse(item["cantidad"].ToString());
                                    linIn.criterio = item["criterio"]["code"].ToString();
                                    linIn.status = DELETED;
                                    solInterna.LineaSolicitud.Add(linIn);
                                    c_bd.SaveChanges();
                                    lineasNuevas.Add(linIn);
                                }
                                else if (efecto == LINEA_UPDATED)
                                {
                                    int idToModify = int.Parse(item["id"].ToString());
                                    linIn =
                                        c_bd.LineaSolicitudSet.FirstOrDefault(x => x.Id == idToModify);
                                    linIn.descripcion = item["descripcion"].ToString();
                                    linIn.cantidad = int.Parse(item["cantidad"].ToString());
                                    linIn.criterio = item["criterio"]["code"].ToString();
                                }
                                else if (efecto == LINEA_DELETE)
                                {
                                    int idToDelete = int.Parse(item["id"].ToString());
                                    linIn =
                                        c_bd.LineaSolicitudSet.FirstOrDefault(x => x.Id == idToDelete);
                                    c_bd.LineaSolicitudSet.Remove(linIn);//.LineaSolicitud.Remove(linIn);
                                }
                                // Modificacion externa
                                ExpSolicitudLine lin = new ExpSolicitudLine();
                                
                                lin.action = efecto;
                                lin.status = efecto;
                                if (efecto != LINEA_DELETE) { 
                                    lin.flag = ExpSolicitudLine.castToFlag(item["criterio"]["code"].ToString());
                                    lin.description = item["descripcion"].ToString();
                                    lin.quantity = int.Parse(item["cantidad"].ToString());
                                }
                                else
                                {
                                    lin.flag = "NONE";
                                    lin.description = "NONE";
                                    lin.quantity = 0;
                                }
                                lin.id_en_taller = linIn.Id;
                                if (efecto == LINEA_UPDATED || efecto == LINEA_DELETE) 
                                {
                                    lin.id = linIn.sg_id;
                                }
                                
                                lineas.Add(lin);
                            }
                        }
                        solExterna.lineas = lineas.ToArray();
                        try 
                        { 
                            svcTaller.putSolicitud(solExterna);
                            var lineasActualizadas = svcTaller.getSolicitud(solInterna.sg_id).lineas.ToList();
                            foreach (var linea in lineasNuevas)
                            {
                                foreach(var lineaActualizada in lineasActualizadas){
                                    if (lineaActualizada.id_en_taller == linea.Id) { 
                                        linea.sg_id = lineaActualizada.id;
                                    }
                                }
                            
                            }
                        }
                        catch (Exception ex)
                        {
                            c_bd.LineaSolicitudSet.RemoveRange(lineasNuevas);
                            c_bd.SaveChanges();
                            throw;
                        }
                        
                        c_bd.SaveChanges();
                        

                        return Request.CreateErrorResponse(HttpStatusCode.OK, "");
                    }
                    else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Solicitud no encontrada en el sistema gestor");
                }
                else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "La solicitud no existe en la db local");
            } */
            return null;
        }

        // DELETE api/solicitud/5
        public void Delete(int id)
        {
            /*
            using (BDBerenjenaContainer c_bd = new BDBerenjenaContainer())
            {
                Solicitud sol = c_bd.SolicitudSet.FirstOrDefault(x => x.Id == id);
                if (sol != null)
                {
                    sol.status = DELETED;
                    c_bd.SaveChanges();
                    svcTaller.deleteSolicitud(sol.sg_id);
                }
            }*/
        }

        [Route("update")]
        public object GetUpdatedSolicitudes()
        {
            updateSolicitudes();
            return Get();
        }


        private void updateSolicitudes()
        {
            /*
            using (BDBerenjenaContainer c_bd = new BDBerenjenaContainer())
            {
                //Si no hay taller activo devuelve -1 y no encontrara nada digo yo
                var solicitudes = svcTaller.getSolicitudes().ToList();
                foreach (ExpSolicitud solicitud in solicitudes)
                {
                    Solicitud s = c_bd.SolicitudSet.FirstOrDefault(x => x.sg_id == solicitud.id);
                    if (s != null)
                        s.status = solicitud.status;
                }
            }*/

        }

        private void addLineasNoAgregadas(List<ExpOfertaLine> lineas, int idSolicitud)
        {
            /*
            using (BDBerenjenaContainer c_bd = new BDBerenjenaContainer())
            {
                Pedido p = new Pedido();
                p.Solicitud = c_bd.SolicitudSet.FirstOrDefault(solicitud => solicitud.sg_id == idSolicitud);
                foreach (var lineaPedidoExterna in lineas)
                {
                    LineaPedido lp = new LineaPedido();
                    lp.quantity = lineaPedidoExterna.linea_solicitud.quantity;
                    lp.linea_oferta_id = lineaPedidoExterna.id;
                    lp.price = (decimal)lineaPedidoExterna.price;
                    p.LineaPedido.Add(lp);
                }
                c_bd.PedidoSet.Add(p);
                c_bd.SaveChanges();
            }*/
        }

        /*
        private int getIdActive()
        {
            var tokenActive = c_bd.TokensSet.AsQueryable()
                .ToList()
                .FirstOrDefault(x => x.state == Berenjena.Controllers.SettingsController.ACTIVE);
            if (tokenActive != null)
            {
                int idTallerActual = svcTaller.getTaller(tokenActive.token).id;
                return idTallerActual;
            }
            return -1;

        }*/
    }
}
