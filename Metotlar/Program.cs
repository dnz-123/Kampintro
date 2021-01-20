using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            string urunAdi = "Elma";
            double fiyatı = 15;
            string acıklama = "Amasya Elması";

            string[] meyveler = new string[] { };



            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Acıklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Acıklama = "Diyarbakır karpuzu";




            Urun[] urunler = new Urun[] {urun1,urun2};


            //type-safe -- tip güvenliği
            foreach (var urun in urunler)
            {     
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("................................");
            }


             Console.WriteLine(".............Metotlar............");


             //İnstance - Örnek
             SepetManager sepetManager = new SepetManager();
             sepetManager.Ekle(urun1);
             sepetManager.Ekle(urun2);


             sepetManager.Ekle2("Armut", "Yeşil armut", 12);
             sepetManager.Ekle2("Elma", "Yeşil Elma", 12);





        }
    }
}


// Do not repeat yourself - DRY -- Best Practice