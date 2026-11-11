using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub.Migrations
{
    /// <inheritdoc />
    public partial class organizehaveprofilerelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizerId",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_OrganizerId",
                table: "Profiles",
                column: "OrganizerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Organizers_OrganizerId",
                table: "Profiles",
                column: "OrganizerId",
                principalTable: "Organizers",
                principalColumn: "OID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Organizers_OrganizerId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_OrganizerId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "Profiles");
        }
    }
}
