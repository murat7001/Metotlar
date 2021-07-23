﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrununAdi = "Elma";
            urun1.UrununFiyati = 5;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrununAdi = "Karpuz";
            urun2.UrununFiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //foreach ile
            Console.WriteLine("foreach ile");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrununAdi);
                Console.WriteLine(urun.UrununFiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("-------Metotlar------");

            //instance-örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut", 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 10);
        }
    }
}
