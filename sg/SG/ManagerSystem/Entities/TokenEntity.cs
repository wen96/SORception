﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManagerSystem.Entities
{
    public enum TokenStatus
    {
        VALID,
        TEMPORAL,
        EXPIRED
    }

    public class TokenEntity : AbstractEntity
    {
        public string token { get; set; }

        public TokenStatus status { get; set; }

        public int scrapyard_id { get; set; }

        public int garage_id { get; set; }

        [ForeignKey("scrapyard_id")]
        public virtual ScrapyardEntity scrapyard { get; set; }

        [ForeignKey("garage_id")]
        public virtual GarageEntity garage { get; set; }
    }
}