using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted.AspNetCore.NewDb.Migrations
{
    public partial class AddedUserNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "planName",
                table: "UserPlans",
                newName: "PlanName");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserPlans",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserPlans");

            migrationBuilder.RenameColumn(
                name: "PlanName",
                table: "UserPlans",
                newName: "planName");
        }
    }
}
