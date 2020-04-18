using Microsoft.EntityFrameworkCore.Migrations;

namespace ITDeveloper.Data.Migrations
{
    public partial class UpdateModeCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_PATIENT_TBL_PATIENT_STATE_StateId",
                table: "TBL_PATIENT");

            migrationBuilder.AlterColumn<string>(
                name: "Tittle",
                table: "Murals",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notification",
                table: "Murals",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Murals",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Murals",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_PATIENT_TBL_PATIENT_STATE_StateId",
                table: "TBL_PATIENT",
                column: "StateId",
                principalTable: "TBL_PATIENT_STATE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_PATIENT_TBL_PATIENT_STATE_StateId",
                table: "TBL_PATIENT");

            migrationBuilder.AlterColumn<string>(
                name: "Tittle",
                table: "Murals",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notification",
                table: "Murals",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Murals",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Murals",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_PATIENT_TBL_PATIENT_STATE_StateId",
                table: "TBL_PATIENT",
                column: "StateId",
                principalTable: "TBL_PATIENT_STATE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
