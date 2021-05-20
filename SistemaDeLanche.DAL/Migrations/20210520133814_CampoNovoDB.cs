using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeLanche.DAL.Migrations
{
    public partial class CampoNovoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredientes",
                table: "Lanches",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredientes",
                table: "Lanches");
        }
    }
}
