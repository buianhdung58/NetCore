using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class Add_Column_Movie_Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Movie",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Movie");
        }
    }
}
