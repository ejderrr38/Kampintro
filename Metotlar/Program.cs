﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("...........");
            }

            Console.WriteLine("-------------Metotlar------------");
            //instance - örnek
            //metot bana tekrar tekrar aynı şeyi kullanma imkanı verdi
            //encapsulation - kapsülleme demek ayrı ayrı yazacağın şeyi biraraya yazıyorsun.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,2);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,6);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,9);




        }
    }
}


//metotlar tekrar tkrr kullanılabılmeyı sağlar
//dont repeat yourself-DRY - Clean Code- Best practice
