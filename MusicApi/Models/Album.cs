namespace MusicApi.Models;

public class Album
{
    public int IdAlbum  { get; set; }
    public string NazwaAlbumu  { get; set; }
    public DateTime DataWydania  { get; set; }
    public Wytwornia Wytwornia { get; set; }
    public int IdWytwornia { get; set; }
    public virtual ICollection<Utwor> Utwory { get; set; } = new List<Utwor>();
}