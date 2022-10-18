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
    public class PeliculasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PeliculasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pelicula>>> GetPeliculas()
        {
            var idUsuario = int.Parse(HttpContext.Session.GetString("idUsuarioLogin"));

            if (idUsuario == 2)
            {
                return await _context.Peliculas.Where(x => x.EsInfantil == true).ToListAsync();
            }
            else
            {
                return await _context.Peliculas.ToListAsync();
            }
        }

    }
}
