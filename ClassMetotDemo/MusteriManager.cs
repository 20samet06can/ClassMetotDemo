using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri1)
        {
            Console.WriteLine("Adı ve Soyadı" + " " + musteri1.MusteriAdıSoyadı + " " + "Olan");
            Console.WriteLine("Yaşı" + " " + musteri1.Yaşı + " " + "Olan");
            Console.WriteLine(musteri1.MusteriAdıSoyadı + " " + "Adlı Müsterimizin Bankamıza Üyeliği Onaylanmıştırr");
            Console.WriteLine("Id'si =" + " " + musteri1.Id + " " + "dir");
        }

        public void MusteriSil(Musteri musteri2)
        {
            Console.WriteLine("\nAdı ve Soyadı" + " " + musteri2.MusteriAdıSoyadı + " " + "Olan");
            Console.WriteLine("Yaşı" + " " + musteri2.Yaşı + " " + "Olan");
            Console.WriteLine(musteri2.MusteriAdıSoyadı + " " + "Adlı Müsterimizin Bankamıza Olan Üyeliği İptal Edilmiş Ve Silinmiş Bulunmaktadır");
        }
    }
}
        

