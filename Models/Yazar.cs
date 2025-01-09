using System;

namespace BookHub.Models;

public class Yazar
{
    public int YazarId { get; set; }
    public string Ad { get; set; } = "";
    public string Soyad { get; set; } = "";
    public ICollection<Kitap>? Kitaplar { get; set; } 
}
