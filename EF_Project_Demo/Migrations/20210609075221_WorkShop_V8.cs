using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class WorkShop_V8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        name: "FK_HOADON_NHANVIEN_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "NHANVIEN",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_EmployeeId",
                table: "HOADON",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HOADON");
        }
    }
}
