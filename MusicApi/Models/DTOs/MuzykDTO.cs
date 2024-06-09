namespace MusicApi.Models.DTOs;

public class MuzykDTO
{
    public string Imie  { get; set; }
    public string Nazwisko  { get; set; }
    public string Pseudonim  { get; set; }

    public virtual ICollection<UtworDTO> Utwory { get; set; } = new List<UtworDTO>();
}