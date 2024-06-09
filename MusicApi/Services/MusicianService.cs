using MusicApi.Models;
using MusicApi.Models.DTOs;
using MusicApi.Repositories;

namespace MusicApi.Services;

public class MusicianService : IMusicianService
{
    private readonly IMusicianRepository _musicianRepository;

    public MusicianService(IMusicianRepository musicianRepository)
    {
        _musicianRepository = musicianRepository;
    }

    public async Task<MuzykDTO> GetMuzyk(int idMusician)
    {
        return await _musicianRepository.GetMuzyk(idMusician);
    }

    public async Task<bool> AddMuzyk(AddMuzykDTO newMuzyk)
    {
        return await _musicianRepository.AddMuzyk(newMuzyk);
    }

    public async Task<bool> DeleteMuzyk(int idMuzyk)
    {
        return await _musicianRepository.DeleteMuzyk(idMuzyk);
    }
}