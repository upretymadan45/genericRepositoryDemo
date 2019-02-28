using Microsoft.EntityFrameworkCore.Migrations;

namespace genericRepoDemo.Data.Migrations
{
    public partial class ImageUrladdedtostudentmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Students");
        }
    }
}
