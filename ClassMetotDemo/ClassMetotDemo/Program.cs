using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string BankaM = "Banka Müşterilerimiz";
            Console.WriteLine("\t\t\t\t\t" + BankaM);

            Musteri Musteri1 = new Musteri();
            Musteri1.MusteriAdıSoyadı = "Cengiz Aydınalp";
            Musteri1.Yaşı = 25;
            Musteri1.Id = 1;

            Musteri Musteri2 = new Musteri();
            Musteri2.MusteriAdıSoyadı = "Furkan Taşkıran";
            Musteri2.Yaşı = 19; 
            Musteri2.Id = 2;

            Musteri Musteri3 = new Musteri();
            Musteri3.MusteriAdıSoyadı = "Necip Gözüpek";
            Musteri3.Yaşı = 39;
            Musteri3.Id = 3;

            Musteri[] musteriler = new Musteri[] { Musteri1 , Musteri2 , Musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("\nMüşterimizin Adı Ve Soyadı :" +" "+ musteri.MusteriAdıSoyadı);
                Console.WriteLine("Müşterimizin Yaşı :" +" "+ musteri.Yaşı);
                Console.WriteLine("Müşterimizin Id Numarası :" +" "+ musteri.Id);
            }

           
            string MusteriH = "Müşteri Hizmetleri";
            Console.WriteLine("\t\t\t\t\t" + MusteriH);

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(Musteri1);
            musteriManager.MusteriSil(Musteri2);
           

           


            

           
           
        }
    }
}

           

           

            
            

            


