using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevPort.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");
        }
    }
}
