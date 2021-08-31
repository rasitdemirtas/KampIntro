using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string aciklama2 = "Çilek gibi Çilek";

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklamasi = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { urun1, urun2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi + " Fiyatı " + product.Fiyati + " Tipi " + product.Aciklamasi);
               
               Console.WriteLine("-------------------");
            }

            Console.WriteLine("---------------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Dİyarbakır Karpuzu", 12,8);


        }
    }
}
