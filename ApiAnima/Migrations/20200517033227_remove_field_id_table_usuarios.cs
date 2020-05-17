using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnima.Migrations
{
    public partial class remove_field_id_table_usuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Usuarios_Usuariocpf",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Usuarios_Usuariocpf",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "Usuariocpf",
                table: "Professores",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usuariocpf",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Usuarios_Usuariocpf",
                table: "Alunos",
                column: "Usuariocpf",
                principalTable: "Usuarios",
                principalColumn: "cpf",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Usuarios_Usuariocpf",
                table: "Professores",
                column: "Usuariocpf",
                principalTable: "Usuarios",
                principalColumn: "cpf",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Usuarios_Usuariocpf",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Usuarios_Usuariocpf",
                table: "Professores");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Usuariocpf",
                table: "Professores",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Usuariocpf",
                table: "Alunos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Usuarios_Usuariocpf",
                table: "Alunos",
                column: "Usuariocpf",
                principalTable: "Usuarios",
                principalColumn: "cpf",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Usuarios_Usuariocpf",
                table: "Professores",
                column: "Usuariocpf",
                principalTable: "Usuarios",
                principalColumn: "cpf",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
