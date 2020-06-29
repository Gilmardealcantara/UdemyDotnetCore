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
                    Tittle = table.Column<string>(type: "varchar(100)", nullable: true),
                    Notification = table.Column<string>(type: "varchar(100)", nullable: true),
                    Author = table.Column<string>(type: "varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Murals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PATIENT_STATE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(type: "varchar(30)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PATIENT_STATE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PATIENT",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StateId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(80)", nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HospitalizationDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    RG = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    RgEmitterOrgan = table.Column<string>(type: "varchar(10)", nullable: true),
                    EmissionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PATIENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_PATIENT_TBL_PATIENT_STATE_StateId",
                        column: x => x.StateId,
                        principalTable: "TBL_PATIENT_STATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PATIENT_StateId",
                table: "TBL_PATIENT",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Murals");

            migrationBuilder.DropTable(
                name: "TBL_PATIENT");

            migrationBuilder.DropTable(
                name: "TBL_PATIENT_STATE");
        }
    }
}
