using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace icebox_dynamic_starter_picture_server.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Event",
                table: "Machines");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Machines",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 3,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 4,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 5,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 6,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 7,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 8,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 9,
                column: "EventId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Machines_EventId",
                table: "Machines",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Images_EventId",
                table: "Machines",
                column: "EventId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Images_EventId",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_EventId",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Machines");

            migrationBuilder.AddColumn<string>(
                name: "Event",
                table: "Machines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 3,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 4,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 5,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 6,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 7,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 8,
                column: "Event",
                value: null);

            migrationBuilder.UpdateData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 9,
                column: "Event",
                value: null);
        }
    }
}
