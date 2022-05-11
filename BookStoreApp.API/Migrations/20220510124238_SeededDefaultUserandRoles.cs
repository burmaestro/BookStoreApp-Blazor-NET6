using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47db28dd-4222-46bf-89a3-7fa88f015cc6", "5d64f12d-8706-4a65-b783-9472793fe336", "User", "USER" },
                    { "6fc1519a-694e-48c9-87bc-7d1096f27845", "8dff06de-bd5e-4aa7-87f1-bba8209bf9c3", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c3f3ee3-f90c-4bab-bebf-ee1e255e33b1", 0, "a077479d-ef98-4ca1-92e2-0e0c35bc5334", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAELGpbyWgd0LDWFuTCNqSio1zV+/VcXCYn1sGo0aHO404Ngf2EiHnndOIOA7D3z0paw==", null, false, "97e52df6-7668-4081-b1ae-e4efb92b29a2", false, "user@bookstore.com" },
                    { "78aa4544-cf46-4bac-b886-01fd0ce06685", 0, "2da89214-fcd1-495d-a699-29344ec556f7", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEA62EuVwDA7bbtKdgnds4W+jmBC0wRpexJIDt0P3XBQYu6xsLyNGS1ZKxZHyH8DaYw==", null, false, "0497012d-0874-4a19-9280-cc2a2a2b0f05", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "47db28dd-4222-46bf-89a3-7fa88f015cc6", "2c3f3ee3-f90c-4bab-bebf-ee1e255e33b1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6fc1519a-694e-48c9-87bc-7d1096f27845", "78aa4544-cf46-4bac-b886-01fd0ce06685" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "47db28dd-4222-46bf-89a3-7fa88f015cc6", "2c3f3ee3-f90c-4bab-bebf-ee1e255e33b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fc1519a-694e-48c9-87bc-7d1096f27845", "78aa4544-cf46-4bac-b886-01fd0ce06685" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47db28dd-4222-46bf-89a3-7fa88f015cc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fc1519a-694e-48c9-87bc-7d1096f27845");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c3f3ee3-f90c-4bab-bebf-ee1e255e33b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78aa4544-cf46-4bac-b886-01fd0ce06685");
        }
    }
}
