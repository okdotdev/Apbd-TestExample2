using System.Text.Json.Serialization;

namespace MusicApi.Models;

public class Muzyk
{
    public int IdMuzyk  { get; set; }
    public string Imie  { get; set; }
    public string Nazwisko  { get; set; }
    public string Pseudonim  { get; set; }

    public virtual ICollection<Utwor> WykonawcaUtworu { get; set; } = new List<Utwor>();
}