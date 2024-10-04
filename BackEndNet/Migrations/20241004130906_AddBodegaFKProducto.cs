using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndNet.Migrations
{
    /// <inheritdoc />
    public partial class AddBodegaFKProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                table: "Productos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_BodegaId",
                table: "Productos",
                column: "BodegaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Bodegas_BodegaId",
                table: "Productos",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Bodegas_BodegaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_BodegaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                table: "Productos");

        }
    }
}
