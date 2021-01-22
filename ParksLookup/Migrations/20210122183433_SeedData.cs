using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "ParkAddress", "ParkName", "ParkPetsAllowed", "ParkStore", "ParkType" },
                values: new object[,]
                {
                    { 1, "55210 238th Avenue East Ashford, WA 98304", "Mount Rainier", false, true, "National" },
                    { 2, "3002 Mount Angeles Road Port Angeles , WA 98362", "Olympic", true, true, "National" },
                    { 3, "810 State Route 20 Sedro-Woolley, WA 98284", "North Cascades", true, true, "National" },
                    { 4, "21588 State Route 207 Leavenworth, WA 98826", "Lake Wenatchee", true, true, "State" },
                    { 5, "2000 N.W. Sammamish Road Issaqua, WA 98027", "Lake Sammamish", false, false, "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
