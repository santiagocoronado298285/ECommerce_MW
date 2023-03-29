using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce_MW.Migrations
{
    /// <inheritdoc />
    public partial class verificandoBasecontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_states_StateId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_states_Countries_CountryId",
                table: "states");

            migrationBuilder.DropPrimaryKey(
                name: "PK_states",
                table: "states");

            migrationBuilder.RenameTable(
                name: "states",
                newName: "States");

            migrationBuilder.RenameIndex(
                name: "IX_states_Name_CountryId",
                table: "States",
                newName: "IX_States_Name_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_states_CountryId",
                table: "States",
                newName: "IX_States_CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "States",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_States",
                table: "States",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Countries_CountryId",
                table: "States",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_CountryId",
                table: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_States",
                table: "States");

            migrationBuilder.RenameTable(
                name: "States",
                newName: "states");

            migrationBuilder.RenameIndex(
                name: "IX_States_Name_CountryId",
                table: "states",
                newName: "IX_states_Name_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_States_CountryId",
                table: "states",
                newName: "IX_states_CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "states",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_states",
                table: "states",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_states_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "states",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_states_Countries_CountryId",
                table: "states",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
