using Microsoft.EntityFrameworkCore.Migrations;

namespace DoItYourSelf_SellItYourSelf.MODEL.Migrations
{
    public partial class ImageChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Posts_PostID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductID",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Images",
                newName: "productID");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Images",
                newName: "postID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ProductID",
                table: "Images",
                newName: "IX_Images_productID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_PostID",
                table: "Images",
                newName: "IX_Images_postID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Posts_postID",
                table: "Images",
                column: "postID",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_productID",
                table: "Images",
                column: "productID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Posts_postID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_productID",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Images",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "postID",
                table: "Images",
                newName: "PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_productID",
                table: "Images",
                newName: "IX_Images_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_postID",
                table: "Images",
                newName: "IX_Images_PostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Posts_PostID",
                table: "Images",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductID",
                table: "Images",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
