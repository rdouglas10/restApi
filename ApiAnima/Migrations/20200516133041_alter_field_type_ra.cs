using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnima.Migrations
{
    public partial class alter_field_type_ra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ra",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ra",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
