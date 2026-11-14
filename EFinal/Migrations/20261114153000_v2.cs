using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFinal.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Los vehiculos que ya existen quedan como activos
            migrationBuilder.AddColumn<bool>(
                name: "estado",
                table: "tbVehiculo",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estado",
                table: "tbVehiculo");
        }
    }
}
