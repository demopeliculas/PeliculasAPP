using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoPeliculas.Server.Data;
using DemoPeliculas.Shared.Models;

namespace DemoPeliculas.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuntuacionesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PuntuacionesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Puntuacion>>> GetPuntuaciones()
        {
            return await _context.Puntuaciones.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> PostPuntuacion(Puntuacion puntuacion)
        {
            var idUsuario = int.Parse(HttpContext.Session.GetString("idUsuarioLogin"));

            puntuacion.IdUsuario = idUsuario;

            var puntuacionEnBBDD = await _context.Puntuaciones.FirstOrDefaultAsync(x => x.IdPelicula == puntuacion.IdPelicula && x.IdUsuario == puntuacion.IdUsuario);

            if (puntuacionEnBBDD != null)
            {
                _context.Puntuaciones.Remove(puntuacionEnBBDD);
            }

            _context.Puntuaciones.Add(puntuacion);

            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
