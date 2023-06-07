using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ChangedProcessorColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Processor");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Processor",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Intel® Celeron™ N3050 Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "AMD FX 4300 Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "AMD Athlon Quad-Core APU Athlon 5150");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "AMD FX 8-Core Black Edition FX-8350");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "AMD FX 8-Core Black Edition FX-8370 ");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Intel Core i7-6700K 4GHz Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Intel® Core™ i5-6400 Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Intel Core i7 Extreme Edition 3 GHz Processor");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 216,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 220,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 229,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 249,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 251,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 266,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 290,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 293,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 304,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 305,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 326,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 340,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 351,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 409,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 437,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 449,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 457,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 537,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 541,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 562,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 612,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 613,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 615,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 628,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 632,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 634,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 664,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 696,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 698,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 755,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 767,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 805,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 828,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 834,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 854,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 856,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 861,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 879,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 897,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 923,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 924,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 935,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 940,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 964,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 977,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                column: "Stars",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Processor");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Processor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Intel® Celeron™ N3050 Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "AMD FX 4300 Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "AMD Athlon Quad-Core APU Athlon 5150");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "AMD FX 8-Core Black Edition FX-8350");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "AMD FX 8-Core Black Edition FX-8370 ");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Intel Core i7-6700K 4GHz Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Intel® Core™ i5-6400 Processor");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Intel Core i7 Extreme Edition 3 GHz Processor");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 216,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 220,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 229,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 249,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 251,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 266,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 290,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 293,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 304,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 305,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 326,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 340,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 351,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 409,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 437,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 449,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 457,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 537,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 541,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 562,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 612,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 613,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 615,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 628,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 632,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 634,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 664,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 696,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 698,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 755,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 767,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 805,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 828,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 834,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 854,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 856,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 861,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 879,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 897,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 923,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 924,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 935,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 940,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 964,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 977,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                column: "Stars",
                value: 3);
        }
    }
}
