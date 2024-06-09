namespace MusicApi.Models;

public class Wytwornia
{
    public int IdWytwornia { get; set; }
    public string Nazwa  { get; set; }

    public virtual ICollection<Album> Albumy { get; set; } = new List<Album>();
 }