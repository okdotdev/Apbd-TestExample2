using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using MusicApi.Models;
using MusicApi.Models.DTOs;

namespace MusicApi.Repositories;

public class MusicianRepository : IMusicianRepository
{
    private readonly AppDbContext _appDbContext;

    public MusicianRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<MuzykDTO> GetMuzyk(int idMusician)
    {
        Muzyk? muzyk = await _appDbContext.Muzycy
            .Include(m => m.WykonawcaUtworu)
            .FirstOrDefaultAsync(m => m.IdMuzyk == idMusician);

        if (muzyk == null)
        {
            throw new Exception("Nie znaleziono muzyka");
        }

        MuzykDTO result = new MuzykDTO()
        {
            Imie = muzyk.Imie,
            Nazwisko = muzyk.Nazwisko,
            Pseudonim = muzyk.Pseudonim,
            Utwory = muzyk.WykonawcaUtworu.Select(u => new UtworDTO
                {
                    IdUtwor = u.IdUtwor,
                    NazwaUtworu = u.NazwaUtworu,
                    CzasTrwania = u.CzasTrwania
                }
            ).ToList()
        };


        return result;
    }

    public async Task<bool> AddMuzyk(AddMuzykDTO newMuzyk)
    {
        try
        {


            Muzyk muzyk = new Muzyk
            {
                Imie = newMuzyk.Imie,
                Nazwisko = newMuzyk.Nazwisko,
                Pseudonim = newMuzyk.Pseudonim,
                WykonawcaUtworu = new List<Utwor>()
            };


            Utwor? utwor = await _appDbContext.Utory
                .Include(m => m.WykonawcaUtworu)
                .FirstOrDefaultAsync(m => m.IdUtwor == newMuzyk.IdUtwor);

            if (utwor == null)
            {
                Utwor newUtwor = new Utwor
                {
                    NazwaUtworu = newMuzyk.NazwaUtworu,
                    CzasTrwania = newMuzyk.CzasTrwania,
                    WykonawcaUtworu = new List<Muzyk>()
                };

                newUtwor.WykonawcaUtworu.Add(muzyk);
                muzyk.WykonawcaUtworu.Add(newUtwor);
                await _appDbContext.AddAsync(muzyk);
                await _appDbContext.Utory.AddAsync(newUtwor);
                await _appDbContext.SaveChangesAsync();
                return true;
            }

            muzyk.WykonawcaUtworu.Add(utwor);
            await _appDbContext.AddAsync(muzyk);
            await _appDbContext.SaveChangesAsync();


            return true;

        }
        catch (Exception e)
        {

            return false;
        }
    }
}