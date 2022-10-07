using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EinzelaufageB.Migrations
{
    public partial class ModelDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Driver",
                table: "Journeys",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Driver",
                table: "Journeys");
        }
    }
}
