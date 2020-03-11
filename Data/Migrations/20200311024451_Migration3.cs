using Microsoft.EntityFrameworkCore.Migrations;

namespace MultasTransito.Data.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Municipios");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Municipios");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehiculo",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "IdMulta",
                table: "Vehiculo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NumeroPlaca",
                table: "Vehiculo",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Monto",
                table: "Multas",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_IdMulta",
                table: "Vehiculo",
                column: "IdMulta");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Multas_IdMulta",
                table: "Vehiculo",
                column: "IdMulta",
                principalTable: "Multas",
                principalColumn: "IdMulta",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Multas_IdMulta",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_IdMulta",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "IdMulta",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "NumeroPlaca",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Multas");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehiculo",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MultasIdMulta",
                table: "Vehiculo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Municipios",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Municipios",
                nullable: false,
                defaultValue: false);

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
    }
}
