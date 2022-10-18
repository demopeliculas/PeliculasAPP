using DemoPeliculas.Shared.Models;
using System;

namespace DemoPeliculas.Server.Data.Seed
{
    public class PeliculasSeed
    {
        public static Pelicula[] Seed()
        {
            Pelicula[] peliculas = new Pelicula[]
            {
                new Pelicula(){Id = 1, Titulo = "Tadeo 3: La Maldición de la Momia", NombreImagen = "tadeo.jpg", NombreVideo = "tadeo.mp4", Duracion = "1h 29m", FechaEstreno = DateTime.ParseExact("26/08/2022", "dd/MM/yyyy", null), EsInfantil = true, Descripcion = "Tadeo vuelve a meter la pata. Esta vez, el disparatado arqueólogo destroza un sarcófago y libera la maldición de la momia que había dentro. Los amigos de Tadeo están en peligro, y solo él puede salvarlos."},

                new Pelicula(){Id = 2, Titulo = "Operación Bebe oso", NombreImagen = "bebeOso.jpg", NombreVideo = "bebeOso.mp4", Duracion = "1h 30m", FechaEstreno = DateTime.ParseExact("06/10/2022", "dd/MM/yyyy", null), EsInfantil = true, Descripcion = "Ha pasado un año desde que Mic Mic y Oscar regresaron de su increíble aventura. Y ahora, después de un plan diabólico de Vulture para sabotear la entrega del cachorro Grizzly a su oponente en las elecciones presidenciales, Mic Mic, Oscar, Panda adolescente y Stork emprenden otra gran aventura mientras montan en un zepelín para regresar al pequeño Grizzly a sus legítimos padres, salven las elecciones y a todo el continente de la erupción del volcán."},

                new Pelicula(){Id = 3, Titulo = "Los buscamundos", NombreImagen = "buscamundos.jpg", NombreVideo = "buscamundos.mp4", Duracion = "1h 22m", FechaEstreno = DateTime.ParseExact("23/09/2022", "dd/MM/yyyy", null), EsInfantil = true, Descripcion = "Passepartout, un tití aficionado a los libros se embarca en una aventura salvaje para viajar alrededor del mundo en 80 días después de aceptar una apuesta."},

                new Pelicula(){Id = 4, Titulo = "Minions: nace un villano", NombreImagen = "minions.jpg", NombreVideo = "minions.mp4", Duracion = "1h 30m", FechaEstreno = DateTime.ParseExact("01/07/2022", "dd/MM/yyyy", null), EsInfantil = true, Descripcion = "En los años 70, Gru crece siendo un gran admirador de Los Salvajes Seis, un supergrupo de villanos. Para demostrarles que puede ser malvado, diseña un plan con la esperanza de formar parte de la banda."},

                new Pelicula(){Id = 5, Titulo = "DC Liga de Supermascotas", NombreImagen = "supermascotas.jpg", NombreVideo = "supermascotas.mp4", Duracion = "1h 45m", FechaEstreno = DateTime.ParseExact("29/07/2022", "dd/MM/yyyy", null), EsInfantil = true, Descripcion = "El superperro Krypto une a un grupo de divertidos y descerebrados animales para que lo ayuden a rescatar a los superhéroes de la Liga de la Justicia, que han sido secuestrados."},


                new Pelicula(){Id = 6, Titulo = "Bullet Train", NombreImagen = "bullet.jpg", NombreVideo = "bullet.mp4", Duracion = "2h 6m", FechaEstreno = DateTime.ParseExact("05/08/2022", "dd/MM/yyyy", null), EsInfantil = false, Descripcion = "En un tren de alta velocidad que se dirige de Tokio a Morioka, cinco asesinos profesionales descubren que van tras el mismo objetivo."},

                new Pelicula(){Id = 7, Titulo = "La chica salvaje", NombreImagen = "chicaSalvaje.jpg", NombreVideo = "chicaSalvaje.mp4", Duracion = "2h 5m", FechaEstreno = DateTime.ParseExact("30/09/2022", "dd/MM/yyyy", null), EsInfantil = false, Descripcion = "Una mujer solitaria que vive en los inhóspitos pantanos de Carolina del Norte se convierte en la principal sospechosa del asesinato de un hombre cuyo cadáver apareció en la zona. Sin embargo, la investigación revela que nada es lo que aparenta ser."},

                new Pelicula(){Id = 8, Titulo = "Padre no hay más que uno 3", NombreImagen = "padre.jpg", NombreVideo = "padre.mp4", Duracion = "1h 39m", FechaEstreno = DateTime.ParseExact("14/07/2022", "dd/MM/yyyy", null), EsInfantil = false, Descripcion = "Los niños rompen accidentalmente una figurilla del Belén de colección de su padre y deben conseguir por todos los medios una igual, el problema es que es una pieza única de anticuario. Sara, la hija mayor rompe con su novio, Ocho, que intentará recuperar sus favores con la ayuda de su suegro, Javier. Precisamente el suegro de Javier, el padre de Marisa, será acogido en la casa familiar para pasar las fiestas tras su reciente separación, lo cual no dejará indiferente a la madre de Javier, Milagros."},

                new Pelicula(){Id = 9, Titulo = "Viaje al paraiso", NombreImagen = "viajeParaiso.jpg", NombreVideo = "viajeParaiso.mp4", Duracion = "1h 44m", FechaEstreno = DateTime.ParseExact("19/09/2022", "dd/MM/yyyy", null), EsInfantil = false, Descripcion = "Una pareja divorciada deja a un lado sus diferencias y viaja a Bali para evitar que su hija cometa el mismo error en el que ellos cayeron hace 25 años: casarse."},

                new Pelicula(){Id = 10, Titulo = "Vértigo", NombreImagen = "vertigo.jpg", NombreVideo = "vertigo.mp4", Duracion = "1h 47m", FechaEstreno = DateTime.ParseExact("28/10/2022", "dd/MM/yyyy", null), EsInfantil = false, Descripcion = "Becky y Hunter, dos amigas aficionadas al alpinismo, quedan atrapadas en la torre de telecomunicaciones de la cima de una montaña que acaban de escalar. Sin provisiones y afectadas por el vértigo, comienza la lucha por la supervivencia."},
            };
            
            return peliculas;

        }
    }
}
