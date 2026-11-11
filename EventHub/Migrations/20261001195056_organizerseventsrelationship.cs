using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub.Migrations
{
    /// <inheritdoc />
    public partial class organizerseventsrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_OID",
                table: "Events",
                column: "OID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizers_OID",
                table: "Events",
                column: "OID",
                principalTable: "Organizers",
                principalColumn: "OID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizers_OID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_OID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "OID",
                table: "Events");
        }
    }
}
