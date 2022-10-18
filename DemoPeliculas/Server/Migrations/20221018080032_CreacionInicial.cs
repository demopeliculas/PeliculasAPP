using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoPeliculas.Server.Migrations
{
    public partial class CreacionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaReproduccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdPelicula = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaReproduccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EsInfantil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puntuaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdPelicula = table.Column<int>(type: "int", nullable: false),
                    Calificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puntuaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "Descripcion", "Duracion", "EsInfantil", "FechaEstreno", "NombreImagen", "NombreVideo", "Titulo" },
                values: new object[,]
                {
                    { 1, "Tadeo vuelve a meter la pata. Esta vez, el disparatado arqueólogo destroza un sarcófago y libera la maldición de la momia que había dentro. Los amigos de Tadeo están en peligro, y solo él puede salvarlos.", "1h 29m", true, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "tadeo.jpg", "tadeo.mp4", "Tadeo 3: La Maldición de la Momia" },
                    { 2, "Ha pasado un año desde que Mic Mic y Oscar regresaron de su increíble aventura. Y ahora, después de un plan diabólico de Vulture para sabotear la entrega del cachorro Grizzly a su oponente en las elecciones presidenciales, Mic Mic, Oscar, Panda adolescente y Stork emprenden otra gran aventura mientras montan en un zepelín para regresar al pequeño Grizzly a sus legítimos padres, salven las elecciones y a todo el continente de la erupción del volcán.", "1h 30m", true, new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "bebeOso.jpg", "bebeOso.mp4", "Operación Bebe oso" },
                    { 3, "Passepartout, un tití aficionado a los libros se embarca en una aventura salvaje para viajar alrededor del mundo en 80 días después de aceptar una apuesta.", "1h 22m", true, new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "buscamundos.jpg", "buscamundos.mp4", "Los buscamundos" },
                    { 4, "En los años 70, Gru crece siendo un gran admirador de Los Salvajes Seis, un supergrupo de villanos. Para demostrarles que puede ser malvado, diseña un plan con la esperanza de formar parte de la banda.", "1h 30m", true, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "minions.jpg", "minions.mp4", "Minions: nace un villano" },
                    { 5, "El superperro Krypto une a un grupo de divertidos y descerebrados animales para que lo ayuden a rescatar a los superhéroes de la Liga de la Justicia, que han sido secuestrados.", "1h 45m", true, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "supermascotas.jpg", "supermascotas.mp4", "DC Liga de Supermascotas" },
                    { 6, "En un tren de alta velocidad que se dirige de Tokio a Morioka, cinco asesinos profesionales descubren que van tras el mismo objetivo.", "2h 6m", false, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bullet.jpg", "bullet.mp4", "Bullet Train" },
                    { 7, "Una mujer solitaria que vive en los inhóspitos pantanos de Carolina del Norte se convierte en la principal sospechosa del asesinato de un hombre cuyo cadáver apareció en la zona. Sin embargo, la investigación revela que nada es lo que aparenta ser.", "2h 5m", false, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "chicaSalvaje.jpg", "chicaSalvaje.mp4", "La chica salvaje" },
                    { 8, "Los niños rompen accidentalmente una figurilla del Belén de colección de su padre y deben conseguir por todos los medios una igual, el problema es que es una pieza única de anticuario. Sara, la hija mayor rompe con su novio, Ocho, que intentará recuperar sus favores con la ayuda de su suegro, Javier. Precisamente el suegro de Javier, el padre de Marisa, será acogido en la casa familiar para pasar las fiestas tras su reciente separación, lo cual no dejará indiferente a la madre de Javier, Milagros.", "1h 39m", false, new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "padre.jpg", "padre.mp4", "Padre no hay más que uno 3" },
                    { 9, "Una pareja divorciada deja a un lado sus diferencias y viaja a Bali para evitar que su hija cometa el mismo error en el que ellos cayeron hace 25 años: casarse.", "1h 44m", false, new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "viajeParaiso.jpg", "viajeParaiso.mp4", "Viaje al paraiso" },
                    { 10, "Becky y Hunter, dos amigas aficionadas al alpinismo, quedan atrapadas en la torre de telecomunicaciones de la cima de una montaña que acaban de escalar. Sin provisiones y afectadas por el vértigo, comienza la lucha por la supervivencia.", "1h 47m", false, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "vertigo.jpg", "vertigo.mp4", "Vértigo" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 1, "Adulto" },
                    { 2, "Niño" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaReproduccion");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Puntuaciones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
