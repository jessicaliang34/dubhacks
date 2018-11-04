using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetNEat.Data.Migrations
{
    public partial class redoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinalOptimalPlans");

            migrationBuilder.DropTable(
                name: "PlansForUserToUpdate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinalOptimalPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    Cuisine = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    PlanName = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalOptimalPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlansForUserToUpdate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AllDates = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Cuisines = table.Column<string>(nullable: true),
                    EndTime = table.Column<string>(nullable: true),
                    PlanName = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansForUserToUpdate", x => x.Id);
                });
        }
    }
}
