using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            //string = Console.WriteLine 
            //Do not repeat youself = Kendini  Tekrarlama

            string katagoriEtiketi = "Katagori";
            int ogrenciSayısı = 3200;
            double faizOranı = 1.45;
            double faizOranı1 = 1.50;
            bool sistemeGirisYapmısMı = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;



            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else 
            {
                Console.WriteLine("Değişmedi");
            }



            // Console.WriteLine(katagoriEtiketi);



             if (sistemeGirisYapmısMı == true)
             {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
             }
             else
             {
                Console.WriteLine("Giriş Yap Butonu");
             }
 
           




        }
    }
}
