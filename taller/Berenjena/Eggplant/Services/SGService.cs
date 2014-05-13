﻿using Eggplant.Entity;
using Eggplant.ServiceTaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eggplant.Services
{
    public class SGService : ISGService
    {
        protected IDataService dataService;

        private GestionTallerClient svcTaller;

        private UDDIService svcJUDDI;

        public SGService()
        {

            dataService = ServicesFactory.getDataService();
            svcJUDDI = new UDDIService();
            svcTaller = svcJUDDI.getAvailibleWFCService();
        }

        public TokenResponse signUp(string name)
        {
            ExpTaller et = new ExpTaller();
            et.name = name;
            try
            {
                return svcTaller.signUp(et);
            }
            catch (Exception ex)
            {
                dataService.Audits.create(Audit.ERROR, "SistemaGestor its not available. Returned a request exception: " + ex.Message);
                throw;
            }
        }

        public TokenResponse getState(string token)
        {
            try
            {
                return svcTaller.getState(token);
            }
            catch (Exception ex)
            {
                dataService.Audits.create(Audit.ERROR, "SistemaGestor its not available. Returned a request exception: " + ex.Message);
                throw;
            }
        }
        public int addSolicitud(ExpSolicitud exSol)
        {
            try
            {
                return svcTaller.addSolicitud(exSol);
            }
            catch (Exception ex)
            {
                dataService.Audits.create(Audit.ERROR, "SistemaGestor its not available. Returned a request exception: " + ex.Message);
                throw;
            }

        }

        public ExpSolicitud getSolicitud(int id)
        {
            try
            {
                return svcTaller.getSolicitud(id);
            }
            catch (Exception ex)
            {
                dataService.Audits.create(Audit.ERROR, "SistemaGestor its not available. Returned a request exception: " + ex.Message);
                throw;
            }
        }

        public List<ExpOferta> getOfertas(int idSolicitud)
        {
            try
            {
                return svcTaller.getOfertas(idSolicitud).ToList();
            }
            catch (Exception ex)
            {
                dataService.Audits.create(Audit.ERROR, "SistemaGestor its not available. Returned a request exception: " + ex.Message);
                throw;
            }
        }

        public int selectOferta(ExpPedido pedido)
        {
            try
            {
                return svcTaller.selectOferta(pedido);
            }
            catch (Exception ex)
            {
                dataService.Audits.create(Audit.ERROR, "SistemaGestor its not available. Returned a request exception: " + ex.Message);
                throw;
            }
        }


        public int putSolicitud(ExpSolicitud solicitud)
        {
            try
            {
                return svcTaller.putSolicitud(solicitud);
            }
            catch (Exception ex)
            {
                dataService.Audits.create(Audit.ERROR, "SistemaGestor its not available. Returned a request exception: " + ex.Message);
                throw;
            }
        }

    }
}