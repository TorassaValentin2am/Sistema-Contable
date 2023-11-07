using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concepto",
                columns: table => new
                {
                    ConceptoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concepto", x => x.ConceptoId);
                });

            migrationBuilder.CreateTable(
                name: "LibroContable",
                columns: table => new
                {
                    LibroContableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    CapitalActual = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroContable", x => x.LibroContableId);
                });

            migrationBuilder.CreateTable(
                name: "AsientoContable",
                columns: table => new
                {
                    AsientoContableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    ConceptoId = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<long>(type: "bigint", nullable: false),
                    LibroContableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientoContable", x => x.AsientoContableId);
                    table.ForeignKey(
                        name: "FK_AsientoContable_Concepto_ConceptoId",
                        column: x => x.ConceptoId,
                        principalTable: "Concepto",
                        principalColumn: "ConceptoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsientoContable_LibroContable_LibroContableId",
                        column: x => x.LibroContableId,
                        principalTable: "LibroContable",
                        principalColumn: "LibroContableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsientoContable_Codigo",
                table: "AsientoContable",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AsientoContable_ConceptoId",
                table: "AsientoContable",
                column: "ConceptoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsientoContable_LibroContableId",
                table: "AsientoContable",
                column: "LibroContableId");

            migrationBuilder.CreateIndex(
                name: "IX_Concepto_Codigo",
                table: "Concepto",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibroContable_Codigo",
                table: "LibroContable",
                column: "Codigo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsientoContable");

            migrationBuilder.DropTable(
                name: "Concepto");

            migrationBuilder.DropTable(
                name: "LibroContable");
        }
    }
}
