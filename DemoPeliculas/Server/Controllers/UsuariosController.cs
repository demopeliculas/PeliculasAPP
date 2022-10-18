using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoPeliculas.Server.Data;
using DemoPeliculas.Shared.Models;
using System.Web;

namespace DemoPeliculas.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PostCerrarSesion()
        {
            HttpContext.Session.Remove("idUsuarioLogin");

            return NoContent();
        }

        [HttpPost("{idUsuario}")]
        public IActionResult PostLoginUsuario(string idUsuario)
        {
            HttpContext.Session.SetString("idUsuarioLogin", idUsuario);

            return NoContent();
        }

        [HttpGet]
        public ActionResult<int> UsuarioVerificadoAsync()
        {
            var idUsuario = HttpContext.Session.GetString("idUsuarioLogin");

            if (idUsuario == null)
            {
                return 0;
            }

            return int.Parse(idUsuario);
        }

    }
}
