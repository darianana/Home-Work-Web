using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketsStore.Migrations
{
    public partial class AddPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buckets_Movies_StagingId",
                table: "Buckets");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Theaters_TheaterId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Stagings");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_TheaterId",
                table: "Stagings",
                newName: "IX_Stagings_TheaterId");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Stagings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stagings",
                table: "Stagings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Buckets_Stagings_StagingId",
                table: "Buckets",
                column: "StagingId",
                principalTable: "Stagings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stagings_Theaters_TheaterId",
                table: "Stagings",
                column: "TheaterId",
                principalTable: "Theaters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buckets_Stagings_StagingId",
                table: "Buckets");

            migrationBuilder.DropForeignKey(
                name: "FK_Stagings_Theaters_TheaterId",
                table: "Stagings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stagings",
                table: "Stagings");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Stagings");

            migrationBuilder.RenameTable(
                name: "Stagings",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Stagings_TheaterId",
                table: "Movies",
                newName: "IX_Movies_TheaterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Buckets_Movies_StagingId",
                table: "Buckets",
                column: "StagingId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Theaters_TheaterId",
                table: "Movies",
                column: "TheaterId",
                principalTable: "Theaters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
