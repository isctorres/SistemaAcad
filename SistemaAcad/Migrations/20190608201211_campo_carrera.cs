using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAcad.Migrations
{
    public partial class campo_carrera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Carrera",
                table: "Categoria",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carrera",
                table: "Categoria");
        }
    }
}
