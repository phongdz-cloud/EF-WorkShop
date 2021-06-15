using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAM_DANHMUC_CategoryID",
                table: "SANPHAM");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "SANPHAM",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAM_DANHMUC_CategoryID",
                table: "SANPHAM",
                column: "CategoryID",
                principalTable: "DANHMUC",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAM_DANHMUC_CategoryID",
                table: "SANPHAM");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "SANPHAM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAM_DANHMUC_CategoryID",
                table: "SANPHAM",
                column: "CategoryID",
                principalTable: "DANHMUC",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
