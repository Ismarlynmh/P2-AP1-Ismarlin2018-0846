using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_AP1_Ismarlin2018_0846.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoTareas",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoTarea = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TiempoTarea = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTareas", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "ProyectosDetalle",
                columns: table => new
                {
                    IdDetalle = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProyectoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Requerimientos = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectosDetalle", x => x.IdDetalle);
                    table.ForeignKey(
                        name: "FK_ProyectosDetalle_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TipoTareas",
                columns: new[] { "TipoId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 1, new DateTime(2021, 12, 7, 23, 22, 53, 868, DateTimeKind.Local).AddTicks(8823), 0, "Analisis" });

            migrationBuilder.InsertData(
                table: "TipoTareas",
                columns: new[] { "TipoId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 2, new DateTime(2021, 12, 7, 23, 22, 53, 944, DateTimeKind.Local).AddTicks(2862), 0, "Diseño" });

            migrationBuilder.InsertData(
                table: "TipoTareas",
                columns: new[] { "TipoId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 3, new DateTime(2021, 12, 7, 23, 22, 53, 944, DateTimeKind.Local).AddTicks(3005), 0, "Programacion" });

            migrationBuilder.InsertData(
                table: "TipoTareas",
                columns: new[] { "TipoId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 4, new DateTime(2021, 12, 7, 23, 22, 53, 944, DateTimeKind.Local).AddTicks(3020), 0, "Prueba" });

            migrationBuilder.CreateIndex(
                name: "IX_ProyectosDetalle_ProyectoId",
                table: "ProyectosDetalle",
                column: "ProyectoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProyectosDetalle");

            migrationBuilder.DropTable(
                name: "TipoTareas");

            migrationBuilder.DropTable(
                name: "Proyectos");
        }
    }
}
