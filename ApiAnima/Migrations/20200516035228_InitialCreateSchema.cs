using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnima.Migrations
{
    public partial class InitialCreateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    codGrade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    curso = table.Column<string>(nullable: true),
                    disciplina = table.Column<string>(nullable: true),
                    turma = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.codGrade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    cpf = table.Column<string>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    login = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.cpf);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ra = table.Column<string>(nullable: true),
                    usuarioId = table.Column<int>(nullable: false),
                    Usuariocpf = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Usuarios_Usuariocpf",
                        column: x => x.Usuariocpf,
                        principalTable: "Usuarios",
                        principalColumn: "cpf",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(nullable: true),
                    usuarioId = table.Column<int>(nullable: false),
                    Usuariocpf = table.Column<string>(nullable: false),
                    GradecodGrade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Professores_Grades_GradecodGrade",
                        column: x => x.GradecodGrade,
                        principalTable: "Grades",
                        principalColumn: "codGrade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Professores_Usuarios_Usuariocpf",
                        column: x => x.Usuariocpf,
                        principalTable: "Usuarios",
                        principalColumn: "cpf",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    GradeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => new { x.AlunoId, x.GradeId });
                    table.ForeignKey(
                        name: "FK_Matriculas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "codGrade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Usuariocpf",
                table: "Alunos",
                column: "Usuariocpf");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_GradeId",
                table: "Matriculas",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_GradecodGrade",
                table: "Professores",
                column: "GradecodGrade");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_Usuariocpf",
                table: "Professores",
                column: "Usuariocpf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
