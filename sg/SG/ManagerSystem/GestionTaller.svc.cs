﻿using ActiveMQHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ManagerSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GestionTaller" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GestionTaller.svc or GestionTaller.svc.cs at the Solution Explorer and start debugging.
    public class GestionTaller : IGestionTaller
    {
        Taller getTaller(int id)
        {
            var tmp = TallerRepository.Find(id);
            Taller t = null;
            if (tmp != null)
            {
                t = TallerRepository.Sanitize(tmp);
            }
            return t;
        }

        int addTaller(string nombre)
        {
            if (nombre != "" && nombre != null)
            {
                try
                {
                    Taller tall = new Taller();
                    tall.name = nombre;
                    TallerRepository.InsertOrUpdate(tall);
                    TallerRepository.Save();
                    return 1;
                }
                catch (Exception e)
                {

                    throw;
                }
            }
            return 0;
        }

        int putTaller(Taller t)
        {
            if (t != null)
            {
                TallerRepository.InsertOrUpdate(t);
            }
            return 0;
        }

        int deleteTaller(int id)
        {
            TallerRepository.Delete(id);
            return 0;
        }

        Solicitud getSolicitud(int id)
        {
            var tmp = SolicitudRepository.Find(id);
            Solicitud s = SolicitudRepository.Sanitize(tmp);
            return s;
        }

        int addSolicitud(Solicitud s)
        {
            if (s != null)
            {
                SolicitudRepository.InsertOrUpdate(s);
                SolicitudRepository.Save();
                return 0;
            }
            return 1;
        }

        int putSolicitud(Solicitud s)
        {
            if (s != null)
            {
                SolicitudRepository.InsertOrUpdate(s);
            }
            return 0;
        }

        int deleteSolicitud(int id)
        {
            SolicitudRepository.Delete(id);
            return 0;
        }

        List<Solicitud> getSolicitudes()
        {
            List<Solicitud> l = new List<Solicitud>();
            foreach (var tmp in SolicitudRepository.FindAll())
            {
                l.Add(SolicitudRepository.Sanitize(tmp));
            }
            return l;
        }
    }
}
