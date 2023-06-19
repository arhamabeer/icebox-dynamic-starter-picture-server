using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace icebox_dynamic_starter_picture_server.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Images_EventId",
                table: "Machines");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Machines",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_EventId",
                table: "Machines",
                newName: "IX_Machines_ImageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Images",
                newName: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Images_ImageId",
                table: "Machines",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "ImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Images_ImageId",
                table: "Machines");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Machines",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_ImageId",
                table: "Machines",
                newName: "IX_Machines_EventId");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Images",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Images_EventId",
                table: "Machines",
                column: "EventId",
                principalTable: "Images",
                principalColumn: "Id");
        }
    }
}
