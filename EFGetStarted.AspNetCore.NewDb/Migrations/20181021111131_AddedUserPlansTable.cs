using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted.AspNetCore.NewDb.Migrations
{
    public partial class AddedUserPlansTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserPlans",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    planName = table.Column<string>(nullable: true),
                    allDates = table.Column<string>(nullable: true),
                    startTime = table.Column<string>(nullable: true),
                    endTime = table.Column<string>(nullable: true),
                    cuisines = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPlans");
        }
    }
}
