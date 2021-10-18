using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManage
    {
        public MusteriManage()
        {

        }
        public void Ekle(Musteri gelenMusteri)
        {
            Console.WriteLine(gelenMusteri.Adi + " " + gelenMusteri.Soyad + " isimli musterimiz listeye eklenmistir");
        }
        public void Cikar(Musteri gelenMusteri)
        {
            Console.WriteLine(gelenMusteri.Adi + " " + gelenMusteri.Soyad + " isimli musterimiz listeye Cikarilmistir");
        }
        public void Guncelle()
        {
            Console.WriteLine("Liste guncellemesi basariyla gerceklesti");
        }
    }
}
