using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub.Migrations
{
    /// <inheritdoc />
    public partial class selfrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfEID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ConfEID",
                table: "Events",
                column: "ConfEID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Events_ConfEID",
                table: "Events",
                column: "ConfEID",
                principalTable: "Events",
                principalColumn: "EID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Events_ConfEID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ConfEID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ConfEID",
                table: "Events");
        }
    }
}
