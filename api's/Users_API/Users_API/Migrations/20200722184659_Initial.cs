using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Users_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(maxLength: 36, nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Password = table.Column<string>(maxLength: 64, nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AlternateKey_Email", x => x.Email);
                    table.UniqueConstraint("AlternateKey_UserName", x => x.UserName);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "ImagePath", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("2e9acc0f-3062-42f0-8c2c-14adddd0085b"), "user1@mail.com", "user1", "", "user1", "user", "user1" },
                    { new Guid("5e71d6dd-44a8-49e4-8056-8f45a07f0c31"), "user2@mail.com", "user2", "", "user2", "user", "user2" },
                    { new Guid("90f46479-c368-4b8c-9770-62140ab61b36"), "user3@mail.com", "user3", "", "user3", "user", "user3" },
                    { new Guid("ce81f20c-c4dc-4bd2-b9a1-d0a906564e6d"), "user4@mail.com", "user4", "", "user4", "user", "user4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
