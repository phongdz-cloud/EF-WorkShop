using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "SANPHAM",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "SANPHAM",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_SaleId",
                table: "SANPHAM",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAM_HOADON_SaleId",
                table: "SANPHAM",
                column: "SaleId",
                principalTable: "HOADON",
                principalColumn: "SaleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAM_HOADON_SaleId",
                table: "SANPHAM");

            migrationBuilder.DropIndex(
                name: "IX_SANPHAM_SaleId",
                table: "SANPHAM");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "SANPHAM");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "SANPHAM",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");
        }
    }
}
