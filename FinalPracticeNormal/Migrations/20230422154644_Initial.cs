using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalPracticeNormal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HopefulResponses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    TommyJohn = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopefulResponses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "HopefulResponses",
                columns: new[] { "ApplicationId", "Age", "FirstName", "LastName", "Major", "Phone", "TommyJohn" },
                values: new object[] { 1, 22, "Ben", "Daley", "Information Systems", "385-867-5309", true });

            migrationBuilder.InsertData(
                table: "HopefulResponses",
                columns: new[] { "ApplicationId", "Age", "FirstName", "LastName", "Major", "Phone", "TommyJohn" },
                values: new object[] { 2, 22, "Jessica", "Daley", "Information Systems", "435-435-4354", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HopefulResponses");
        }
    }
}
