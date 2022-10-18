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
    public class ListaReproduccionesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ListaReproduccionesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pelicula>>> GetPeliculasPorListaReproduccion()
        {
            var idUsuario = int.Parse(HttpContext.Session.GetString("idUsuarioLogin"));
            var listaReproduccion = await _context.ListaReproduccion.Where(x => x.IdUsuario == idUsuario).ToListAsync();
            var peliculas = await _context.Peliculas.ToListAsync();
            var peliculasEnReproduccion = peliculas.Where(x => listaReproduccion.Any(y => y.IdPelicula == x.Id)).ToList();

            return peliculasEnReproduccion;
        }

        [HttpPost("{idPelicula}")]
        public async Task<IActionResult> PostListaReproduccion(int idPelicula)
        {
            var idUsuario = int.Parse(HttpContext.Session.GetString("idUsuarioLogin"));

            var listaReproduccion = new ListaReproduccion()
            {
                IdPelicula = idPelicula,
                IdUsuario = idUsuario
            };

            if (_context.ListaReproduccion.Count(x => x.IdPelicula == listaReproduccion.IdPelicula && x.IdUsuario == listaReproduccion.IdUsuario) == 0)
            {
                _context.ListaReproduccion.Add(listaReproduccion);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }

        [HttpDelete("{idPelicula}")]
        public async Task<IActionResult> DeleteListaReproduccion(int idPelicula)
        {
            var idUsuario = int.Parse(HttpContext.Session.GetString("idUsuarioLogin"));
            var listaReproduccion = await _context.ListaReproduccion.FirstOrDefaultAsync(x => x.IdPelicula == idPelicula && x.IdUsuario == idUsuario);
            if (listaReproduccion == null)
            {
                return NotFound();
            }

            _context.ListaReproduccion.Remove(listaReproduccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
