using DemoPeliculas.Shared.Models;
using System;

namespace DemoPeliculas.Server.Data.Seed
{
    public class UsuarioSeed
    {
        public static Usuario[] Seed()
        {
            Usuario[] usuarios = new Usuario[]
            {
                new Usuario(){Id = 1, Tipo = "Adulto"},
                
                new Usuario(){Id = 2, Tipo = "Niño"},

            };

            return usuarios;
        }
    }
}
