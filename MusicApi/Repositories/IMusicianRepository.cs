using MusicApi.Models;
using MusicApi.Models.DTOs;

namespace MusicApi.Repositories;

public interface IMusicianRepository
{
    Task<MuzykDTO>GetMuzyk(int idMusician);
    Task<bool> AddMuzyk(AddMuzykDTO newMuzyk);
    Task<bool> DeleteMuzyk(int idMuzyk);
}