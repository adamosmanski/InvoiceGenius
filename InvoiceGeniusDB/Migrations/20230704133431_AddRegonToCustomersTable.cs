using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceGeniusDB.Migrations
{
    /// <inheritdoc />
    public partial class AddRegonToCustomersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Regon",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Regon",
                table: "Customers");
        }
    }
}
