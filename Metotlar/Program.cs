using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakir karpuzu";

            Product[] Urunler = new Product[] {urun1,urun2 };

            foreach (var urun in Urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------");
            }

            //instance - orenk
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "sari armut", 14 ,4);
            sepetManager.Ekle2("elma", "yesil elma", 8 , 6);
            sepetManager.Ekle2("karpus", "diyarbakir", 11 , 5);


        }
    }
}
