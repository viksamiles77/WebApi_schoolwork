using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qinshift.DataAccess.Migrations
{
    public partial class ChangedTheTableNameToMeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Meal",
                table: "Meal");

            migrationBuilder.RenameTable(
                name: "Meal",
                newName: "Meals");

            migrationBuilder.RenameIndex(
                name: "IX_Meal_UserId",
                table: "Meals",
                newName: "IX_Meals_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meals",
                table: "Meals",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Meals",
                table: "Meals");

            migrationBuilder.RenameTable(
                name: "Meals",
                newName: "Meal");

            migrationBuilder.RenameIndex(
                name: "IX_Meals_UserId",
                table: "Meal",
                newName: "IX_Meal_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meal",
                table: "Meal",
                column: "Id");
        }
    }
}
