using System;
using System.Collections.Generic;
using System.Text;

namespace BankaMusteriTakibi
{
    class MusteriManager
    {
        public void Add(Musteri musteriler)
        {
            Console.WriteLine("Sisteme başarıyla eklendi ! " + musteriler.Ad + " " + musteriler.Soyad);
        }

        public void Delete(Musteri musteriler)
        {
            Console.WriteLine("Sistemden başarıyla silindi ! " + musteriler.Ad + " " + musteriler.Soyad);
        }

        public void Guncelle()
        {
            Console.WriteLine("Müşteri bilgisi güncellendi ! ");
        }
    }
}
