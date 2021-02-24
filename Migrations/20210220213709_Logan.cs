using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOnlineBooks.Migrations
{
    public partial class Logan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookNumberOfPages",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookNumberOfPages",
                table: "Books");
        }
    }
}
