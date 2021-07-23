using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun
            )
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.UrununAdi);
        }

        public void Ekle2(string urununAdi,string aciklama, double urununFiyati)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urununAdi);
        }

    }
}
