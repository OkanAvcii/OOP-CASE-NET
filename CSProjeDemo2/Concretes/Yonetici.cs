using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concretes
{
    public class Yonetici : Personel
    {
        public double Bonus { get; set; }

        public override double MaasHesapla()
        {
            if (SaatlikUcret < 500)
                SaatlikUcret = 500;
            return (CalismaSaati * SaatlikUcret) + Bonus;
        }
    }
}
