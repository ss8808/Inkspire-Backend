using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inksprie_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06f9e5d4-1fb3-48f8-b5f1-50d49f8f4297", "e5e5578c-a168-4013-9ac8-d8068592969e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06f9e5d4-1fb3-48f8-b5f1-50d49f8f4297");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5e5578c-a168-4013-9ac8-d8068592969e");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17bb4fdc-be70-426a-9d2a-56b03be46fe1", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9d7d2194-22cd-4796-ade2-4b7d2cceff04", 0, "a3ec5287-3713-4ca7-8433-9492aeb9b31f", "admin@yourapp.com", true, false, null, "ADMIN@YOURAPP.COM", "ADMIN@YOURAPP.COM", "AQAAAAIAAYagAAAAEE8Bz3WmdLmQ157Sh3giAJJ/qgxuf0H2yMUn+Z3AmI+GCGmD2sivc6eG/9rM9QjWMA==", null, false, "8ec29a84-f082-46a6-a390-dddc0b5dfabd", false, "admin@yourapp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "17bb4fdc-be70-426a-9d2a-56b03be46fe1", "9d7d2194-22cd-4796-ade2-4b7d2cceff04" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17bb4fdc-be70-426a-9d2a-56b03be46fe1", "9d7d2194-22cd-4796-ade2-4b7d2cceff04" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17bb4fdc-be70-426a-9d2a-56b03be46fe1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d7d2194-22cd-4796-ade2-4b7d2cceff04");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06f9e5d4-1fb3-48f8-b5f1-50d49f8f4297", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5e5578c-a168-4013-9ac8-d8068592969e", 0, "60ac4bb3-7ebb-4e8d-9bf6-951c0ac08ded", "admin@yourapp.com", true, false, null, "ADMIN@YOURAPP.COM", "ADMIN@YOURAPP.COM", "AQAAAAIAAYagAAAAEKJVCtdc0wgfwOGQxWFfNzWus9LGZUgJl/mbvx3Q5tFSua2KzcorxdDgTY++hEw2Gg==", null, false, "7fc653ad-d01f-44d2-8b56-b1047849a065", false, "admin@yourapp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "06f9e5d4-1fb3-48f8-b5f1-50d49f8f4297", "e5e5578c-a168-4013-9ac8-d8068592969e" });
        }
    }
}
