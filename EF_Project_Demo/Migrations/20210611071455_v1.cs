using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DANHMUC",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DANHMUC", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: false),
                    money = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAM", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_SANPHAM_DANHMUC_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "DANHMUC",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOADON", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "NHANVIEN",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETHOADON",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETHOADON", x => new { x.ProductID, x.SaleId });
                    table.ForeignKey(
                        name: "FK_ProductID",
                        column: x => x.ProductID,
                        principalTable: "SANPHAM",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_SaleID",
                        column: x => x.SaleId,
                        principalTable: "HOADON",
                        principalColumn: "SaleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADON_SaleId",
                table: "CHITIETHOADON",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_EmployeeId",
                table: "HOADON",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_CategoryID",
                table: "SANPHAM",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHITIETHOADON");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "DANHMUC");

            migrationBuilder.DropTable(
                name: "NHANVIEN");
        }
    }
}
