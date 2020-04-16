using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITDeveloper.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Murals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
                    Tittle = table.Column<string>(nullable: true),
                    Notification = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Murals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HospitalizationDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    RG = table.Column<string>(nullable: true),
                    RGEmitterOrgan = table.Column<string>(nullable: true),
                    EmissionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Murals");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
