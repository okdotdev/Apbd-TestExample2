namespace MusicApi.Models.DTOs;

public class AddMuzykDTO
{
    public string Imie  { get; set; }
    public string Nazwisko  { get; set; }
    public string Pseudonim  { get; set; }
    public int IdUtwor  { get; set; }
    public string NazwaUtworu  { get; set; }
    public float CzasTrwania  { get; set; }
}