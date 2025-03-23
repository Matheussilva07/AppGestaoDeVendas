using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoDeVendas.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adding_ProductAmount_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<uint>(
                name: "ProductAmount",
                table: "SoldProducts",
                type: "int unsigned",
                nullable: false,
                defaultValue: 0u);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductAmount",
                table: "SoldProducts");
        }
    }
}
