using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalPracticeNormal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MajorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorId);
                });

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
                    TommyJohn = table.Column<bool>(nullable: false),
                    MajorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopefulResponses", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_HopefulResponses_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "MajorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 1, "Information Systems" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 2, "Mechanical Engineering" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 3, "Elementary Education" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 4, "Actuarial Science" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 5, "Neuroscience" });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "MajorId", "MajorName" },
                values: new object[] { 6, "Undeclared" });

            migrationBuilder.InsertData(
                table: "HopefulResponses",
                columns: new[] { "ApplicationId", "Age", "FirstName", "LastName", "MajorId", "Phone", "TommyJohn" },
                values: new object[] { 1, 22, "Ben", "Daley", 1, "385-867-5309", true });

            migrationBuilder.InsertData(
                table: "HopefulResponses",
                columns: new[] { "ApplicationId", "Age", "FirstName", "LastName", "MajorId", "Phone", "TommyJohn" },
                values: new object[] { 2, 22, "Jessica", "Daley", 1, "435-435-4354", false });

            migrationBuilder.InsertData(
                table: "HopefulResponses",
                columns: new[] { "ApplicationId", "Age", "FirstName", "LastName", "MajorId", "Phone", "TommyJohn" },
                values: new object[] { 3, 23, "Collin", "Klomp", 2, "801-801-8018", true });

            migrationBuilder.CreateIndex(
                name: "IX_HopefulResponses_MajorId",
                table: "HopefulResponses",
                column: "MajorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HopefulResponses");

            migrationBuilder.DropTable(
                name: "Majors");
        }
    }
}
