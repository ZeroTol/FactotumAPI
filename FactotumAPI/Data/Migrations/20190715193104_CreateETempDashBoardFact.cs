using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FactotumAPI.Data.Migrations
{
    public partial class CreateETempDashBoardFact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TempDashboard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FactId = table.Column<Guid>(nullable: false),
                    FactRating = table.Column<int>(nullable: false),
                    FactCreateDate = table.Column<DateTime>(nullable: false),
                    FactLastRateDate = table.Column<DateTime>(nullable: true),
                    FactTitle = table.Column<string>(type: "varchar(255)", nullable: true),
                    FactLink = table.Column<string>(type: "varchar(255)", nullable: true),
                    FactHashTags = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempDashboard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempDashboard");
        }
    }
}
