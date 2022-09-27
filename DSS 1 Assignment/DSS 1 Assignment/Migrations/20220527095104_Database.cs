using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSS_1_Assignment.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Movie",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Genre",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movie",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genre",
                newName: "Year");
        }
    }
}
