using CSProjeDemo2.Services;

namespace Program.cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dosyaYolu = "personeller.json";
            var personeller = DosyaOku.PersonelListesiOku(dosyaYolu);
            MaasBordro.BordroHesaplaVeKaydet(personeller);

            Console.WriteLine("Maaş bordroları hesaplandı ve kaydedildi.");
        }
    }
}
