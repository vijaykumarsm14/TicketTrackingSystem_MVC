using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TTS_MVC.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EID = table.Column<int>(type: "int", nullable: false),
                    Employee_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
