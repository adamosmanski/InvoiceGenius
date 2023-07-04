using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceGeniusDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBaseWithForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CompanyID",
                table: "Invoices",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Company_CompanyID",
                table: "Invoices",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Company_CompanyID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CompanyID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Invoices");
        }
    }
}
