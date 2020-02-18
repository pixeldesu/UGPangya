﻿using System;

namespace UGPangya.API.Repository.Models
{
    public class CardEquip
    {
        public int Id { get; set; }

        public int UID { get; set; }

        public int? CHAR_TYPEID { get; set; }

        public int? CARD_TYPEID { get; set; }

        public int? SLOT { get; set; }

        public DateTime? REGDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public byte? FLAG { get; set; }

        public byte? VALID { get; set; }
    }
}