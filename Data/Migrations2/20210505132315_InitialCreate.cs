using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraphicsCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicsCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardDrive",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<short>(nullable: false),
                    StorageUnit = table.Column<int>(nullable: false),
                    HardDriveType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDrive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardDriveType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDriveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Release = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    DurationInMinutes = table.Column<int>(nullable: true),
                    WorldwideBoxOfficeGross = table.Column<double>(nullable: true),
                    NumberOfEpisodes = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<short>(nullable: false),
                    Unit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StorageUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsbType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsbType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeightUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Productions_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionId = table.Column<int>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    Stars = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Productions_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RamId = table.Column<int>(nullable: false),
                    HardDriveId = table.Column<int>(nullable: false),
                    GraphicsCardId = table.Column<int>(nullable: false),
                    WeightQuantity = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    WeightUnitId = table.Column<int>(nullable: false),
                    Psu = table.Column<short>(nullable: false),
                    ProcessorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computer_GraphicsCard_GraphicsCardId",
                        column: x => x.GraphicsCardId,
                        principalTable: "GraphicsCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_HardDrive_HardDriveId",
                        column: x => x.HardDriveId,
                        principalTable: "HardDrive",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_Processor_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "Processor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_Ram_RamId",
                        column: x => x.RamId,
                        principalTable: "Ram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_WeightUnit_WeightUnitId",
                        column: x => x.WeightUnitId,
                        principalTable: "WeightUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsbQuantity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerId = table.Column<int>(nullable: false),
                    UsbType = table.Column<int>(nullable: false),
                    Quantity = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsbQuantity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsbQuantity_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Robert Downey Jr." },
                    { 18, "Melissa McBride" },
                    { 17, "Norman Reedus" },
                    { 16, "Hazuki Shimizu" },
                    { 15, "Matsuya Onoe" },
                    { 13, "Winona Ryder" },
                    { 12, "Caleb McLaughlin" },
                    { 11, "Millie Bobby Brown" },
                    { 10, "Karyn Parsons" },
                    { 14, "David Harbour" },
                    { 8, "Maggie Smith" },
                    { 7, "Will Smith" },
                    { 6, "Donny Yen" },
                    { 5, "Beyoncé" },
                    { 4, "Donald Glover" },
                    { 3, "Danai Guira" },
                    { 2, "Chris Evans" },
                    { 9, "Michelle Dockery" }
                });

            migrationBuilder.InsertData(
                table: "GraphicsCard",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "AMD FirePro W4100" },
                    { 6, "Radeon R9 380" },
                    { 5, "Radeon RX 480" },
                    { 1, "NVIDIA GeForce GTX 770" },
                    { 3, "Radeon R7360" },
                    { 2, "NVIDIA GeForce GTX 960" },
                    { 4, "NVIDIA GeForce GTX 1080" }
                });

            migrationBuilder.InsertData(
                table: "HardDrive",
                columns: new[] { "Id", "HardDriveType", "Size", "StorageUnit" },
                values: new object[,]
                {
                    { 6, 2, (short)750, 2 },
                    { 7, 2, (short)1, 3 },
                    { 5, 2, (short)500, 2 },
                    { 8, 2, (short)2, 3 },
                    { 3, 1, (short)4, 3 },
                    { 2, 1, (short)3, 3 },
                    { 1, 1, (short)2, 3 },
                    { 4, 2, (short)80, 2 }
                });

            migrationBuilder.InsertData(
                table: "HardDriveType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "HDD" },
                    { 2, "SDD" }
                });

            migrationBuilder.InsertData(
                table: "Processor",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 7, "Intel® Core™ i5-6400 Processor" },
                    { 6, "Intel Core i7-6700K 4GHz Processor" },
                    { 5, "AMD FX 8-Core Black Edition FX-8370 " },
                    { 4, "AMD FX 8-Core Black Edition FX-8350" },
                    { 3, "AMD Athlon Quad-Core APU Athlon 5150" },
                    { 2, "AMD FX 4300 Processor" },
                    { 8, "Intel Core i7 Extreme Edition 3 GHz Processor" },
                    { 1, "Intel® Celeron™ N3050 Processor" }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Discriminator", "Name", "Release", "DurationInMinutes", "WorldwideBoxOfficeGross" },
                values: new object[] { 5, "Movie", "Downton Abbey", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 194051302.0 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Discriminator", "Name", "Release", "NumberOfEpisodes" },
                values: new object[,]
                {
                    { 10, "Series", "The Walking Dead", new DateTime(2010, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 177 },
                    { 9, "Series", "Kantaro: The Sweet Tooth Salaryman", new DateTime(2017, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 8, "Series", "Stranger Things", new DateTime(2016, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 7, "Series", "Downton Abbey", new DateTime(2010, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 52 },
                    { 6, "Series", "The Fresh Prince of Bel-Air", new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 148 }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Discriminator", "Name", "Release", "DurationInMinutes", "WorldwideBoxOfficeGross" },
                values: new object[,]
                {
                    { 4, "Movie", "Gemini Man", new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 116, 166623705.0 },
                    { 3, "Movie", "Ip Man 4", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, 192617891.0 },
                    { 2, "Movie", "The Lion King", new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 118, 1654791102.0 },
                    { 1, "Movie", "Avengers: Endgame", new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 181, 2797800564.0 }
                });

            migrationBuilder.InsertData(
                table: "Ram",
                columns: new[] { "Id", "Size", "Unit" },
                values: new object[,]
                {
                    { 1, (short)2, 2 },
                    { 2, (short)8, 2 },
                    { 5, (short)512, 1 },
                    { 4, (short)32, 2 },
                    { 3, (short)16, 2 }
                });

            migrationBuilder.InsertData(
                table: "StorageUnit",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "MB" },
                    { 2, "GB" },
                    { 3, "TB" }
                });

            migrationBuilder.InsertData(
                table: "UsbType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "USB-2" },
                    { 2, "USB-3" },
                    { 3, "USB-C" }
                });

            migrationBuilder.InsertData(
                table: "WeightUnit",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "LB" },
                    { 2, "KG" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ActorId", "Name", "ProductionId" },
                values: new object[,]
                {
                    { 1, 1, "Tony Stark", 1 },
                    { 6, 6, "Ip Man", 3 },
                    { 7, 7, "Henry Brogan", 4 },
                    { 8, 8, "Violet Crawley", 5 },
                    { 9, 9, "Lady Mary Crawley", 5 },
                    { 10, 7, "Will Smith", 6 },
                    { 11, 10, "Hilary Banks", 6 },
                    { 12, 8, "Violet Crawley", 7 },
                    { 13, 9, "Lady Mary Crawley", 7 },
                    { 14, 11, "Eleven", 8 },
                    { 15, 12, "Lucas", 8 },
                    { 16, 13, "Joyce Byers", 8 },
                    { 17, 14, "Jim Hopper", 8 },
                    { 5, 5, "Nala", 2 },
                    { 18, 15, "Ametani Kantarou", 9 },
                    { 20, 17, "Daryl Dixon", 10 },
                    { 21, 3, "Michonne", 10 },
                    { 22, 18, "Carol Peletier", 10 },
                    { 3, 3, "Okoye", 1 },
                    { 2, 2, "Steve Rogers", 1 },
                    { 19, 16, "Sano Erika", 9 },
                    { 4, 4, "Simba", 2 }
                });

            migrationBuilder.InsertData(
                table: "Computer",
                columns: new[] { "Id", "GraphicsCardId", "HardDriveId", "ProcessorId", "Psu", "RamId", "WeightQuantity", "WeightUnitId" },
                values: new object[,]
                {
                    { 3, 3, 2, 3, (short)450, 2, 16m, 1 },
                    { 4, 4, 3, 4, (short)500, 3, 13.8m, 1 },
                    { 7, 4, 1, 7, (short)1000, 2, 15m, 1 },
                    { 8, 1, 5, 7, (short)750, 3, 8m, 1 },
                    { 6, 6, 8, 6, (short)450, 4, 6m, 2 },
                    { 10, 5, 4, 7, (short)700, 5, 22m, 1 },
                    { 1, 1, 7, 1, (short)500, 2, 8.1m, 2 },
                    { 2, 2, 1, 2, (short)500, 3, 12m, 2 },
                    { 5, 5, 6, 5, (short)1000, 4, 7m, 2 },
                    { 9, 7, 1, 8, (short)508, 1, 9m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductionId", "Source", "Stars" },
                values: new object[,]
                {
                    { 30, 1, "Magazine", 3 },
                    { 678, 7, "Newspaper", 2 },
                    { 679, 7, "Newspaper", 5 },
                    { 680, 7, "Magazine", 3 },
                    { 681, 7, "App", 2 },
                    { 682, 7, "App", 5 },
                    { 683, 7, "Newspaper", 3 },
                    { 684, 7, "App", 1 },
                    { 685, 7, "App", 2 },
                    { 686, 7, "Newspaper", 1 },
                    { 687, 7, "Magazine", 2 },
                    { 688, 7, "Magazine", 1 },
                    { 689, 7, "Magazine", 4 },
                    { 677, 7, "Internet", 2 },
                    { 690, 7, "Internet", 5 },
                    { 692, 7, "Magazine", 2 },
                    { 693, 7, "Internet", 5 },
                    { 694, 7, "Magazine", 2 },
                    { 695, 7, "Magazine", 3 },
                    { 696, 7, "Magazine", 3 },
                    { 697, 7, "App", 4 },
                    { 698, 7, "Newspaper", 1 },
                    { 699, 7, "Internet", 1 },
                    { 17, 1, "Internet", 2 },
                    { 16, 1, "Internet", 2 },
                    { 15, 1, "Internet", 2 },
                    { 14, 1, "Magazine", 5 },
                    { 691, 7, "Newspaper", 4 },
                    { 676, 7, "Magazine", 1 },
                    { 675, 7, "App", 1 },
                    { 674, 7, "Internet", 3 },
                    { 647, 7, "Newspaper", 3 },
                    { 648, 7, "App", 1 },
                    { 649, 7, "Newspaper", 3 },
                    { 650, 7, "App", 4 },
                    { 651, 7, "App", 2 },
                    { 652, 7, "Newspaper", 5 },
                    { 653, 7, "App", 4 },
                    { 654, 7, "Newspaper", 2 },
                    { 655, 7, "Internet", 5 },
                    { 656, 7, "App", 1 },
                    { 657, 7, "Newspaper", 4 },
                    { 658, 7, "Internet", 2 },
                    { 659, 7, "App", 5 },
                    { 660, 7, "Newspaper", 1 },
                    { 661, 7, "App", 3 },
                    { 662, 7, "Magazine", 1 },
                    { 663, 7, "Internet", 4 },
                    { 664, 7, "Newspaper", 3 },
                    { 665, 7, "App", 3 },
                    { 666, 7, "Magazine", 4 },
                    { 667, 7, "App", 4 },
                    { 668, 7, "Newspaper", 5 },
                    { 669, 7, "Newspaper", 5 },
                    { 670, 7, "Newspaper", 3 },
                    { 671, 7, "App", 2 },
                    { 672, 7, "Newspaper", 2 },
                    { 673, 7, "Magazine", 4 },
                    { 701, 8, "Newspaper", 5 },
                    { 702, 8, "Magazine", 3 },
                    { 703, 8, "Internet", 5 },
                    { 704, 8, "Magazine", 4 },
                    { 736, 8, "Internet", 4 },
                    { 737, 8, "Newspaper", 4 },
                    { 738, 8, "App", 1 },
                    { 739, 8, "Newspaper", 3 },
                    { 740, 8, "Newspaper", 5 },
                    { 741, 8, "Internet", 4 },
                    { 742, 8, "Internet", 4 },
                    { 743, 8, "Newspaper", 4 },
                    { 744, 8, "Magazine", 5 },
                    { 745, 8, "Newspaper", 3 },
                    { 746, 8, "Magazine", 1 },
                    { 747, 8, "Internet", 3 },
                    { 748, 8, "Internet", 2 },
                    { 749, 8, "Internet", 2 },
                    { 750, 8, "Internet", 3 },
                    { 751, 8, "App", 4 },
                    { 752, 8, "App", 5 },
                    { 753, 8, "Magazine", 4 },
                    { 754, 8, "Newspaper", 3 },
                    { 755, 8, "Internet", 4 },
                    { 756, 8, "Internet", 1 },
                    { 757, 8, "Internet", 1 },
                    { 758, 8, "Magazine", 2 },
                    { 759, 8, "Magazine", 3 },
                    { 760, 8, "App", 2 },
                    { 761, 8, "Magazine", 2 },
                    { 762, 8, "Internet", 3 },
                    { 735, 8, "Internet", 3 },
                    { 646, 7, "Internet", 2 },
                    { 734, 8, "Internet", 2 },
                    { 732, 8, "App", 5 },
                    { 705, 8, "Magazine", 2 },
                    { 706, 8, "Magazine", 1 },
                    { 707, 8, "Internet", 4 },
                    { 708, 8, "Newspaper", 3 },
                    { 709, 8, "Internet", 1 },
                    { 710, 8, "Internet", 3 },
                    { 711, 8, "Newspaper", 1 },
                    { 712, 8, "Newspaper", 5 },
                    { 713, 8, "App", 1 },
                    { 714, 8, "Magazine", 3 },
                    { 715, 8, "Newspaper", 4 },
                    { 716, 8, "App", 3 },
                    { 717, 8, "Magazine", 3 },
                    { 718, 8, "Newspaper", 4 },
                    { 719, 8, "App", 4 },
                    { 720, 8, "Internet", 2 },
                    { 721, 8, "Newspaper", 1 },
                    { 722, 8, "Magazine", 5 },
                    { 723, 8, "App", 3 },
                    { 724, 8, "Internet", 5 },
                    { 725, 8, "Newspaper", 1 },
                    { 726, 8, "Internet", 4 },
                    { 727, 8, "App", 5 },
                    { 728, 8, "Magazine", 1 },
                    { 729, 8, "Internet", 2 },
                    { 730, 8, "Internet", 3 },
                    { 731, 8, "Internet", 4 },
                    { 733, 8, "Newspaper", 2 },
                    { 645, 7, "App", 4 },
                    { 644, 7, "Internet", 2 },
                    { 643, 7, "Newspaper", 2 },
                    { 555, 6, "Internet", 2 },
                    { 556, 6, "Newspaper", 1 },
                    { 557, 6, "Internet", 4 },
                    { 558, 6, "Internet", 5 },
                    { 559, 6, "Magazine", 3 },
                    { 560, 6, "Magazine", 4 },
                    { 561, 6, "Magazine", 2 },
                    { 562, 6, "Magazine", 1 },
                    { 563, 6, "Internet", 3 },
                    { 564, 6, "Newspaper", 5 },
                    { 565, 6, "Newspaper", 4 },
                    { 566, 6, "Newspaper", 4 },
                    { 567, 6, "App", 3 },
                    { 568, 6, "App", 2 },
                    { 569, 6, "App", 4 },
                    { 570, 6, "App", 5 },
                    { 571, 6, "Internet", 5 },
                    { 572, 6, "Newspaper", 2 },
                    { 573, 6, "Magazine", 1 },
                    { 574, 6, "App", 5 },
                    { 575, 6, "Newspaper", 4 },
                    { 576, 6, "App", 1 },
                    { 577, 6, "App", 2 },
                    { 578, 6, "Internet", 5 },
                    { 579, 6, "Newspaper", 1 },
                    { 580, 6, "Internet", 3 },
                    { 581, 6, "Newspaper", 2 },
                    { 554, 6, "Internet", 3 },
                    { 582, 6, "Internet", 2 },
                    { 553, 6, "Internet", 1 },
                    { 551, 6, "Internet", 4 },
                    { 524, 6, "Internet", 4 },
                    { 525, 6, "Magazine", 4 },
                    { 526, 6, "Magazine", 1 },
                    { 527, 6, "Newspaper", 1 },
                    { 528, 6, "Newspaper", 2 },
                    { 529, 6, "App", 2 },
                    { 530, 6, "App", 1 },
                    { 531, 6, "Magazine", 5 },
                    { 532, 6, "Magazine", 4 },
                    { 533, 6, "Newspaper", 5 },
                    { 534, 6, "Magazine", 3 },
                    { 535, 6, "Magazine", 5 },
                    { 536, 6, "App", 3 },
                    { 537, 6, "Internet", 5 },
                    { 538, 6, "Internet", 1 },
                    { 539, 6, "App", 2 },
                    { 540, 6, "App", 2 },
                    { 541, 6, "App", 5 },
                    { 542, 6, "Internet", 5 },
                    { 543, 6, "Newspaper", 5 },
                    { 544, 6, "Magazine", 1 },
                    { 545, 6, "Internet", 3 },
                    { 546, 6, "Newspaper", 1 },
                    { 547, 6, "Magazine", 1 },
                    { 548, 6, "Magazine", 3 },
                    { 549, 6, "Internet", 3 },
                    { 550, 6, "Newspaper", 2 },
                    { 552, 6, "Internet", 1 },
                    { 763, 8, "Internet", 1 },
                    { 583, 6, "App", 3 },
                    { 585, 6, "Internet", 5 },
                    { 616, 7, "Internet", 3 },
                    { 617, 7, "Internet", 4 },
                    { 618, 7, "Magazine", 5 },
                    { 619, 7, "Internet", 2 },
                    { 620, 7, "Internet", 4 },
                    { 621, 7, "Magazine", 3 },
                    { 622, 7, "Magazine", 4 },
                    { 623, 7, "Newspaper", 4 },
                    { 624, 7, "Newspaper", 3 },
                    { 625, 7, "App", 3 },
                    { 626, 7, "App", 4 },
                    { 627, 7, "Magazine", 5 },
                    { 628, 7, "Internet", 3 },
                    { 629, 7, "Newspaper", 2 },
                    { 630, 7, "Newspaper", 3 },
                    { 631, 7, "Magazine", 1 },
                    { 632, 7, "Newspaper", 2 },
                    { 633, 7, "App", 5 },
                    { 634, 7, "Magazine", 1 },
                    { 635, 7, "Internet", 3 },
                    { 636, 7, "App", 1 },
                    { 637, 7, "Magazine", 4 },
                    { 638, 7, "Internet", 4 },
                    { 639, 7, "Newspaper", 1 },
                    { 640, 7, "Newspaper", 4 },
                    { 641, 7, "App", 1 },
                    { 642, 7, "Newspaper", 4 },
                    { 615, 7, "App", 2 },
                    { 584, 6, "Magazine", 5 },
                    { 614, 7, "Newspaper", 2 },
                    { 612, 7, "Newspaper", 5 },
                    { 586, 6, "Magazine", 3 },
                    { 587, 6, "App", 4 },
                    { 588, 6, "Newspaper", 4 },
                    { 589, 6, "Magazine", 2 },
                    { 590, 6, "App", 4 },
                    { 591, 6, "App", 1 },
                    { 592, 6, "Newspaper", 4 },
                    { 593, 6, "App", 1 },
                    { 594, 6, "Magazine", 5 },
                    { 595, 6, "Internet", 1 },
                    { 596, 6, "Internet", 4 },
                    { 597, 6, "Magazine", 3 },
                    { 598, 6, "Magazine", 3 },
                    { 599, 6, "Newspaper", 4 },
                    { 19, 1, "Magazine", 1 },
                    { 18, 1, "Internet", 1 },
                    { 601, 7, "Internet", 4 },
                    { 602, 7, "Internet", 4 },
                    { 603, 7, "Magazine", 1 },
                    { 604, 7, "Newspaper", 5 },
                    { 605, 7, "Newspaper", 2 },
                    { 606, 7, "Magazine", 1 },
                    { 607, 7, "Newspaper", 4 },
                    { 608, 7, "Magazine", 4 },
                    { 609, 7, "Newspaper", 5 },
                    { 610, 7, "Internet", 4 },
                    { 611, 7, "Magazine", 5 },
                    { 613, 7, "Magazine", 4 },
                    { 764, 8, "Newspaper", 4 },
                    { 765, 8, "Internet", 1 },
                    { 766, 8, "Newspaper", 3 },
                    { 919, 10, "Magazine", 4 },
                    { 920, 10, "Internet", 1 },
                    { 921, 10, "Magazine", 4 },
                    { 922, 10, "App", 5 },
                    { 923, 10, "Internet", 5 },
                    { 924, 10, "App", 5 },
                    { 925, 10, "Magazine", 2 },
                    { 926, 10, "Newspaper", 5 },
                    { 927, 10, "Magazine", 5 },
                    { 928, 10, "App", 1 },
                    { 929, 10, "Magazine", 2 },
                    { 930, 10, "Newspaper", 1 },
                    { 931, 10, "Newspaper", 1 },
                    { 932, 10, "Internet", 3 },
                    { 933, 10, "Internet", 3 },
                    { 934, 10, "Newspaper", 1 },
                    { 935, 10, "App", 5 },
                    { 936, 10, "Newspaper", 1 },
                    { 937, 10, "Internet", 1 },
                    { 938, 10, "Newspaper", 3 },
                    { 939, 10, "Internet", 1 },
                    { 940, 10, "Magazine", 1 },
                    { 941, 10, "Internet", 5 },
                    { 942, 10, "Internet", 3 },
                    { 943, 10, "Newspaper", 3 },
                    { 944, 10, "Magazine", 3 },
                    { 945, 10, "Newspaper", 1 },
                    { 918, 10, "Internet", 2 },
                    { 946, 10, "Internet", 4 },
                    { 917, 10, "Newspaper", 2 },
                    { 915, 10, "Newspaper", 4 },
                    { 890, 9, "Newspaper", 3 },
                    { 891, 9, "Newspaper", 4 },
                    { 892, 9, "App", 1 },
                    { 893, 9, "Newspaper", 5 },
                    { 894, 9, "Newspaper", 1 },
                    { 895, 9, "Magazine", 4 },
                    { 896, 9, "Internet", 5 },
                    { 897, 9, "App", 3 },
                    { 898, 9, "Internet", 4 },
                    { 899, 9, "Newspaper", 4 },
                    { 11, 1, "Magazine", 3 },
                    { 10, 1, "Internet", 5 },
                    { 9, 1, "Internet", 5 },
                    { 901, 10, "Magazine", 5 },
                    { 902, 10, "App", 4 },
                    { 903, 10, "App", 1 },
                    { 904, 10, "Newspaper", 2 },
                    { 905, 10, "Internet", 3 },
                    { 906, 10, "Newspaper", 2 },
                    { 907, 10, "Internet", 4 },
                    { 908, 10, "App", 5 },
                    { 909, 10, "Newspaper", 1 },
                    { 910, 10, "Internet", 2 },
                    { 911, 10, "App", 1 },
                    { 912, 10, "Internet", 1 },
                    { 913, 10, "Magazine", 5 },
                    { 914, 10, "App", 5 },
                    { 916, 10, "Newspaper", 4 },
                    { 889, 9, "Internet", 3 },
                    { 947, 10, "App", 4 },
                    { 949, 10, "Magazine", 1 },
                    { 981, 10, "App", 5 },
                    { 982, 10, "App", 3 },
                    { 983, 10, "Newspaper", 3 },
                    { 984, 10, "Internet", 3 },
                    { 985, 10, "Internet", 5 },
                    { 986, 10, "App", 3 },
                    { 987, 10, "App", 1 },
                    { 988, 10, "Magazine", 1 },
                    { 989, 10, "Internet", 4 },
                    { 990, 10, "Magazine", 2 },
                    { 991, 10, "Newspaper", 5 },
                    { 992, 10, "Internet", 1 },
                    { 993, 10, "Magazine", 5 },
                    { 994, 10, "Newspaper", 3 },
                    { 995, 10, "App", 5 },
                    { 996, 10, "Newspaper", 3 },
                    { 997, 10, "App", 4 },
                    { 998, 10, "Internet", 1 },
                    { 999, 10, "Magazine", 3 },
                    { 8, 1, "App", 1 },
                    { 7, 1, "App", 2 },
                    { 6, 1, "Newspaper", 4 },
                    { 5, 1, "Internet", 1 },
                    { 4, 1, "Magazine", 4 },
                    { 3, 1, "Magazine", 2 },
                    { 2, 1, "App", 2 },
                    { 1, 1, "Internet", 3 },
                    { 980, 10, "Magazine", 2 },
                    { 948, 10, "Internet", 1 },
                    { 979, 10, "Internet", 1 },
                    { 977, 10, "Newspaper", 5 },
                    { 950, 10, "App", 3 },
                    { 951, 10, "Newspaper", 1 },
                    { 952, 10, "Newspaper", 4 },
                    { 953, 10, "Newspaper", 3 },
                    { 954, 10, "Magazine", 2 },
                    { 955, 10, "App", 1 },
                    { 956, 10, "Internet", 5 },
                    { 957, 10, "Newspaper", 2 },
                    { 958, 10, "App", 3 },
                    { 959, 10, "Magazine", 5 },
                    { 960, 10, "Internet", 4 },
                    { 961, 10, "Newspaper", 3 },
                    { 962, 10, "Magazine", 2 },
                    { 963, 10, "App", 1 },
                    { 964, 10, "Newspaper", 4 },
                    { 965, 10, "Internet", 1 },
                    { 966, 10, "Newspaper", 2 },
                    { 967, 10, "Internet", 4 },
                    { 968, 10, "Magazine", 3 },
                    { 969, 10, "Internet", 2 },
                    { 970, 10, "App", 3 },
                    { 971, 10, "App", 1 },
                    { 972, 10, "Newspaper", 3 },
                    { 973, 10, "Magazine", 2 },
                    { 974, 10, "Newspaper", 5 },
                    { 975, 10, "Internet", 2 },
                    { 976, 10, "Magazine", 2 },
                    { 978, 10, "App", 2 },
                    { 523, 6, "Internet", 4 },
                    { 888, 9, "Internet", 3 },
                    { 886, 9, "Internet", 5 },
                    { 798, 8, "App", 1 },
                    { 799, 8, "Internet", 1 },
                    { 13, 1, "Magazine", 3 },
                    { 12, 1, "Internet", 5 },
                    { 801, 9, "Magazine", 3 },
                    { 802, 9, "App", 5 },
                    { 803, 9, "Newspaper", 4 },
                    { 804, 9, "App", 4 },
                    { 805, 9, "Magazine", 2 },
                    { 806, 9, "Internet", 2 },
                    { 807, 9, "Internet", 5 },
                    { 808, 9, "Magazine", 4 },
                    { 809, 9, "Newspaper", 1 },
                    { 810, 9, "Internet", 3 },
                    { 811, 9, "App", 1 },
                    { 812, 9, "Magazine", 5 },
                    { 813, 9, "Magazine", 4 },
                    { 814, 9, "Newspaper", 1 },
                    { 815, 9, "Magazine", 4 },
                    { 816, 9, "Newspaper", 1 },
                    { 817, 9, "App", 4 },
                    { 818, 9, "Newspaper", 4 },
                    { 819, 9, "App", 2 },
                    { 820, 9, "Newspaper", 5 },
                    { 821, 9, "Magazine", 3 },
                    { 822, 9, "Internet", 3 },
                    { 823, 9, "Magazine", 2 },
                    { 797, 8, "Magazine", 5 },
                    { 824, 9, "Newspaper", 5 },
                    { 796, 8, "Magazine", 3 },
                    { 794, 8, "Newspaper", 4 },
                    { 767, 8, "Magazine", 5 },
                    { 768, 8, "App", 4 },
                    { 769, 8, "Magazine", 2 },
                    { 770, 8, "App", 3 },
                    { 771, 8, "Magazine", 5 },
                    { 772, 8, "Newspaper", 4 },
                    { 773, 8, "App", 2 },
                    { 774, 8, "Internet", 3 },
                    { 775, 8, "App", 5 },
                    { 776, 8, "Magazine", 4 },
                    { 777, 8, "Newspaper", 4 },
                    { 778, 8, "App", 5 },
                    { 779, 8, "Magazine", 2 },
                    { 780, 8, "Magazine", 4 },
                    { 781, 8, "Internet", 5 },
                    { 782, 8, "Magazine", 2 },
                    { 783, 8, "Magazine", 4 },
                    { 784, 8, "Newspaper", 1 },
                    { 785, 8, "Newspaper", 3 },
                    { 786, 8, "Magazine", 1 },
                    { 787, 8, "Internet", 2 },
                    { 788, 8, "App", 1 },
                    { 789, 8, "Newspaper", 5 },
                    { 790, 8, "Internet", 5 },
                    { 791, 8, "Magazine", 4 },
                    { 792, 8, "Internet", 4 },
                    { 793, 8, "App", 3 },
                    { 795, 8, "App", 4 },
                    { 887, 9, "Newspaper", 1 },
                    { 825, 9, "Newspaper", 1 },
                    { 827, 9, "Internet", 2 },
                    { 859, 9, "Magazine", 5 },
                    { 860, 9, "App", 5 },
                    { 861, 9, "App", 5 },
                    { 862, 9, "Newspaper", 2 },
                    { 863, 9, "Internet", 3 },
                    { 864, 9, "App", 4 },
                    { 865, 9, "Newspaper", 1 },
                    { 866, 9, "App", 1 },
                    { 867, 9, "Internet", 1 },
                    { 868, 9, "Internet", 5 },
                    { 869, 9, "Magazine", 4 },
                    { 870, 9, "Newspaper", 3 },
                    { 871, 9, "App", 3 },
                    { 872, 9, "Newspaper", 2 },
                    { 873, 9, "Internet", 5 },
                    { 874, 9, "Newspaper", 3 },
                    { 875, 9, "Internet", 4 },
                    { 876, 9, "Magazine", 3 },
                    { 877, 9, "App", 4 },
                    { 878, 9, "Newspaper", 3 },
                    { 879, 9, "Magazine", 2 },
                    { 880, 9, "Magazine", 2 },
                    { 881, 9, "Newspaper", 4 },
                    { 882, 9, "Internet", 1 },
                    { 883, 9, "Newspaper", 2 },
                    { 884, 9, "Magazine", 3 },
                    { 885, 9, "App", 2 },
                    { 858, 9, "Magazine", 1 },
                    { 826, 9, "Magazine", 4 },
                    { 857, 9, "Internet", 4 },
                    { 855, 9, "Newspaper", 2 },
                    { 828, 9, "Magazine", 1 },
                    { 829, 9, "Internet", 3 },
                    { 830, 9, "App", 2 },
                    { 831, 9, "Newspaper", 2 },
                    { 832, 9, "App", 1 },
                    { 833, 9, "App", 2 },
                    { 834, 9, "Internet", 3 },
                    { 835, 9, "Newspaper", 3 },
                    { 836, 9, "Newspaper", 2 },
                    { 837, 9, "Internet", 4 },
                    { 838, 9, "Magazine", 4 },
                    { 839, 9, "App", 3 },
                    { 840, 9, "Internet", 3 },
                    { 841, 9, "Magazine", 5 },
                    { 842, 9, "Newspaper", 3 },
                    { 843, 9, "Newspaper", 5 },
                    { 844, 9, "Magazine", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductionId", "Source", "Stars" },
                values: new object[,]
                {
                    { 845, 9, "Internet", 4 },
                    { 846, 9, "Internet", 5 },
                    { 847, 9, "App", 3 },
                    { 848, 9, "Newspaper", 5 },
                    { 849, 9, "Magazine", 3 },
                    { 850, 9, "Newspaper", 4 },
                    { 851, 9, "Magazine", 1 },
                    { 852, 9, "Magazine", 5 },
                    { 853, 9, "Newspaper", 5 },
                    { 854, 9, "Internet", 1 },
                    { 856, 9, "Magazine", 1 },
                    { 522, 6, "Newspaper", 4 },
                    { 521, 6, "Internet", 2 },
                    { 520, 6, "Newspaper", 4 },
                    { 185, 2, "Newspaper", 1 },
                    { 186, 2, "Newspaper", 1 },
                    { 187, 2, "Newspaper", 2 },
                    { 188, 2, "Magazine", 1 },
                    { 189, 2, "Magazine", 5 },
                    { 190, 2, "Magazine", 5 },
                    { 191, 2, "Magazine", 2 },
                    { 192, 2, "App", 3 },
                    { 193, 2, "Internet", 2 },
                    { 194, 2, "Internet", 1 },
                    { 195, 2, "Magazine", 4 },
                    { 196, 2, "Internet", 1 },
                    { 197, 2, "App", 3 },
                    { 198, 2, "Magazine", 3 },
                    { 199, 2, "Newspaper", 3 },
                    { 26, 1, "App", 2 },
                    { 201, 3, "Internet", 4 },
                    { 202, 3, "Internet", 5 },
                    { 203, 3, "Newspaper", 5 },
                    { 204, 3, "Internet", 3 },
                    { 205, 3, "Internet", 3 },
                    { 206, 3, "Internet", 2 },
                    { 207, 3, "Magazine", 3 },
                    { 208, 3, "Newspaper", 1 },
                    { 209, 3, "Newspaper", 3 },
                    { 210, 3, "Internet", 2 },
                    { 211, 3, "Newspaper", 5 },
                    { 184, 2, "App", 2 },
                    { 212, 3, "Internet", 1 },
                    { 183, 2, "Internet", 3 },
                    { 181, 2, "App", 1 },
                    { 154, 2, "Magazine", 5 },
                    { 155, 2, "Magazine", 1 },
                    { 156, 2, "App", 5 },
                    { 157, 2, "Internet", 1 },
                    { 158, 2, "Internet", 5 },
                    { 159, 2, "App", 5 },
                    { 160, 2, "Newspaper", 4 },
                    { 161, 2, "Newspaper", 5 },
                    { 162, 2, "Newspaper", 5 },
                    { 163, 2, "Newspaper", 4 },
                    { 164, 2, "Internet", 4 },
                    { 165, 2, "App", 4 },
                    { 166, 2, "Magazine", 1 },
                    { 167, 2, "Internet", 4 },
                    { 168, 2, "Magazine", 1 },
                    { 169, 2, "Newspaper", 1 },
                    { 170, 2, "Newspaper", 3 },
                    { 171, 2, "Newspaper", 2 },
                    { 172, 2, "Newspaper", 3 },
                    { 173, 2, "Internet", 2 },
                    { 174, 2, "App", 1 },
                    { 175, 2, "Magazine", 4 },
                    { 176, 2, "App", 4 },
                    { 177, 2, "Newspaper", 3 },
                    { 178, 2, "Newspaper", 3 },
                    { 179, 2, "App", 3 },
                    { 180, 2, "Magazine", 1 },
                    { 182, 2, "Internet", 5 },
                    { 153, 2, "Magazine", 1 },
                    { 213, 3, "Newspaper", 2 },
                    { 215, 3, "Magazine", 1 },
                    { 247, 3, "Newspaper", 2 },
                    { 248, 3, "Internet", 5 },
                    { 249, 3, "Magazine", 4 },
                    { 250, 3, "App", 5 },
                    { 251, 3, "Newspaper", 4 },
                    { 252, 3, "App", 4 },
                    { 253, 3, "App", 1 },
                    { 254, 3, "Newspaper", 5 },
                    { 255, 3, "Newspaper", 5 },
                    { 256, 3, "Internet", 2 },
                    { 257, 3, "Internet", 4 },
                    { 258, 3, "Newspaper", 3 },
                    { 259, 3, "Internet", 2 },
                    { 260, 3, "Newspaper", 4 },
                    { 261, 3, "Internet", 5 },
                    { 262, 3, "Internet", 4 },
                    { 263, 3, "Internet", 3 },
                    { 264, 3, "App", 2 },
                    { 265, 3, "Newspaper", 1 },
                    { 266, 3, "Internet", 1 },
                    { 267, 3, "Newspaper", 1 },
                    { 268, 3, "Magazine", 1 },
                    { 269, 3, "Newspaper", 1 },
                    { 270, 3, "Newspaper", 5 },
                    { 271, 3, "Magazine", 5 },
                    { 272, 3, "Magazine", 5 },
                    { 273, 3, "Magazine", 2 },
                    { 246, 3, "App", 4 },
                    { 214, 3, "Internet", 2 },
                    { 245, 3, "Magazine", 1 },
                    { 243, 3, "Magazine", 2 },
                    { 216, 3, "Newspaper", 5 },
                    { 217, 3, "Magazine", 1 },
                    { 218, 3, "App", 5 },
                    { 219, 3, "Internet", 4 },
                    { 220, 3, "Internet", 5 },
                    { 221, 3, "App", 3 },
                    { 222, 3, "Internet", 4 },
                    { 223, 3, "Magazine", 5 },
                    { 224, 3, "Newspaper", 2 },
                    { 225, 3, "App", 1 },
                    { 226, 3, "Internet", 2 },
                    { 227, 3, "Newspaper", 2 },
                    { 228, 3, "Internet", 3 },
                    { 229, 3, "App", 1 },
                    { 230, 3, "Newspaper", 5 },
                    { 231, 3, "Newspaper", 1 },
                    { 232, 3, "App", 1 },
                    { 233, 3, "Internet", 1 },
                    { 234, 3, "App", 5 },
                    { 235, 3, "Internet", 4 },
                    { 236, 3, "Newspaper", 4 },
                    { 237, 3, "Internet", 2 },
                    { 238, 3, "App", 3 },
                    { 239, 3, "App", 5 },
                    { 240, 3, "Magazine", 2 },
                    { 241, 3, "App", 1 },
                    { 242, 3, "Internet", 1 },
                    { 244, 3, "Magazine", 1 },
                    { 274, 3, "Internet", 1 },
                    { 152, 2, "App", 2 },
                    { 150, 2, "Newspaper", 5 },
                    { 62, 1, "Magazine", 2 },
                    { 63, 1, "Magazine", 1 },
                    { 64, 1, "App", 1 },
                    { 65, 1, "Newspaper", 2 },
                    { 66, 1, "Magazine", 5 },
                    { 67, 1, "Internet", 2 },
                    { 68, 1, "Internet", 2 },
                    { 69, 1, "App", 1 },
                    { 70, 1, "Magazine", 1 },
                    { 71, 1, "Internet", 4 },
                    { 72, 1, "App", 4 },
                    { 73, 1, "Newspaper", 5 },
                    { 74, 1, "Newspaper", 3 },
                    { 75, 1, "Newspaper", 5 },
                    { 76, 1, "Magazine", 2 },
                    { 77, 1, "App", 5 },
                    { 78, 1, "App", 3 },
                    { 79, 1, "Magazine", 5 },
                    { 80, 1, "Internet", 4 },
                    { 81, 1, "App", 1 },
                    { 82, 1, "Internet", 1 },
                    { 83, 1, "Magazine", 2 },
                    { 84, 1, "Newspaper", 2 },
                    { 85, 1, "Newspaper", 3 },
                    { 86, 1, "Magazine", 3 },
                    { 87, 1, "Magazine", 3 },
                    { 88, 1, "Internet", 5 },
                    { 61, 1, "Magazine", 1 },
                    { 89, 1, "Newspaper", 5 },
                    { 60, 1, "Magazine", 2 },
                    { 58, 1, "Magazine", 2 },
                    { 31, 1, "Internet", 4 },
                    { 32, 1, "App", 2 },
                    { 33, 1, "Magazine", 5 },
                    { 34, 1, "Internet", 1 },
                    { 35, 1, "Internet", 4 },
                    { 36, 1, "Internet", 4 },
                    { 37, 1, "Internet", 2 },
                    { 38, 1, "Internet", 1 },
                    { 39, 1, "Magazine", 4 },
                    { 40, 1, "App", 4 },
                    { 41, 1, "Internet", 2 },
                    { 42, 1, "App", 4 },
                    { 43, 1, "Newspaper", 4 },
                    { 44, 1, "Newspaper", 3 },
                    { 45, 1, "Internet", 5 },
                    { 46, 1, "App", 5 },
                    { 47, 1, "Newspaper", 1 },
                    { 48, 1, "App", 5 },
                    { 49, 1, "Internet", 1 },
                    { 50, 1, "Magazine", 3 },
                    { 51, 1, "Internet", 3 },
                    { 52, 1, "App", 1 },
                    { 53, 1, "Internet", 4 },
                    { 54, 1, "Newspaper", 4 },
                    { 55, 1, "Internet", 4 },
                    { 56, 1, "Magazine", 2 },
                    { 57, 1, "Magazine", 3 },
                    { 59, 1, "Magazine", 3 },
                    { 151, 2, "Newspaper", 5 },
                    { 90, 1, "App", 3 },
                    { 92, 1, "App", 5 },
                    { 123, 2, "Internet", 2 },
                    { 124, 2, "App", 1 },
                    { 125, 2, "Magazine", 3 },
                    { 126, 2, "App", 2 },
                    { 127, 2, "Magazine", 1 },
                    { 128, 2, "Magazine", 3 },
                    { 129, 2, "App", 2 },
                    { 130, 2, "App", 1 },
                    { 131, 2, "Internet", 3 },
                    { 132, 2, "App", 3 },
                    { 133, 2, "App", 4 },
                    { 134, 2, "App", 1 },
                    { 135, 2, "Magazine", 3 },
                    { 136, 2, "Magazine", 3 },
                    { 137, 2, "Newspaper", 5 },
                    { 138, 2, "App", 3 },
                    { 139, 2, "Newspaper", 5 },
                    { 140, 2, "App", 4 },
                    { 141, 2, "Newspaper", 5 },
                    { 142, 2, "Magazine", 2 },
                    { 143, 2, "Newspaper", 1 },
                    { 144, 2, "Magazine", 5 },
                    { 145, 2, "Internet", 5 },
                    { 146, 2, "Newspaper", 5 },
                    { 147, 2, "Magazine", 1 },
                    { 148, 2, "Magazine", 5 },
                    { 149, 2, "Internet", 5 },
                    { 122, 2, "Magazine", 1 },
                    { 91, 1, "Magazine", 2 },
                    { 121, 2, "Newspaper", 4 },
                    { 119, 2, "Internet", 1 },
                    { 93, 1, "Newspaper", 1 },
                    { 94, 1, "Newspaper", 4 },
                    { 95, 1, "Newspaper", 3 },
                    { 96, 1, "Magazine", 1 },
                    { 97, 1, "Internet", 2 },
                    { 98, 1, "App", 3 },
                    { 99, 1, "Magazine", 5 },
                    { 28, 1, "App", 1 },
                    { 27, 1, "App", 4 },
                    { 101, 2, "Newspaper", 4 },
                    { 102, 2, "Internet", 5 },
                    { 103, 2, "Magazine", 1 },
                    { 104, 2, "App", 1 },
                    { 105, 2, "Internet", 1 },
                    { 106, 2, "Newspaper", 5 },
                    { 107, 2, "Newspaper", 1 },
                    { 108, 2, "Magazine", 1 },
                    { 109, 2, "Magazine", 5 },
                    { 110, 2, "Newspaper", 5 },
                    { 111, 2, "App", 1 },
                    { 112, 2, "Internet", 1 },
                    { 113, 2, "Internet", 5 },
                    { 114, 2, "App", 1 },
                    { 115, 2, "Newspaper", 2 },
                    { 116, 2, "Internet", 2 },
                    { 117, 2, "Newspaper", 2 },
                    { 118, 2, "Newspaper", 5 },
                    { 120, 2, "Newspaper", 3 },
                    { 29, 1, "Internet", 2 },
                    { 275, 3, "Magazine", 1 },
                    { 277, 3, "Newspaper", 1 },
                    { 432, 5, "Newspaper", 3 },
                    { 433, 5, "App", 5 },
                    { 434, 5, "Magazine", 3 },
                    { 435, 5, "App", 4 },
                    { 436, 5, "Newspaper", 4 },
                    { 437, 5, "Internet", 3 },
                    { 438, 5, "App", 1 },
                    { 439, 5, "Internet", 3 },
                    { 440, 5, "Internet", 4 },
                    { 441, 5, "App", 5 },
                    { 442, 5, "Newspaper", 5 },
                    { 443, 5, "App", 2 },
                    { 444, 5, "App", 3 },
                    { 445, 5, "Newspaper", 1 },
                    { 446, 5, "Magazine", 5 },
                    { 447, 5, "Newspaper", 5 },
                    { 448, 5, "Internet", 1 },
                    { 449, 5, "Internet", 5 },
                    { 450, 5, "Magazine", 3 },
                    { 451, 5, "Newspaper", 2 },
                    { 452, 5, "Magazine", 5 },
                    { 453, 5, "Newspaper", 1 },
                    { 454, 5, "Internet", 5 },
                    { 455, 5, "App", 4 },
                    { 456, 5, "App", 4 },
                    { 457, 5, "Magazine", 5 },
                    { 458, 5, "Newspaper", 1 },
                    { 431, 5, "Internet", 2 },
                    { 459, 5, "Internet", 3 },
                    { 430, 5, "Internet", 4 },
                    { 428, 5, "Internet", 4 },
                    { 401, 5, "App", 1 },
                    { 402, 5, "Magazine", 5 },
                    { 403, 5, "App", 5 },
                    { 404, 5, "App", 3 },
                    { 405, 5, "Newspaper", 4 },
                    { 406, 5, "Newspaper", 4 },
                    { 407, 5, "Newspaper", 2 },
                    { 408, 5, "Internet", 5 },
                    { 409, 5, "App", 1 },
                    { 410, 5, "Newspaper", 3 },
                    { 411, 5, "App", 2 },
                    { 412, 5, "Newspaper", 4 },
                    { 413, 5, "App", 5 },
                    { 414, 5, "Internet", 3 },
                    { 415, 5, "Newspaper", 2 },
                    { 416, 5, "Magazine", 2 },
                    { 417, 5, "App", 4 },
                    { 418, 5, "Internet", 3 },
                    { 419, 5, "Magazine", 2 },
                    { 420, 5, "Newspaper", 2 },
                    { 421, 5, "Newspaper", 2 },
                    { 422, 5, "Newspaper", 3 },
                    { 423, 5, "App", 4 },
                    { 424, 5, "Magazine", 5 },
                    { 425, 5, "App", 3 },
                    { 426, 5, "Newspaper", 5 },
                    { 427, 5, "App", 1 },
                    { 429, 5, "Magazine", 2 },
                    { 23, 1, "Magazine", 2 },
                    { 460, 5, "App", 1 },
                    { 462, 5, "Newspaper", 3 },
                    { 494, 5, "Newspaper", 2 },
                    { 495, 5, "Internet", 4 },
                    { 496, 5, "Magazine", 4 },
                    { 497, 5, "Internet", 3 },
                    { 498, 5, "Magazine", 1 },
                    { 499, 5, "Magazine", 4 },
                    { 22, 1, "Newspaper", 1 },
                    { 21, 1, "Magazine", 5 },
                    { 501, 6, "Newspaper", 4 },
                    { 502, 6, "Internet", 4 },
                    { 503, 6, "Magazine", 4 },
                    { 504, 6, "Newspaper", 2 },
                    { 20, 1, "Magazine", 5 },
                    { 506, 6, "Magazine", 4 },
                    { 507, 6, "Magazine", 2 },
                    { 508, 6, "App", 5 },
                    { 509, 6, "Magazine", 5 },
                    { 510, 6, "Newspaper", 3 },
                    { 511, 6, "Internet", 1 },
                    { 512, 6, "App", 1 },
                    { 513, 6, "Magazine", 1 },
                    { 514, 6, "Magazine", 5 },
                    { 515, 6, "App", 4 },
                    { 516, 6, "Internet", 5 },
                    { 517, 6, "App", 1 },
                    { 518, 6, "Newspaper", 4 },
                    { 519, 6, "Internet", 2 },
                    { 493, 5, "Newspaper", 3 },
                    { 461, 5, "Magazine", 2 },
                    { 492, 5, "Magazine", 1 },
                    { 490, 5, "App", 3 },
                    { 463, 5, "Internet", 5 },
                    { 464, 5, "Newspaper", 3 },
                    { 465, 5, "Internet", 1 },
                    { 466, 5, "Newspaper", 1 },
                    { 467, 5, "Internet", 4 },
                    { 468, 5, "Magazine", 5 },
                    { 469, 5, "Internet", 1 },
                    { 470, 5, "App", 1 },
                    { 471, 5, "Magazine", 1 },
                    { 472, 5, "Internet", 1 },
                    { 473, 5, "App", 4 },
                    { 474, 5, "Newspaper", 5 },
                    { 475, 5, "Magazine", 2 },
                    { 476, 5, "Magazine", 4 },
                    { 477, 5, "Newspaper", 1 },
                    { 478, 5, "App", 2 },
                    { 479, 5, "Newspaper", 5 },
                    { 480, 5, "Internet", 4 },
                    { 481, 5, "Magazine", 5 },
                    { 482, 5, "Magazine", 5 },
                    { 483, 5, "Newspaper", 4 },
                    { 484, 5, "App", 2 },
                    { 485, 5, "Magazine", 4 },
                    { 486, 5, "Internet", 2 },
                    { 487, 5, "Internet", 5 },
                    { 488, 5, "App", 5 },
                    { 489, 5, "Newspaper", 2 },
                    { 491, 5, "Newspaper", 1 },
                    { 276, 3, "Magazine", 5 },
                    { 24, 1, "App", 3 },
                    { 398, 4, "Magazine", 1 },
                    { 309, 4, "Magazine", 2 },
                    { 310, 4, "Magazine", 2 },
                    { 311, 4, "App", 1 },
                    { 312, 4, "Newspaper", 1 },
                    { 313, 4, "Magazine", 4 },
                    { 314, 4, "Magazine", 5 },
                    { 315, 4, "Newspaper", 5 },
                    { 316, 4, "Magazine", 2 },
                    { 317, 4, "Internet", 4 },
                    { 318, 4, "Magazine", 3 },
                    { 319, 4, "Internet", 2 },
                    { 320, 4, "Newspaper", 5 },
                    { 321, 4, "Newspaper", 1 },
                    { 322, 4, "Internet", 5 },
                    { 323, 4, "Internet", 4 },
                    { 324, 4, "Newspaper", 2 },
                    { 325, 4, "Newspaper", 3 },
                    { 326, 4, "Newspaper", 4 },
                    { 327, 4, "App", 4 },
                    { 328, 4, "Magazine", 1 },
                    { 329, 4, "Internet", 5 },
                    { 330, 4, "Magazine", 2 },
                    { 331, 4, "Magazine", 3 },
                    { 332, 4, "Newspaper", 1 },
                    { 333, 4, "Newspaper", 3 },
                    { 334, 4, "Internet", 5 },
                    { 335, 4, "Newspaper", 1 },
                    { 308, 4, "Newspaper", 5 },
                    { 336, 4, "Internet", 1 },
                    { 307, 4, "Magazine", 1 },
                    { 305, 4, "App", 4 },
                    { 278, 3, "Magazine", 5 },
                    { 279, 3, "Magazine", 4 },
                    { 280, 3, "Internet", 2 },
                    { 281, 3, "Internet", 3 },
                    { 282, 3, "Magazine", 1 },
                    { 283, 3, "Newspaper", 2 },
                    { 284, 3, "Newspaper", 1 },
                    { 285, 3, "App", 1 },
                    { 286, 3, "App", 2 },
                    { 287, 3, "Internet", 1 },
                    { 288, 3, "Newspaper", 3 },
                    { 289, 3, "Internet", 2 },
                    { 290, 3, "App", 4 },
                    { 291, 3, "Internet", 5 },
                    { 292, 3, "Magazine", 4 },
                    { 293, 3, "Newspaper", 3 },
                    { 294, 3, "Magazine", 1 },
                    { 295, 3, "Newspaper", 4 },
                    { 296, 3, "Newspaper", 5 },
                    { 297, 3, "App", 5 },
                    { 298, 3, "App", 5 },
                    { 299, 3, "Newspaper", 3 },
                    { 25, 1, "Newspaper", 5 },
                    { 301, 4, "Internet", 3 },
                    { 302, 4, "App", 3 },
                    { 303, 4, "Newspaper", 1 },
                    { 304, 4, "App", 2 },
                    { 306, 4, "Magazine", 5 },
                    { 399, 4, "Internet", 1 },
                    { 337, 4, "App", 3 },
                    { 339, 4, "App", 5 },
                    { 371, 4, "Internet", 2 },
                    { 372, 4, "Newspaper", 2 },
                    { 373, 4, "Magazine", 1 },
                    { 374, 4, "Internet", 4 },
                    { 375, 4, "Internet", 1 },
                    { 376, 4, "App", 1 },
                    { 377, 4, "Internet", 4 },
                    { 378, 4, "Internet", 2 },
                    { 379, 4, "App", 1 },
                    { 380, 4, "Newspaper", 2 },
                    { 381, 4, "Magazine", 1 },
                    { 382, 4, "Newspaper", 1 },
                    { 383, 4, "Newspaper", 2 },
                    { 384, 4, "Internet", 4 },
                    { 385, 4, "Newspaper", 2 },
                    { 386, 4, "Internet", 4 },
                    { 387, 4, "Magazine", 2 },
                    { 388, 4, "App", 2 },
                    { 389, 4, "Magazine", 4 },
                    { 390, 4, "Internet", 1 },
                    { 391, 4, "Internet", 2 },
                    { 392, 4, "Magazine", 1 },
                    { 393, 4, "Newspaper", 1 },
                    { 394, 4, "Newspaper", 4 },
                    { 395, 4, "Newspaper", 1 },
                    { 396, 4, "Newspaper", 5 },
                    { 397, 4, "App", 5 },
                    { 370, 4, "Internet", 2 },
                    { 338, 4, "Magazine", 3 },
                    { 369, 4, "Internet", 2 },
                    { 367, 4, "Newspaper", 2 },
                    { 340, 4, "Magazine", 4 },
                    { 341, 4, "Magazine", 2 },
                    { 342, 4, "Magazine", 2 },
                    { 343, 4, "App", 4 },
                    { 344, 4, "Magazine", 1 },
                    { 345, 4, "App", 5 },
                    { 346, 4, "Internet", 4 },
                    { 347, 4, "Newspaper", 5 },
                    { 348, 4, "Newspaper", 1 },
                    { 349, 4, "Magazine", 3 },
                    { 350, 4, "Newspaper", 4 },
                    { 351, 4, "Newspaper", 2 },
                    { 352, 4, "Internet", 1 },
                    { 353, 4, "Newspaper", 2 },
                    { 354, 4, "App", 4 },
                    { 355, 4, "Newspaper", 3 },
                    { 356, 4, "App", 4 },
                    { 357, 4, "Magazine", 3 },
                    { 358, 4, "App", 2 },
                    { 359, 4, "Newspaper", 3 },
                    { 360, 4, "Magazine", 4 },
                    { 361, 4, "Internet", 1 },
                    { 362, 4, "Internet", 1 },
                    { 363, 4, "Internet", 5 },
                    { 364, 4, "Internet", 2 },
                    { 365, 4, "Internet", 4 },
                    { 366, 4, "Newspaper", 2 },
                    { 368, 4, "App", 2 },
                    { 505, 6, "App", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ActorId",
                table: "Characters",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ProductionId",
                table: "Characters",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_GraphicsCardId",
                table: "Computer",
                column: "GraphicsCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_HardDriveId",
                table: "Computer",
                column: "HardDriveId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_ProcessorId",
                table: "Computer",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_RamId",
                table: "Computer",
                column: "RamId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_WeightUnitId",
                table: "Computer",
                column: "WeightUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductionId",
                table: "Ratings",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_UsbQuantity_ComputerId",
                table: "UsbQuantity",
                column: "ComputerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "HardDriveType");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "StorageUnit");

            migrationBuilder.DropTable(
                name: "UsbQuantity");

            migrationBuilder.DropTable(
                name: "UsbType");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Productions");

            migrationBuilder.DropTable(
                name: "Computer");

            migrationBuilder.DropTable(
                name: "GraphicsCard");

            migrationBuilder.DropTable(
                name: "HardDrive");

            migrationBuilder.DropTable(
                name: "Processor");

            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "WeightUnit");
        }
    }
}
