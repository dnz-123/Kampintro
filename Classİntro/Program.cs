using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Engin";
            int yas = 30;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOranı = 68 ;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Paython";
            kurs2.Egitmen = "Kerem Bilgin";
            kurs2.İzlenmeOranı = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Java";
            kurs3.Egitmen = "Deniz Güneş";
            kurs3.İzlenmeOranı = 120;


            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {

        public string KursAdı { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeOranı { get; set; }

    }
   


}
