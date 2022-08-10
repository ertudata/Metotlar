using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elmasi";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Amasya karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-----metotlar-----");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);


        }
    }
}
