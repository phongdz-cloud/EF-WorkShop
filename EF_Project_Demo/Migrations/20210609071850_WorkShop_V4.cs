using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class WorkShop_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DANHMUC_SANPHAM_FK_Category",
                table: "DANHMUC");

            migrationBuilder.DropIndex(
                name: "IX_DANHMUC_FK_Category",
                table: "DANHMUC");

            migrationBuilder.DropColumn(
                name: "FK_Category",
                table: "DANHMUC");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "SANPHAM",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_CategoryID",
                table: "SANPHAM",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAM_DANHMUC_CategoryID",
                table: "SANPHAM",
                column: "CategoryID",
                principalTable: "DANHMUC",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAM_DANHMUC_CategoryID",
                table: "SANPHAM");

            migrationBuilder.DropIndex(
                name: "IX_SANPHAM_CategoryID",
                table: "SANPHAM");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "SANPHAM");

            migrationBuilder.AddColumn<int>(
                name: "FK_Category",
                table: "DANHMUC",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DANHMUC_FK_Category",
                table: "DANHMUC",
                column: "FK_Category");

            migrationBuilder.AddForeignKey(
                name: "FK_DANHMUC_SANPHAM_FK_Category",
                table: "DANHMUC",
                column: "FK_Category",
                principalTable: "SANPHAM",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
