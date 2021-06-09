using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class WorkShop_V10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHITIETHOADON",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETHOADON", x => new { x.SaleId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_CHITIETHOADON_NHANVIEN_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "NHANVIEN",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CHITIETHOADON_HOADON_SaleId",
                        column: x => x.SaleId,
                        principalTable: "HOADON",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADON_EmployeeId",
                table: "CHITIETHOADON",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHITIETHOADON");
        }
    }
}
