using BookHub.Models;
using Microsoft.EntityFrameworkCore;

namespace BookHub;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new KitapKütüphanesiContext())
        {
          
            var yazar1 = new Yazar { Ad = "Orhan", Soyad = "Pamuk" };
            var yazar2 = new Yazar { Ad = "Elif", Soyad = "Şafak" };

  
            var kitap1 = new Kitap { Ad = "Beyaz Kale", YayınEvi = "Yayıncı A", Yazar = yazar1 };
            var kitap2 = new Kitap { Ad = "İstanbul", YayınEvi = "Yayıncı B", Yazar = yazar1 };
            var kitap3 = new Kitap { Ad = "İskender", YayınEvi = "Yayıncı C", Yazar = yazar2 };

            // Veritabanına ekleme
            context.Yazarlar.AddRange(yazar1, yazar2);
            context.Kitaplar.AddRange(kitap1, kitap2, kitap3);
            context.SaveChanges();

            // Veri sorgulama
            var kitaplar = context.Kitaplar
                                  .Include(k => k.Yazar)
                                  .ToList();


            foreach (var kitap in kitaplar)
            {
                Console.WriteLine($"Kitap: {kitap.Ad}, Yazar: {kitap.Yazar.Ad} {kitap.Yazar.Soyad}");
            }
        }
    }
}
