using Microsoft.EntityFrameworkCore.Migrations;

namespace dotNET_2019.Migrations
{
    public partial class AlterTableLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterColumn<string>(
            //     name: "Titulo",
            //     table: "Livro",
            //     maxLength: 200,
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Livro",
                maxLength: 200,
                nullable: false,
                defaultValue:"");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Livro",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Livro");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Livro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }
    }
}
