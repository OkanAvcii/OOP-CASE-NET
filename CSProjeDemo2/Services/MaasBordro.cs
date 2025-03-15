using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2.Services
{
    public class MaasBordro
    {
        public static void BordroHesaplaVeKaydet(List<Personel> personeller)
        {
            foreach (var personel in personeller)
            {
                double maas = personel.MaasHesapla();
                var maasBilgisi = new
                {
                    PersonelIsmi = personel.Name,
                    CalismaSaati = personel.CalismaSaati,
                    AnaOdeme = maas,
                    ToplamOdeme = maas
                };
                string klasorYolu = Path.Combine("MaasBordrolari", personel.Name);
                Directory.CreateDirectory(klasorYolu);
                string dosyaYolu = Path.Combine(klasorYolu, "bordro.json");
                File.WriteAllText(dosyaYolu, JsonSerializer.Serialize(maasBilgisi, new JsonSerializerOptions { WriteIndented = true }));
            }
        }
    }
}
