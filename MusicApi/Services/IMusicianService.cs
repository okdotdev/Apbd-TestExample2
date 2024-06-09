using MusicApi.Models;
using MusicApi.Models.DTOs;

namespace MusicApi.Services;

public interface IMusicianService
{
    Task<MuzykDTO>GetMuzyk(int idMusician);
    Task<bool> AddMuzyk(AddMuzykDTO newMuzyk);
    Task<bool> DeleteMuzyk(int idMuzyk);
}