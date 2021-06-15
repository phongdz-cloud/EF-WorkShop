using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee",
                table: "HOADON");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "HOADON",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee",
                table: "HOADON",
                column: "EmployeeId",
                principalTable: "NHANVIEN",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee",
                table: "HOADON");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "HOADON",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee",
                table: "HOADON",
                column: "EmployeeId",
                principalTable: "NHANVIEN",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
