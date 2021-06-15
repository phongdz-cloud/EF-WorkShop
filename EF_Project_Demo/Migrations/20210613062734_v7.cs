using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "CHITIETHOADON");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "HOADON",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "CHITIETHOADON",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "HOADON");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CHITIETHOADON");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "CHITIETHOADON",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
