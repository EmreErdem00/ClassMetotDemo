using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> Musteriler = new List<Musteri>();
        public void MusteriEkle(Musteri musteri)
        {
            int Id = musteri.Id;
            string Ad = musteri.Ad;
            string Soyad = musteri.Soyad;
            int age = musteri.Age;
            Console.WriteLine(musteri.Ad +" " + "başarıyla eklenmiştir");
            Console.WriteLine("--------------------------------------------");
            Musteriler.Add(musteri);
            
            
        }

        public void MusteriListele()
        {
            foreach (var item in Musteriler)
            {
                Console.WriteLine( item.Ad +" "+ item.Soyad + " "+item.Age);
                Console.WriteLine("-----------------------------------------------");

            }
        }

        public void MusteriSil(Musteri musteri)
        {
           
                Console.WriteLine(musteri.Ad + " isme sahip müşteri silindi.");
            
            
               
                
            
        }
    }
}
