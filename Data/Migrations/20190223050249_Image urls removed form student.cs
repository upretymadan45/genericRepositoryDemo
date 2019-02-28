using Microsoft.EntityFrameworkCore.Migrations;

namespace genericRepoDemo.Data.Migrations
{
    public partial class Imageurlsremovedformstudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Students",
                nullable: true);
        }
    }
}
