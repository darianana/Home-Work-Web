using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEntity_6_2.Migrations
{
    public partial class ChangeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stagings_Types_St_typeId",
                table: "Stagings");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Stagings");

            migrationBuilder.AlterColumn<int>(
                name: "St_typeId",
                table: "Stagings",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stagings_Types_St_typeId",
                table: "Stagings",
                column: "St_typeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stagings_Types_St_typeId",
                table: "Stagings");

            migrationBuilder.AlterColumn<int>(
                name: "St_typeId",
                table: "Stagings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Stagings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Stagings_Types_St_typeId",
                table: "Stagings",
                column: "St_typeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
