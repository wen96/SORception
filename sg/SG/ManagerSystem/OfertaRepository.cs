﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerSystem
{
    public class OfertaRepository
    {
        static managersystemEntities ms_ent = new managersystemEntities();

        static private Oferta Copy(Oferta tmp)
        {
            Oferta o = new Oferta();

            return o;
        }

        static public Oferta Find(int id)
        {
            return ms_ent.OfertaSet.Find(id);
        }

        static public Oferta Sanitize(Oferta o)
        {
            return Copy(o);
        }
        
        static public ExposedOferta ToExposed(Oferta s)
        {
            ExposedOferta eo = new ExposedOferta();

            eo.id = s.Id;
            eo.desguace_id = s.DesguaceId;
            eo.lineas = new List<ExposedLineaOferta>();
            foreach (var l in s.LineasOferta)
            {
                ExposedLineaOferta lo = new ExposedLineaOferta();
                lo.id = l.Id;
                lo.quantity = l.quantity;
                eo.lineas.Add(lo);
            }
            eo.status = s.state;

            return eo;
        }

        static public Oferta FromExposed(ExposedOferta eo)
        {
            Oferta o = new Oferta();

            o.DesguaceId = eo.desguace_id;
            o.LineasOferta = new List<LineaOferta>();
            foreach (var elo in eo.lineas)
            {
                LineaOferta lo = new LineaOferta();
                lo.id_en_desguace = elo.id;
                lo.quantity = elo.quantity;
                o.LineasOferta.Add(lo);
            }
            o.id_en_desguace = eo.desguace_id;
            o.state = "NEW";
            o.date = DateTime.Now;

            return o;
        }

        static public List<Oferta> FindAll()
        {
            return ms_ent.OfertaSet.ToList();
        }
        
        static public void InsertOrUpdate(Oferta s)
        {
            if (s.Id == default(int))
            {
                // New entity
                ms_ent.OfertaSet.Add(s);
            }
            else
            {
                // Existing entity
                //ms_ent.DesguaceConjunto.Attach(desguace);
            }
        }

        static public void Delete(int id)
        {
            var oferta = ms_ent.OfertaSet.Find(id);
            ms_ent.OfertaSet.Remove(oferta);
        }

        static public void Save()
        {
            ms_ent.SaveChanges();
        }

        static public void Dispose()
        {
            ms_ent.Dispose();
        }
    }
}