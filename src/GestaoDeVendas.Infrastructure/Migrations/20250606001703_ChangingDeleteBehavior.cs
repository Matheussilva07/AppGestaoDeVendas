using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoDeVendas.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangingDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sales",
                newName: "SaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "Sales",
                newName: "Id");
        }
    }
}
