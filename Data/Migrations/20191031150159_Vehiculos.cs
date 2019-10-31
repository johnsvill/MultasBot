using Microsoft.EntityFrameworkCore.Migrations;

namespace MultasTransito.Data.Migrations
{
    public partial class Vehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Municipios_MunicipiosIdMunicipalidad",
                table: "Municipios");

            migrationBuilder.DropIndex(
                name: "IX_Municipios_MunicipiosIdMunicipalidad",
                table: "Municipios");

            migrationBuilder.DropColumn(
                name: "MunicipiosIdMunicipalidad",
                table: "Municipios");

            migrationBuilder.AddColumn<int>(
                name: "MultasIdMulta",
                table: "Vehiculo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_MultasIdMulta",
                table: "Vehiculo",
                column: "MultasIdMulta");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Multas_MultasIdMulta",
                table: "Vehiculo",
                column: "MultasIdMulta",
                principalTable: "Multas",
                principalColumn: "IdMulta",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Multas_MultasIdMulta",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_MultasIdMulta",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "MultasIdMulta",
                table: "Vehiculo");

            migrationBuilder.AddColumn<int>(
                name: "MunicipiosIdMunicipalidad",
                table: "Municipios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_MunicipiosIdMunicipalidad",
                table: "Municipios",
                column: "MunicipiosIdMunicipalidad");

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Municipios_MunicipiosIdMunicipalidad",
                table: "Municipios",
                column: "MunicipiosIdMunicipalidad",
                principalTable: "Municipios",
                principalColumn: "IdMunicipalidad",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
