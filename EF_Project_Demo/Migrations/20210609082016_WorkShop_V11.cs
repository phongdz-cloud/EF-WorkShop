using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class WorkShop_V11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETHOADON_NHANVIEN_EmployeeId",
                table: "CHITIETHOADON");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CHITIETHOADON",
                table: "CHITIETHOADON");

            migrationBuilder.DropIndex(
                name: "IX_CHITIETHOADON_EmployeeId",
                table: "CHITIETHOADON");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "CHITIETHOADON");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "CHITIETHOADON",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "CHITIETHOADON",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CHITIETHOADON",
                table: "CHITIETHOADON",
                columns: new[] { "SaleId", "ProductID" });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADON_ProductID",
                table: "CHITIETHOADON",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETHOADON_SANPHAM_ProductID",
                table: "CHITIETHOADON",
                column: "ProductID",
                principalTable: "SANPHAM",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETHOADON_SANPHAM_ProductID",
                table: "CHITIETHOADON");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CHITIETHOADON",
                table: "CHITIETHOADON");

            migrationBuilder.DropIndex(
                name: "IX_CHITIETHOADON_ProductID",
                table: "CHITIETHOADON");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "CHITIETHOADON");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "CHITIETHOADON");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "CHITIETHOADON",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CHITIETHOADON",
                table: "CHITIETHOADON",
                columns: new[] { "SaleId", "EmployeeId" });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADON_EmployeeId",
                table: "CHITIETHOADON",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETHOADON_NHANVIEN_EmployeeId",
                table: "CHITIETHOADON",
                column: "EmployeeId",
                principalTable: "NHANVIEN",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
