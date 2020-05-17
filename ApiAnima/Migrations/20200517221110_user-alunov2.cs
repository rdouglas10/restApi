using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnima.Migrations
{
    public partial class useralunov2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Usuarios_Usuariocpf",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_Usuariocpf",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Usuariocpf",
                table: "Alunos");

            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_cpf",
                table: "Alunos",
                column: "cpf",
                unique: true,
                filter: "[cpf] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Usuarios_cpf",
                table: "Alunos",
                column: "cpf",
                principalTable: "Usuarios",
                principalColumn: "cpf",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Usuarios_cpf",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_cpf",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Usuariocpf",
                table: "Alunos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Usuariocpf",
                table: "Alunos",
                column: "Usuariocpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Usuarios_Usuariocpf",
                table: "Alunos",
                column: "Usuariocpf",
                principalTable: "Usuarios",
                principalColumn: "cpf",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
