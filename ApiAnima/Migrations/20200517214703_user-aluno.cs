using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnima.Migrations
{
    public partial class useraluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Alunos",
                newName: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Alunos",
                newName: "usuarioId");
        }
    }
}
