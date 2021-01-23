using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //do not repeat yourself = kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani =1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
