using System;

namespace BankaMusteriTakibi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.Ad = "Engin";
            musteri.Soyad = "Demiroğ";
            musteri.Id = "12345678";
            musteri.TelNo = "32132131";
            musteri.Ikamet = "Ankara";
            musteri.DateTime = "10.01.1980";
            musteri.Cuzdan = 100.547;

            Musteri musteri1 = new Musteri();

            musteri1.Ad = "Emir Can";
            musteri1.Soyad = "Ünlütaş";
            musteri1.Id = "12345678";
            musteri1.TelNo = "12345678";
            musteri1.Ikamet = "İstanbul";
            musteri1.DateTime = "10.01.2003";
            musteri1.Cuzdan = 10.001;


            Musteri[] musteriler = new Musteri[]
            {
                musteri, musteri1
            };

            foreach (var bankaMusteri in musteriler)
            {
                Console.WriteLine("Id: " + bankaMusteri.Id);
                Console.WriteLine("İsim: " + bankaMusteri.Ad);
                Console.WriteLine("Soyisim:" + bankaMusteri.Soyad);
                Console.WriteLine("Telefon Numarası: " + bankaMusteri.TelNo);
                Console.WriteLine("Ikamet Ettiği Yer: " + bankaMusteri.Ikamet);
                Console.WriteLine("Doğum Tarihi " + bankaMusteri.DateTime);
                Console.WriteLine("Bakiye:" + bankaMusteri.Cuzdan);
                Console.WriteLine("---------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri);
            musteriManager.Add(musteri1);

            musteriManager.Delete(musteri);
            musteriManager.Delete(musteri1);

            musteriManager.Guncelle();
        }
    }
}
