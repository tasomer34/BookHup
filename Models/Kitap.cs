using System;

namespace BookHub.Models;

public class Kitap
{
    public int KitapId { get; set; }
    public string Ad { get; set; } = string.Empty;
    public string YayınEvi { get; set; } = "";
    public int YazarId { get; set; }
    public Yazar Yazar { get; set; }
}
