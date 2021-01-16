using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safee -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------------Metotlar-----------");

            //instance - örnek
            // encapsulation 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12,10);
            sepetManager.Ekle2("elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,8);

        }
    }
}



//do not repeat yourself - dry - clean code - best practice