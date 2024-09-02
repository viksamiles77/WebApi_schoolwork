using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qinshift.EShop.DataAccess.Migrations
{
    public partial class UsersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3450), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3475), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3537), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3559), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3565), new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "ModifiedBy", "ModifiedOn", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3603), "John", "Doe", 1, new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3605), "test123#", "j_doe" },
                    { 2, 1, new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3612), "Bob", "Bobsky", 1, new DateTime(2024, 9, 2, 18, 30, 32, 786, DateTimeKind.Local).AddTicks(3613), "test1234#", "bob_bobksy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2882), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2911), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2912) });
        }
    }
}
