using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnima.Migrations
{
    public partial class alter_table_aluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ra",
                table: "Alunos",
                newName: "ra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ra",
                table: "Alunos",
                newName: "Ra");
        }
    }
}
