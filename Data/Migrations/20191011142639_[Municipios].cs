using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MultasTransito.Data.Migrations
{
    public partial class Municipios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    IdMulta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMunicipalidad = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    IdPlaca = table.Column<int>(nullable: false),
                    Idnit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.IdMulta);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    IdMunicipalidad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    MunicipiosIdMunicipalidad = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.IdMunicipalidad);
                    table.ForeignKey(
                        name: "FK_Municipios_Municipios_MunicipiosIdMunicipalidad",
                        column: x => x.MunicipiosIdMunicipalidad,
                        principalTable: "Municipios",
                        principalColumn: "IdMunicipalidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    IdNit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Licencia = table.Column<int>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.IdNit);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    IdPlaca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(nullable: false),
                    IdNit = table.Column<int>(nullable: false),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Año = table.Column<int>(nullable: false),
                    TipoPlaca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.IdPlaca);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_MunicipiosIdMunicipalidad",
                table: "Municipios",
                column: "MunicipiosIdMunicipalidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Multas");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropTable(
                name: "Vehiculo");
        }
    }
}
