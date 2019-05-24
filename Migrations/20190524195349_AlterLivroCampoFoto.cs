using Microsoft.EntityFrameworkCore.Migrations;

namespace dotNET_2019.Migrations
{
    public partial class AlterLivroCampoFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Livro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Livro");
        }
    }
}
