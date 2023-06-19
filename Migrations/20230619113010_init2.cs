using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace icebox_dynamic_starter_picture_server.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Machines",
                columns: new[] { "Id", "Event", "Ip", "Location", "Name" },
                values: new object[,]
                {
                    { 1, null, "192.168.0.1", "Miami", "Icebox" },
                    { 2, null, "192.168.0.2", "California", "Icebox" },
                    { 3, null, "192.168.0.3", "Washington", "Icebox" },
                    { 4, null, "192.168.0.4", "Boston", "Icebox" },
                    { 5, null, "192.168.0.5", "St. Jons", "Icebox" },
                    { 6, null, "192.168.0.6", "Florida", "Icebox" },
                    { 7, null, "192.168.0.7", "Audi", "Icebox" },
                    { 8, null, "192.168.0.8", "New Jersey", "Icebox" },
                    { 9, null, "192.168.0.9", "Karachi", "Icebox" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
