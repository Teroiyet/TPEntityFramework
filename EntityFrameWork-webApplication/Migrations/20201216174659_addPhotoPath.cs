using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWork_webApplication.Migrations
{
    public partial class addPhotoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photoPath",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photoPath",
                table: "Employees");
        }
    }
}
