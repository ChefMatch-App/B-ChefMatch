using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChefMatchAPI.Migrations
{
    /// <inheritdoc />
    public partial class EditApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e651dbcf-7ba5-4a62-a110-92587f407081");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "identity",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                schema: "identity",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateJoined",
                schema: "identity",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "identity",
                table: "Users",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "identity",
                table: "Users",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "identity",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff8f0601-26b3-422c-9d9e-d07913f65e01", "508144c4-f098-4895-9351-6c17d10f6406", "User", "USER" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ff8f0601-26b3-422c-9d9e-d07913f65e01");

            migrationBuilder.DropColumn(
                name: "Address",
                schema: "identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Bio",
                schema: "identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateJoined",
                schema: "identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "identity",
                table: "Users");

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e651dbcf-7ba5-4a62-a110-92587f407081", "0912c74b-6aae-40ea-9faa-b4b91d3ea530", "User", "USER" });
        }
    }
}
