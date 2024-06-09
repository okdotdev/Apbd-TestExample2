
using Microsoft.AspNetCore.Mvc;
using MusicApi.Models.DTOs;
using MusicApi.Services;

namespace MusicApi.Controllers;

[ApiController]
[Route("/api/musician")]
public class MusicianController : ControllerBase
{
    private readonly IMusicianService _musicianService;

    public MusicianController(IMusicianService musicianService)
    {
        _musicianService = musicianService;
    }

    [HttpGet("{idMuzyk}")]
    public async Task<IActionResult> GetMuzyk(int idMuzyk)
    {
        try
        {
            var result = await _musicianService.GetMuzyk(idMuzyk);
            return Ok(result);
        }
        catch(Exception e)
        {
            return NotFound(e.Message);
        }

    }
    [HttpPost]
    public async Task<IActionResult> AddMuzyk(AddMuzykDTO newMuzyk)
    {

            var result = await _musicianService.AddMuzyk(newMuzyk);

            if(result)
                return Ok("Dodano Muzyka");
            return BadRequest("Nie udało się dodać muzyka");

    }
}