using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoPeliculas.Shared.Models
{
    public class Pelicula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? NombreImagen { get; set; }
        public string? NombreVideo { get; set; }
        public string? Descripcion { get; set; }
        public string Duracion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public bool EsInfantil { get; set; }

    }
}