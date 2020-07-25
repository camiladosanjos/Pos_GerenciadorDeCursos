using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cursos.Presentation.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disciplina",
                columns: table => new
                {
                    DisciplinaId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    CargaHoraria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.DisciplinaId);
                });

            migrationBuilder.CreateTable(
                name: "Instituicao",
                columns: table => new
                {
                    InstituicaoId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    EnderecoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicao", x => x.InstituicaoId);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    InstituicaoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                    table.ForeignKey(
                        name: "FK_Departamento_Instituicao_InstituicaoId",
                        column: x => x.InstituicaoId,
                        principalTable: "Instituicao",
                        principalColumn: "InstituicaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<Guid>(nullable: false),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    InstituicaoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_Endereco_Instituicao_InstituicaoId",
                        column: x => x.InstituicaoId,
                        principalTable: "Instituicao",
                        principalColumn: "InstituicaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    CargaHoraria = table.Column<int>(nullable: false),
                    DepartamentoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                    table.ForeignKey(
                        name: "FK_Cursos_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalhamentoCurso",
                columns: table => new
                {
                    CursoDisciplinaId = table.Column<Guid>(nullable: false),
                    DisciplinaCursoId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhamentoCurso", x => new { x.DisciplinaCursoId, x.CursoDisciplinaId });
                    table.ForeignKey(
                        name: "FK_DetalhamentoCurso_Cursos_CursoDisciplinaId",
                        column: x => x.CursoDisciplinaId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalhamentoCurso_Disciplina_DisciplinaCursoId",
                        column: x => x.DisciplinaCursoId,
                        principalTable: "Disciplina",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_DepartamentoId",
                table: "Cursos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_InstituicaoId",
                table: "Departamento",
                column: "InstituicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhamentoCurso_CursoDisciplinaId",
                table: "DetalhamentoCurso",
                column: "CursoDisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_InstituicaoId",
                table: "Endereco",
                column: "InstituicaoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalhamentoCurso");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Disciplina");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Instituicao");
        }
    }
}
