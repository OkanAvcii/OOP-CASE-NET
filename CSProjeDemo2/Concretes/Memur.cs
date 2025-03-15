using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concretes
{
    public class Memur : Personel
    {
        public override double MaasHesapla()
        {
            double anaMaas = Math.Min(CalismaSaati, 180) * SaatlikUcret;
            double mesai = Math.Max(CalismaSaati - 180, 0) * (SaatlikUcret * 1.5);
            return anaMaas + mesai;
        }
    }
}
