using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Project_Demo.Migrations
{
    public partial class WorkShop_V2 : Migration
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
                name: "ProductID",
                table: "DANHMUC",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DANHMUC_ProductID",
                table: "DANHMUC",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_DANHMUC_SANPHAM_ProductID",
                table: "DANHMUC",
                column: "ProductID",
                principalTable: "SANPHAM",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DANHMUC_SANPHAM_ProductID",
                table: "DANHMUC");

            migrationBuilder.DropIndex(
                name: "IX_DANHMUC_ProductID",
                table: "DANHMUC");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "DANHMUC");

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
