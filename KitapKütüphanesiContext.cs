using BookHub.Models;
using Microsoft.EntityFrameworkCore;

namespace BookHub;

public class KitapKütüphanesiContext:DbContext
{
    public DbSet<Kitap>? Kitaplar { get; set; }
    public DbSet<Yazar>? Yazarlar { get; set; }


    //!DbContextOptionsBuilder parametresi, veritabanı bağlantı seçeneklerini yapılandırmak için kullanılır.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=Localhost,1440 ; Database=KitapKütüphanesi ; User Id =SA ; Password =YourStrong@Passw0rd;TrustServerCertificate=True");
    }
}
