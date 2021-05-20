using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeLanche.DAL.Migrations
{
    public partial class correcaoCampoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ValorMontado",
                table: "Ingredientes",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IngrdientesUsados",
                table: "Ingredientes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IngrdientesUsados",
                table: "Ingredientes");

            migrationBuilder.AlterColumn<int>(
                name: "ValorMontado",
                table: "Ingredientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
