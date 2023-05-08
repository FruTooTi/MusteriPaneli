using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusteriPaneli.Migrations
{
    /// <inheritdoc />
    public partial class tweakedTurEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TurNumarasi",
                table: "telefonturleri");

            migrationBuilder.DropColumn(
                name: "TurNumarasi",
                table: "odemeturleri");

            migrationBuilder.DropColumn(
                name: "TurNumarasi",
                table: "adresturleri");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TurNumarasi",
                table: "telefonturleri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurNumarasi",
                table: "odemeturleri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurNumarasi",
                table: "adresturleri",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
