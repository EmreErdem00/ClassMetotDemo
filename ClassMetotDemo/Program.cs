using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Emre";
            musteri1.Soyad = "Erdem";
            musteri1.Age = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Nida";
            musteri2.Soyad = "Erdem";
            musteri2.Age = 21;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Emel";
            musteri3.Soyad = "Erdem";
            musteri3.Age = 27;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListele();
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriListele();


            Console.ReadKey();
        }
    }
}
