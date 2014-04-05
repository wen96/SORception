﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ManagerSystem
{
    // ActiveMQ

    public class AMQSecureMessage
    {
        public string junkyard_token;
        public string data;
    }

    [DataContract(Namespace = Config.Namespace)]
    public class AMQScheduledJob
    {
        [DataMember(Name = "id_solicitud")]
        public int id_solicitud;

        [DataMember(Name = "xsrf_token")]
        public string xsrf_token;
    }

    [DataContract(Namespace = Config.Namespace)]
    public class AMQSolicitudMessage
    {
        public enum Code { New, Update, Delete, Closed };

        [DataMember(Name = "code")]
        public Code code;

        [DataMember(Name = "solicitud")]
        public ExpSolicitud solicitud;

        public AMQSolicitudMessage(ExpSolicitud s, Code c)
        {
            code = c;
            solicitud = s;
        }

        public AMQSolicitudMessage() { }
    }

    [DataContract(Namespace = Config.Namespace)]
    public class AMQOfertaMessage
    {
        public enum Code { New, Update, Delete };

        [DataMember(Name = "code")]
        public Code code;

        [DataMember(Name = "desguace_id")]
        public string desguace_id;

        [DataMember(Name = "oferta")]
        public ExpOferta oferta;

        public AMQOfertaMessage(ExpOferta s, Code c)
        {
            code = c;
            oferta = s;
        }
        public AMQOfertaMessage() { }
    }

    [DataContract(Namespace = Config.Namespace)]
    public class AMQPedidoMessage
    {
        [DataMember(Name = "desguace_id")]
        public string desguace_id;

        [DataMember(Name = "pedido")]
        public ExpPedido pedido;
    }

    // Solicitud

    [DataContract(Namespace = Config.Namespace)]
    public class ExpSolicitud
    {
        public class Line
        {
            [DataMember(Name = "id")]
            public int id;

            [DataMember(Name = "id_en_taller")]
            public int id_en_taller;

            [DataMember(Name = "description")]
            public string description;

            [DataMember(Name = "quantity")]
            public int quantity;

            [DataMember(Name = "action")]
            public string action;

            [DataMember(Name = "status")]
            public string status;

            [DataMember(Name = "flag")]
            public string flag;
        }

        [DataMember(Name = "id")]
        public int id;

        [DataMember(Name = "id_en_taller")]
        public int id_en_taller;

        [DataMember(Name = "lineas")]
        public List<Line> lineas;

        [DataMember(Name = "status")]
        public string status;

        [DataMember(Name = "deadline")]
        public DateTime deadline;
    }

    [DataContract(Namespace = Config.Namespace)]
    public class ExpPedido
    {
        public ExpPedido()
        {
            lineas = new List<Line>();
        }

        public class Line
        {
            [DataMember(Name = "linea_oferta_id")]
            public int linea_oferta_id;

            [DataMember(Name = "quantity")]
            public int quantity;
        }

        [DataMember(Name = "oferta_id")]
        public int oferta_id;

        [DataMember(Name = "lineas")]
        public List<Line> lineas;
    }

    // Oferta

    [DataContract(Namespace = Config.Namespace)]
    public class ExpOferta
    {
        public class Line
        {
            [DataMember(Name = "id")]
            public int id;

            [DataMember(Name = "linea_solicitud_id")]
            public int linea_solicitud_id;
        
            [DataMember(Name = "id_en_desguace")]
            public int id_en_desguace;

            [DataMember(Name = "notes")]
            public string notes;

            [DataMember(Name = "quantity")]
            public int quantity;

            [DataMember(Name = "price")]
            public double price;

            [DataMember(Name = "selected_ammount")]
            public int selected_ammount;

            [DataMember(Name = "date")]
            public DateTime date;
        }

        [DataMember(Name = "id")]
        public int id;

        [DataMember(Name = "id_en_desguace")]
        public int id_en_desguace;

        [DataMember(Name = "lineas")]
        public List<Line> lineas;

        [DataMember(Name = "solicitud_id")]
        public int solicitud_id;
    }

    // Others

    [DataContract(Namespace = Config.Namespace)]
    public class ExpTaller
    {
        [DataMember(Name = "name")]
        public string name;

        [DataMember(Name = "id")]
        public int id;

        [DataMember(Name = "active")]
        public bool active;
    }

    [DataContract(Namespace = Config.Namespace)]
    public class ExpDesguace
    {
        [DataMember(Name = "name")]
        public string name;

        [DataMember(Name = "id")]
        public int id;

        [DataMember(Name = "active")]
        public bool active;

        [DataMember(Name = "aes_key")]
        public byte[] aes_key;

        [DataMember(Name = "aes_iv")]
        public byte[] aes_iv;
    }

    [DataContract(Namespace = Config.Namespace)]
    public class TokenResponse
    {
        public enum Code : int { CREATED = 201, ACCEPTED = 202, NON_AUTHORITATIVE = 203, BAD_REQUEST = 400, NOT_FOUND = 404 };

        [DataMember(Name = "token")]
        public string token;

        [DataMember(Name = "status")]
        public Code status;

        public TokenResponse(string token, TokenResponse.Code status)
        {
            this.token = token;
            this.status = status;
        }
    }
}