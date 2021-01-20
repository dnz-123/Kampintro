using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) 
        {
            Console.WriteLine(" Tebrikler! Sepete eklendi : " + urun.Adi );
        }

        public void Ekle2(string urunAdı, string acıklma, double fiyat)
        {

            Console.WriteLine("tebrikler. sepete eklendi : " + urunAdı);
            
        }

    }

