namespace MusicApi.Models;

public class Utwor
{
    public int IdUtwor  { get; set; }
    public string NazwaUtworu  { get; set; }
    public float CzasTrwania  { get; set; }
    public Album Album  { get; set; }
    public int IdAlbum { get; set; }
    public virtual ICollection<Muzyk> WykonawcaUtworu { get; set; } = new List<Muzyk>();
}