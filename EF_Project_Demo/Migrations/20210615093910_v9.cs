using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductID",
                table: "CHITIETHOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleID",
                table: "CHITIETHOADON");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductID",
                table: "CHITIETHOADON",
                column: "ProductID",
                principalTable: "SANPHAM",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleID",
                table: "CHITIETHOADON",
                column: "SaleId",
                principalTable: "HOADON",
                principalColumn: "SaleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductID",
                table: "CHITIETHOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleID",
                table: "CHITIETHOADON");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductID",
                table: "CHITIETHOADON",
                column: "ProductID",
                principalTable: "SANPHAM",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleID",
                table: "CHITIETHOADON",
                column: "SaleId",
                principalTable: "HOADON",
                principalColumn: "SaleId");
        }
    }
}
