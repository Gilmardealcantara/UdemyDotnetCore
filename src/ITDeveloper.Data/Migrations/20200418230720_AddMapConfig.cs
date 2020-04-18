using Microsoft.EntityFrameworkCore.Migrations;

namespace ITDeveloper.Data.Migrations
{
    public partial class AddMapConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_PatientStates_StateId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientStates",
                table: "PatientStates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "PatientStates",
                newName: "TBL_PATIENT_STATE");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "TBL_PATIENT");

            migrationBuilder.RenameColumn(
                name: "RGEmitterOrgan",
                table: "TBL_PATIENT",
                newName: "RgEmitterOrgan");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_StateId",
                table: "TBL_PATIENT",
                newName: "IX_TBL_PATIENT_StateId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TBL_PATIENT_STATE",
                type: "varchar(30)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RgEmitterOrgan",
                table: "TBL_PATIENT",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "TBL_PATIENT",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TBL_PATIENT",
                type: "varchar(80)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TBL_PATIENT",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "TBL_PATIENT",
                type: "varchar(11)",
                fixedLength: true,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_PATIENT_STATE",
                table: "TBL_PATIENT_STATE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_PATIENT",
                table: "TBL_PATIENT",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_PATIENT_TBL_PATIENT_STATE_StateId",
                table: "TBL_PATIENT",
                column: "StateId",
                principalTable: "TBL_PATIENT_STATE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_PATIENT_TBL_PATIENT_STATE_StateId",
                table: "TBL_PATIENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_PATIENT_STATE",
                table: "TBL_PATIENT_STATE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_PATIENT",
                table: "TBL_PATIENT");

            migrationBuilder.RenameTable(
                name: "TBL_PATIENT_STATE",
                newName: "PatientStates");

            migrationBuilder.RenameTable(
                name: "TBL_PATIENT",
                newName: "Patients");

            migrationBuilder.RenameColumn(
                name: "RgEmitterOrgan",
                table: "Patients",
                newName: "RGEmitterOrgan");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_PATIENT_StateId",
                table: "Patients",
                newName: "IX_Patients_StateId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PatientStates",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RGEmitterOrgan",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldFixedLength: true,
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientStates",
                table: "PatientStates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_PatientStates_StateId",
                table: "Patients",
                column: "StateId",
                principalTable: "PatientStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
