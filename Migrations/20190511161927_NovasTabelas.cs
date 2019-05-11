using Microsoft.EntityFrameworkCore.Migrations;

namespace dotNET_2019.Migrations
{
    public partial class NovasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sistema",
                columns: table => new
                {
                    SistemaID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistema", x => x.SistemaID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CategoriaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Emprestimo",
                columns: table => new
                {
                    EmprestimoID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioID = table.Column<int>(nullable: false),
                    DataInicio = table.Column<string>(nullable: true),
                    DataFim = table.Column<string>(nullable: true),
                    DataDevolucao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimo", x => x.EmprestimoID);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SistemaUsuario",
                columns: table => new
                {
                    SistemaID = table.Column<int>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaUsuario", x => new { x.SistemaID, x.UsuarioID });
                    table.ForeignKey(
                        name: "FK_SistemaUsuario_Sistema_SistemaID",
                        column: x => x.SistemaID,
                        principalTable: "Sistema",
                        principalColumn: "SistemaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SistemaUsuario_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivroEmprestimo",
                columns: table => new
                {
                    LivroID = table.Column<int>(nullable: false),
                    EmprestimoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroEmprestimo", x => new { x.LivroID, x.EmprestimoID });
                    table.ForeignKey(
                        name: "FK_LivroEmprestimo_Emprestimo_EmprestimoID",
                        column: x => x.EmprestimoID,
                        principalTable: "Emprestimo",
                        principalColumn: "EmprestimoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivroEmprestimo_Livro_LivroID",
                        column: x => x.LivroID,
                        principalTable: "Livro",
                        principalColumn: "LivroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_UsuarioID",
                table: "Emprestimo",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_LivroEmprestimo_EmprestimoID",
                table: "LivroEmprestimo",
                column: "EmprestimoID");

            migrationBuilder.CreateIndex(
                name: "IX_SistemaUsuario_UsuarioID",
                table: "SistemaUsuario",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivroEmprestimo");

            migrationBuilder.DropTable(
                name: "SistemaUsuario");

            migrationBuilder.DropTable(
                name: "Emprestimo");

            migrationBuilder.DropTable(
                name: "Sistema");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
