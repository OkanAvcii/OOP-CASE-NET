using CSProjeDemo2.Abstract;
using CSProjeDemo2.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace CSProjeDemo2.Services
{
    public class DosyaOku
    {
        public static List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            var json = File.ReadAllText(dosyaYolu);
            var personeller = JsonSerializer.Deserialize<List<PersonelJson>>(json);
            var personelListesi = new List<Personel>();

            foreach (var p in personeller)
            {
                if (p.Title == "Yonetici")
                    personelListesi.Add(new Yonetici { Name = p.Name, Title = p.Title, SaatlikUcret = 500, Bonus = 1000 });
                else
                    personelListesi.Add(new Memur { Name = p.Name, Title = p.Title, SaatlikUcret = 500 });
            }
            return personelListesi;
        }
        private class PersonelJson { public string Name { get; set; } public string Title { get; set; } }
    }
}
