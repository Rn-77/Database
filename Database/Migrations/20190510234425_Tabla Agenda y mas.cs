using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class TablaAgendaymas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Usuarios_ProfesorId",
                table: "Cursos");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.RenameColumn(
                name: "ProfesorId",
                table: "Cursos",
                newName: "DocentesId");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_ProfesorId",
                table: "Cursos",
                newName: "IX_Cursos_DocentesId");

            migrationBuilder.AddColumn<string>(
                name: "Situacion",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoAula",
                table: "Salas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaEvento = table.Column<DateTime>(nullable: false),
                    TituloEvento = table.Column<string>(nullable: true),
                    DetalleEvento = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    AlumnoId = table.Column<string>(nullable: true),
                    TipoCalificacion = table.Column<int>(nullable: false),
                    Calificacion = table.Column<decimal>(nullable: false),
                    CursoId = table.Column<int>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Usuarios_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_UsuarioId",
                table: "Agendas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_AlumnoId",
                table: "Calificaciones",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_CursoId",
                table: "Calificaciones",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Usuarios_DocentesId",
                table: "Cursos",
                column: "DocentesId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Usuarios_DocentesId",
                table: "Cursos");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "Situacion",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CodigoAula",
                table: "Salas");

            migrationBuilder.RenameColumn(
                name: "DocentesId",
                table: "Cursos",
                newName: "ProfesorId");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_DocentesId",
                table: "Cursos",
                newName: "IX_Cursos_ProfesorId");

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<string>(nullable: true),
                    Calificacion = table.Column<decimal>(nullable: false),
                    CursoId = table.Column<int>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Usuarios_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlumnoId",
                table: "Notas",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_CursoId",
                table: "Notas",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Usuarios_ProfesorId",
                table: "Cursos",
                column: "ProfesorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
