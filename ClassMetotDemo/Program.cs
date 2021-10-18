using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "ahmet";
            musteri1.Soyad = "bekir";
            musteri1.TelefonNo = 0534343434;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "ahmet";
            musteri2.Soyad = "bekir";
            musteri2.TelefonNo = 0534343434;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "ahmet";
            musteri3.Soyad = "bekir";
            musteri3.TelefonNo = 0534343434;


            MusteriManage musteriManage = new MusteriManage();
            musteriManage.Ekle(musteri1);
            musteriManage.Ekle(musteri2);
            musteriManage.Ekle(musteri3);

            musteriManage.Guncelle();

            musteriManage.Cikar(musteri2);

            musteriManage.Guncelle();

            Console.ReadLine();



        }
    }
}
