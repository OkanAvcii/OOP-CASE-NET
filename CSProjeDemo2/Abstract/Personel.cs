﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Abstract
{
    public abstract class Personel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public double SaatlikUcret { get; set; }
        public int CalismaSaati { get; set; }
        public abstract double MaasHesapla();
    }
}
