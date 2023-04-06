using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class insertTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa", "fechaActualizacion", "fechaCreacion" },
                values: new object[,]
                {
                    { 1, "", "detalle villa", "", 50, "villa real", 5, 200.0, new DateTime(2023, 4, 2, 21, 22, 57, 154, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 4, 2, 21, 22, 57, 154, DateTimeKind.Local).AddTicks(1457) },
                    { 2, "", "detalle villa2", "", 0, "villa real2", 54, 2000.0, new DateTime(2023, 4, 2, 21, 22, 57, 154, DateTimeKind.Local).AddTicks(1462), new DateTime(2023, 4, 2, 21, 22, 57, 154, DateTimeKind.Local).AddTicks(1463) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
