﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Ticari_Otomasyon.Models.Siniflar
{
    public class DinamikFatura
    {
        public IEnumerable<Faturalar> deger1 { get; set; }
        public IEnumerable<FaturaKalem> deger2 { get; set; }
    }
}