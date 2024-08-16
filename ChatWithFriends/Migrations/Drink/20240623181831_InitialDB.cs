using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatWithFriends.Migrations.Drink
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ANiceholidayIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiceholidayIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiceholidayMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiceholidayMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiceholidaySug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiceholidaySug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiCheeseMilkCap",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiCheeseMilkCap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiflavoredTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiflavoredTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiFreshMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiFreshMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiOriginalTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiOriginalTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiTasteTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiTasteTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ANiWinterMelonTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANiWinterMelonTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherAncient",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherAncient", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherChew",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherChew", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherFresh",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherFresh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherMatcha",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherMatcha", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherMilkCover",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherMilkCover", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherSummerSmoothies",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherSummerSmoothies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherTaro",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherTaro", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AsherYakult",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsherYakult", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalCloudcover",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalCloudcover", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalFreshmilktea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalFreshmilktea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalFruity",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalFruity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalHandpath",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalHandpath", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BallsTeaIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallsTeaIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BallsTeaMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallsTeaMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BallsTeaSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallsTeaSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalMilktea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalMilktea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalSnowfungus",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalSnowfungus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalSpecialblend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalSpecialblend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalThickslices",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalThickslices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BalWinterlimited",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalWinterlimited", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGEIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGEIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGEMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGEMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGEMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGEMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGEMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGEMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGENaigai",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGENaigai", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGEScentedTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGEScentedTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGESeasonal",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGESeasonal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGESpecialBlend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGESpecialBlend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGESug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGESug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGETea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGETea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHAGETeaGoodMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAGETeaGoodMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYFreshFruitTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYFreshFruitTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYFreshTeaLatte",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYFreshTeaLatte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYMilkTeaCocoa",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYMilkTeaCocoa", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYOriginalLeaves",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYOriginalLeaves", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYReally",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYReally", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYSpecialCoffee",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYSpecialCoffee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYSummerOnly",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYSummerOnly", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMEBUYWinterOnly",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMEBUYWinterOnly", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewClassic",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewClassic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewFreshFruit",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewFreshFruit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewLatte",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewLatte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewNaigai",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewNaigai", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewOriginalTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewOriginalTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DaMingJadeDewWinterOnly",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaMingJadeDewWinterOnly", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaClassicSpecialties",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaClassicSpecialties", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaPrincessofFlowers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaPrincessofFlowers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaRoyalchoiceitem",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaRoyalchoiceitem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaRoyalFragrantMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaRoyalFragrantMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaRoyalLatte",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaRoyalLatte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DedeTeaSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DedeTeaSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FiftyLanFresh",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiftyLanFresh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FiftyLanIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiftyLanIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FiftyLanLatte",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiftyLanLatte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FiftyLanMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiftyLanMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FiftyLanSeasonal",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiftyLanSeasonal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FiftyLanSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiftyLanSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FiftyLanTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiftyLanTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuGoldenFresh",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuGoldenFresh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuGoldenGoodTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuGoldenGoodTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuJinHaomian",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuJinHaomian", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuJinYoumi",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuJinYoumi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuKimHougong",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuKimHougong", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuQKueh",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuQKueh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JinchaWuSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JinchaWuSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiAncient",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiAncient", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiFacia",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiFacia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiOolong",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiOolong", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiQueen",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiQueen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiSesame",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiSesame", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiTeaBag",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiTeaBag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiTune",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiTune", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaiWinterMelon",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaiWinterMelon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGBrownSugar",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGBrownSugar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGFreshFruit",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGFreshFruit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGFreshMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGFreshMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGKitKat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGKitKat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGSpecialBlend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGSpecialBlend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIKEFANGThickMilkCover",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKEFANGThickMilkCover", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkbreasts",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkbreasts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkCheeseMilkCap",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkCheeseMilkCap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkFreshlySqueezed",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkFreshlySqueezed", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkFreshMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkFreshMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkFreshSheep",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkFreshSheep", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkGoodTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkGoodTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkSoyMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkSoyMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwnBlackTeaMilkSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwnBlackTeaMilkSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenCoffee",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenCoffee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenFive",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenFive", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenTallMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenTallMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MrQueenTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrQueenTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionFruit",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionFruit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionGlobal",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionGlobal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionLatte",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionLatte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionMilkCheese",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionMilkCheese", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionRemember",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionRemember", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RestingPavilionTaiwan",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestingPavilionTaiwan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicChewySeries",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicChewySeries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicFragrantMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicFragrantMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RichteaIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RichteaIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RichteaMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RichteaMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RichteaSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RichteaSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicMilkCapSpecialBlend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicMilkCapSpecialBlend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicPureThickTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicPureThickTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicRefreshingFruitTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicRefreshingFruitTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicRoyalGradeSpecialBlend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicRoyalGradeSpecialBlend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicSmallFarmerThickBreasts",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicSmallFarmerThickBreasts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RicThickMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicThickMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinHealth",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinHealth", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinMountain",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinMountain", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinRich",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinRich", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShangYulinTop",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShangYulinTop", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaCorridor",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaCorridor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaFresh",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaFresh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaHealthy",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaHealthy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaTeaLatte",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaTeaLatte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SunriseTeaThickTeaLatte",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SunriseTeaThickTeaLatte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalChew",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalChew", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalFruit",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalFruit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalHot",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalHot", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalJapan",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalJapan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalMilkAroma",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalMilkAroma", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalSpecialBlend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalSpecialBlend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeasOriginalTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeasOriginalTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboFeatured",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboFeatured", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboFruit",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboFruit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboHandPath",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboHandPath", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboMilk",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboMilk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboMilKTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboMilKTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboOld",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboOld", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WanboWinter",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WanboWinter", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WongKeeTeaHouseIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WongKeeTeaHouseIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WongKeeTeaHouseMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WongKeeTeaHouseMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WongKeeTeaHouseSpecialBlend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WongKeeTeaHouseSpecialBlend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WongKeeTeaHouseSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WongKeeTeaHouseSug", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WongKeeTeaHouseTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WongKeeTeaHouseTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinFifty",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinFifty", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinFruit",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinFruit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinIce",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinIce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinMat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinMat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinMaterial",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinMaterial", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinMilkTea",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinMilkTea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinPurple",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<double>(type: "float", nullable: false),
                    Money2 = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinPurple", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinSoul",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinSoul", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinSpecialBlend",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinSpecialBlend", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WulinSug",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WulinSug", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ANiCheeseMilkCap",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiCheeseMilkCap001", 65.0, "奶蓋招牌紅", null },
                    { "ANiCheeseMilkCap002", 65.0, "奶蓋竹香茶", null },
                    { "ANiCheeseMilkCap003", 65.0, "奶蓋烏龍茶", null },
                    { "ANiCheeseMilkCap004", 65.0, "奶蓋蕎麥茶(推薦無糖)", null }
                });

            migrationBuilder.InsertData(
                table: "ANiFreshMilkTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiFreshMilkTea001", 70.0, "招牌紅拿鐵", null },
                    { "ANiFreshMilkTea002", 70.0, "烏龍拿鐵", null },
                    { "ANiFreshMilkTea003", 70.0, "黃金蕎麥拿鐵", null },
                    { "ANiFreshMilkTea004", 70.0, "竹香翡翠拿鐵", null },
                    { "ANiFreshMilkTea005", 80.0, "極黑芝麻拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "ANiMilkTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiMilkTea006", 50.0, "竹香翡翠奶茶", null },
                    { "ANiMilkTea005", 65.0, "極黑芝麻奶茶", null },
                    { "ANiMilkTea004", 65.0, "逮丸奶茶", null },
                    { "ANiMilkTea002", 60.0, "粉粿黑糖奶茶(甜度冰量固定)", null },
                    { "ANiMilkTea001", 50.0, "招牌紅奶茶", null },
                    { "ANiMilkTea003", 50.0, "黃金蕎麥奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "ANiOriginalTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiOriginalTea001", 40.0, "竹香翡翠", null },
                    { "ANiOriginalTea002", 35.0, "招牌紅茶", null },
                    { "ANiOriginalTea003", 35.0, "炭培烏龍", null },
                    { "ANiOriginalTea004", 35.0, "油切蕎麥茶(推薦無糖)", null },
                    { "ANiOriginalTea005", 35.0, "手採高山青", null }
                });

            migrationBuilder.InsertData(
                table: "ANiTasteTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiTasteTea005", 65.0, "柚子烏龍(冷飲冰量固定)", null },
                    { "ANiTasteTea004", 55.0, "桂花蕎麥茶(推薦半糖)", null },
                    { "ANiTasteTea002", 60.0, "粉粿黑糖檸檬(甜度冰量固定)", null },
                    { "ANiTasteTea001", 60.0, "粉粿桂花檸檬(甜度冰量固定)", null },
                    { "ANiTasteTea003", 55.0, "荔枝烏龍", null }
                });

            migrationBuilder.InsertData(
                table: "ANiWinterMelonTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiWinterMelonTea001", 45.0, "招牌冬瓜紅", null },
                    { "ANiWinterMelonTea002", 45.0, "冬瓜青茶", null },
                    { "ANiWinterMelonTea003", 50.0, "冬瓜檸檬", null },
                    { "ANiWinterMelonTea004", 50.0, "冬瓜仙草蜜(冰量固定)", null }
                });

            migrationBuilder.InsertData(
                table: "ANiceholidayIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "ANiceholidayIce004", "去冰(小碎冰)" },
                    { "ANiceholidayIce005", "完全去冰" },
                    { "ANiceholidayIce003", "微冰" },
                    { "ANiceholidayIce002", "少冰" },
                    { "ANiceholidayIce001", "正常冰" }
                });

            migrationBuilder.InsertData(
                table: "ANiceholidayMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "ANiceholidayMat001", 15.0, "草仔粿" },
                    { "ANiceholidayMat002", 10.0, "招牌粉粿" },
                    { "ANiceholidayMat003", 10.0, "琥珀粉圓" },
                    { "ANiceholidayMat004", 10.0, "蘆薈" },
                    { "ANiceholidayMat005", 10.0, "雙粉（粉粿+粉圓）" },
                    { "ANiceholidayMat006", 10.0, "嫩仙草" },
                    { "ANiceholidayMat007", 0.0, "無" }
                });

            migrationBuilder.InsertData(
                table: "ANiceholidaySug",
                columns: new[] { "ID", "SugarName" },
                values: new object[] { "ANiceholidaySug005", "一分糖" });

            migrationBuilder.InsertData(
                table: "ANiceholidaySug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "ANiceholidaySug004", "三分甜" },
                    { "ANiceholidaySug006", "無糖" },
                    { "ANiceholidaySug002", "七分甜" },
                    { "ANiceholidaySug001", "正常甜" },
                    { "ANiceholidaySug003", "五分甜" }
                });

            migrationBuilder.InsertData(
                table: "ANiflavoredTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiflavoredTea001", 55.0, "梅果招牌紅", null },
                    { "ANiflavoredTea002", 60.0, "荔枝蘆薈(甜度冰量固定)", null },
                    { "ANiflavoredTea003", 65.0, "鮮葡萄柚青茶", null },
                    { "ANiflavoredTea004", 55.0, "養樂多青茶", null },
                    { "ANiflavoredTea005", 60.0, "檸檬高山青", null }
                });

            migrationBuilder.InsertData(
                table: "AsherAncient",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherAncient007", 40.0, "古早味冬瓜鮮奶", null },
                    { "AsherAncient005", 35.0, "古早味冬瓜仙草", null },
                    { "AsherAncient004", 35.0, "古早味冬瓜QQ", null },
                    { "AsherAncient006", 40.0, "古早味冬瓜檸檬", null },
                    { "AsherAncient002", 25.0, "古早味冬瓜青茶", null },
                    { "AsherAncient001", 25.0, "古早味冬瓜茶", null },
                    { "AsherAncient003", 30.0, "古早味冬瓜珍珠", null }
                });

            migrationBuilder.InsertData(
                table: "AsherChew",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherChew001", 35.0, "珍珠奶茶", null },
                    { "AsherChew002", 35.0, "椰果奶茶", null },
                    { "AsherChew003", 40.0, "百香綠QQ", null },
                    { "AsherChew004", 40.0, "QQ奶茶(珍珠+椰果)", null },
                    { "AsherChew005", 40.0, "仙草凍奶茶", null },
                    { "AsherChew006", 40.0, "咖啡凍奶茶", null },
                    { "AsherChew007", 40.0, "蜜紅豆奶茶", null },
                    { "AsherChew008", 45.0, "統一布丁奶茶", null },
                    { "AsherChew009", 45.0, "醇鮮奶仙草凍", null }
                });

            migrationBuilder.InsertData(
                table: "AsherFresh",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherFresh006", 40.0, "鮮榨梅子檸檬汁", null },
                    { "AsherFresh008", 40.0, "鮮榨蜂蜜檸檬汁", null },
                    { "AsherFresh007", 40.0, "蜂蜜檸檬蘆薈", null },
                    { "AsherFresh005", 40.0, "鮮榨檸檬綠茶", null },
                    { "AsherFresh001", 30.0, "純蜜茶", null },
                    { "AsherFresh003", 40.0, "招牌莓果茶", null },
                    { "AsherFresh002", 40.0, "黃金柚子茶", null },
                    { "AsherFresh004", 40.0, "甘蔗青茶", null }
                });

            migrationBuilder.InsertData(
                table: "AsherIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "AsherIce001", "正常冰" },
                    { "AsherIce002", "少冰" },
                    { "AsherIce003", "微冰" },
                    { "AsherIce004", "去冰" }
                });

            migrationBuilder.InsertData(
                table: "AsherMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "AsherMat008", 0.0, "無" },
                    { "AsherMat007", 15.0, "統一布丁" },
                    { "AsherMat006", 10.0, "地芋" },
                    { "AsherMat005", 10.0, "仙草" }
                });

            migrationBuilder.InsertData(
                table: "AsherMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "AsherMat004", 10.0, "紅豆" },
                    { "AsherMat002", 5.0, "椰果" },
                    { "AsherMat001", 5.0, "珍珠" },
                    { "AsherMat003", 5.0, "蘆薈" }
                });

            migrationBuilder.InsertData(
                table: "AsherMatcha",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherMatcha001", 45.0, "抹茶奶香", null },
                    { "AsherMatcha002", 55.0, "抹茶紅豆", null },
                    { "AsherMatcha003", 55.0, "抹茶鮮奶", null }
                });

            migrationBuilder.InsertData(
                table: "AsherMilk",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherMilk005", 40.0, "杏仁奶香", null },
                    { "AsherMilk006", 40.0, "阿華田", null },
                    { "AsherMilk004", 40.0, "北海道奶茶", null },
                    { "AsherMilk002", 40.0, "芋頭奶香", null },
                    { "AsherMilk003", 40.0, "焦糖奶茶", null },
                    { "AsherMilk001", 40.0, "薄荷奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "AsherMilkCover",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherMilkCover001", 40.0, "奶蓋紅茶", null },
                    { "AsherMilkCover002", 40.0, "奶蓋綠茶", null },
                    { "AsherMilkCover003", 40.0, "奶蓋冬瓜茶", null }
                });

            migrationBuilder.InsertData(
                table: "AsherSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "AsherSug001", "全糖" },
                    { "AsherSug002", "少糖" },
                    { "AsherSug003", "半糖" },
                    { "AsherSug004", "微糖" },
                    { "AsherSug006", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "AsherSummerSmoothies",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherSummerSmoothies003", 40.0, "手打百香果沙", null },
                    { "AsherSummerSmoothies002", 40.0, "手打紅豆冰沙", null },
                    { "AsherSummerSmoothies001", 40.0, "手工綠豆冰沙", null }
                });

            migrationBuilder.InsertData(
                table: "AsherTaro",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherTaro001", 35.0, "地芋冬瓜茶", null },
                    { "AsherTaro002", 35.0, "地芋紅茶", null },
                    { "AsherTaro003", 40.0, "地芋奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "AsherTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherTea001", 25.0, "茉香綠茶", null },
                    { "AsherTea002", 25.0, "阿薩姆紅茶", null },
                    { "AsherTea003", 25.0, "翠玉青茶", null },
                    { "AsherTea004", 25.0, "炭焙烏龍茶", null },
                    { "AsherTea005", 25.0, "普洱菊花茶", null }
                });

            migrationBuilder.InsertData(
                table: "AsherYakult",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "AsherYakult004", 40.0, "養樂多莓果", null },
                    { "AsherYakult003", 40.0, "養樂多鮮榨檸檬", null },
                    { "AsherYakult002", 40.0, "養樂多冬瓜", null },
                    { "AsherYakult001", 40.0, "養樂多綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "BalCloudcover",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalCloudcover001", 60.0, "雲蓋烏龍", null },
                    { "BalCloudcover002", 60.0, "雲蓋青", null },
                    { "BalCloudcover003", 60.0, "雲蓋綠", null },
                    { "BalCloudcover004", 60.0, "雲蓋悠娜紅", null },
                    { "BalCloudcover005", 60.0, "雲蓋菩耳", null },
                    { "BalCloudcover006", 65.0, "雲蓋桂花烏龍", null }
                });

            migrationBuilder.InsertData(
                table: "BalCloudcover",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalCloudcover007", 90.0, "雲蓋泰泰", null },
                    { "BalCloudcover008", 75.0, "雲蓋阿華田", null },
                    { "BalCloudcover009", 90.0, "雲蓋冬瓜那堤", null }
                });

            migrationBuilder.InsertData(
                table: "BalFreshmilktea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalFreshmilktea006", 60.0, 70.0, "冬瓜那堤", null },
                    { "BalFreshmilktea005", 60.0, 70.0, "泰式鮮奶茶", null },
                    { "BalFreshmilktea004", 50.0, 60.0, "焙香大麥那提", null },
                    { "BalFreshmilktea001", 55.0, 65.0, "悠娜紅茶那堤", null },
                    { "BalFreshmilktea002", 55.0, 65.0, "沉香烏龍那提", null },
                    { "BalFreshmilktea003", 55.0, 65.0, "波樣綠茶那提", null }
                });

            migrationBuilder.InsertData(
                table: "BalFruity",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalFruity007", 55.0, "紫蘇梅果綠", null },
                    { "BalFruity011", 60.0, "百香多多", null },
                    { "BalFruity010", 55.0, "百香檸檬", null },
                    { "BalFruity009", 50.0, "凍檸紅茶", null },
                    { "BalFruity008", 50.0, "翡翠檸檬", null },
                    { "BalFruity006", 55.0, "多多綠茶", null },
                    { "BalFruity004", 60.0, "柳橙百香綠", null },
                    { "BalFruity003", 55.0, "百香雙Q", null },
                    { "BalFruity002", 60.0, "甘蔗青茶", null },
                    { "BalFruity001", 75.0, "香橙果綠", null },
                    { "BalFruity005", 50.0, "百香綠", null }
                });

            migrationBuilder.InsertData(
                table: "BalHandpath",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalHandpath001", 50.0, "仙波粉", null },
                    { "BalHandpath002", 50.0, "青青粉波椰", null },
                    { "BalHandpath003", 50.0, "綠豆粉條", null },
                    { "BalHandpath004", 55.0, "檸檬冬瓜粉條", null },
                    { "BalHandpath005", 55.0, "鴉片檸檬", null },
                    { "BalHandpath006", 45.0, "古早味仙草蜜", null },
                    { "BalHandpath007", 40.0, "黑金仙甘茶", null }
                });

            migrationBuilder.InsertData(
                table: "BalMilk",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalMilk007", 60.0, 75.0, "黑糖鮮奶", null },
                    { "BalMilk009", 65.0, 80.0, "布丁芋頭鮮奶", null },
                    { "BalMilk008", 65.0, 80.0, "珍珠布丁鮮奶", null },
                    { "BalMilk006", 60.0, 75.0, "手工布丁鮮奶", null },
                    { "BalMilk001", 60.0, 75.0, "黑糖珍珠鮮奶", null },
                    { "BalMilk004", 65.0, 80.0, "超濃芋鮮奶", null },
                    { "BalMilk003", 65.0, 0.0, "黑糖珍珠厚奶", null },
                    { "BalMilk002", 60.0, 75.0, "黑糖粉條鮮奶", null },
                    { "BalMilk005", 60.0, 75.0, "黑糖嫩仙草仙奶", null }
                });

            migrationBuilder.InsertData(
                table: "BalMilktea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalMilktea008", 45.0, 55.0, "焙香麥奶", null },
                    { "BalMilktea006", 45.0, 55.0, "波樣奶綠", null },
                    { "BalMilktea007", 45.0, 55.0, "沉香烏龍奶", null },
                    { "BalMilktea005", 45.0, 55.0, "懷舊奶茶", null },
                    { "BalMilktea001", 55.0, 65.0, "粉條黑糖奶茶", null },
                    { "BalMilktea003", 50.0, 60.0, "珍珠奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "BalMilktea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalMilktea002", 55.0, 65.0, "3喜奶茶", null },
                    { "BalMilktea004", 50.0, 60.0, "布丁奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "BalSnowfungus",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalSnowfungus001", 75.0, 0.0, "雪耳莎沙亞", null },
                    { "BalSnowfungus002", 75.0, 0.0, "黑糖鮮奶雪耳", null },
                    { "BalSnowfungus003", 75.0, 0.0, "桂花雪耳綠那堤", null },
                    { "BalSnowfungus004", 0.0, 75.0, "桂花檸檬雪耳", null },
                    { "BalSnowfungus005", 0.0, 75.0, "沁爽百香雪耳飲", null }
                });

            migrationBuilder.InsertData(
                table: "BalSpecialblend",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalSpecialblend005", 55.0, "蜂蜜菩耳", null },
                    { "BalSpecialblend006", 55.0, "桂花烏龍", null },
                    { "BalSpecialblend004", 55.0, "檸檬蜜", null },
                    { "BalSpecialblend007", 60.0, "桂花菩耳椰", null },
                    { "BalSpecialblend002", 45.0, "檸檬冬瓜", null },
                    { "BalSpecialblend001", 35.0, "古早味冬瓜露", null },
                    { "BalSpecialblend003", 55.0, "阿華田", null }
                });

            migrationBuilder.InsertData(
                table: "BalTea",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalTea007", 35.0, "沉香烏龍", null },
                    { "BalTea006", 35.0, "高山青茶", null },
                    { "BalTea008", 30.0, "焙香大麥茶", null },
                    { "BalTea005", 35.0, "波樣綠茶", null },
                    { "BalTea002", 40.0, "菩爾紅茶", null },
                    { "BalTea003", 40.0, "烏龍綠茶", null },
                    { "BalTea001", 45.0, "冬片烏龍", null },
                    { "BalTea004", 35.0, "悠娜紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "BalThickslices",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalThickslices001", 50.0, "日式鹹奶油", null },
                    { "BalThickslices002", 50.0, "金黃奶酥", null },
                    { "BalThickslices003", 50.0, "美式香蒜", null },
                    { "BalThickslices004", 55.0, "烤糖吐司", null }
                });

            migrationBuilder.InsertData(
                table: "BalWinterlimited",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "BalWinterlimited001", 50.0, 0.0, "貴妃奶茶", null },
                    { "BalWinterlimited002", 40.0, 0.0, "貴妃甘茶", null },
                    { "BalWinterlimited003", 60.0, 70.0, "重乳可可奶茶", null },
                    { "BalWinterlimited004", 70.0, 80.0, "特濃抹茶那堤", null }
                });

            migrationBuilder.InsertData(
                table: "BallsTeaIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "BallsTeaIce006", "熱" },
                    { "BallsTeaIce005", "溫" },
                    { "BallsTeaIce004", "去冰" },
                    { "BallsTeaIce001", "正常冰" },
                    { "BallsTeaIce002", "少冰" },
                    { "BallsTeaIce003", "微冰" }
                });

            migrationBuilder.InsertData(
                table: "BallsTeaMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "BallsTeaMat009", 10.0, "綠豆" },
                    { "BallsTeaMat011", 0.0, "無" },
                    { "BallsTeaMat010", 10.0, "粉條" },
                    { "BallsTeaMat007", 10.0, "布丁" },
                    { "BallsTeaMat008", 10.0, "椰果" },
                    { "BallsTeaMat006", 10.0, "芋頭" }
                });

            migrationBuilder.InsertData(
                table: "BallsTeaMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "BallsTeaMat004", 10.0, "珍珠" },
                    { "BallsTeaMat003", 10.0, "蜂蜜" },
                    { "BallsTeaMat002", 20.0, "桂花釀" },
                    { "BallsTeaMat001", 20.0, "雪耳" },
                    { "BallsTeaMat005", 10.0, "仙草" }
                });

            migrationBuilder.InsertData(
                table: "BallsTeaSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "BallsTeaSug001", "全糖" },
                    { "BallsTeaSug002", "少糖" },
                    { "BallsTeaSug003", "半糖" },
                    { "BallsTeaSug004", "微糖" },
                    { "BallsTeaSug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "CHAGEIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "CHAGEIce006", "熱" },
                    { "CHAGEIce005", "常溫" },
                    { "CHAGEIce004", "去冰" },
                    { "CHAGEIce001", "正常冰" },
                    { "CHAGEIce002", "少冰" },
                    { "CHAGEIce003", "微冰" }
                });

            migrationBuilder.InsertData(
                table: "CHAGEMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "CHAGEMat015", 0.0, "無" },
                    { "CHAGEMat014", 20.0, "奶蓋" },
                    { "CHAGEMat013", 15.0, "膠原凍" },
                    { "CHAGEMat012", 15.0, "咖啡寒天" },
                    { "CHAGEMat011", 15.0, "小芋園" },
                    { "CHAGEMat010", 15.0, "黃晶熊貓" },
                    { "CHAGEMat009", 15.0, "熊貓" },
                    { "CHAGEMat007", 15.0, "寒天" },
                    { "CHAGEMat006", 10.0, "綠豆" },
                    { "CHAGEMat001", 10.0, "珍珠" },
                    { "CHAGEMat002", 10.0, "椰果" },
                    { "CHAGEMat008", 15.0, "黃晶" },
                    { "CHAGEMat004", 10.0, "蘆薈" },
                    { "CHAGEMat005", 10.0, "茶凍" },
                    { "CHAGEMat003", 10.0, "黑糖珍珠" }
                });

            migrationBuilder.InsertData(
                table: "CHAGEMilk",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGEMilk005", 60.0, 70.0, "靜岡抹茶鮮", null },
                    { "CHAGEMilk003", 60.0, 70.0, "半熟招牌鮮", null },
                    { "CHAGEMilk004", 60.0, 70.0, "黑糖珍珠鮮奶", null },
                    { "CHAGEMilk001", 50.0, 60.0, "沐蘭鮮奶紅", null },
                    { "CHAGEMilk002", 55.0, 65.0, "迎曦鮮奶烏", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGEMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGEMilkTea008", 0.0, 60.0, "半熟奶茶", null },
                    { "CHAGEMilkTea002", 45.0, 50.0, "沐嵐珍奶", null },
                    { "CHAGEMilkTea003", 45.0, 55.0, "迎曦烏龍奶", null },
                    { "CHAGEMilkTea004", 45.0, 55.0, "巧克力可可'", null },
                    { "CHAGEMilkTea005", 50.0, 60.0, "咖啡寒天奶茶", null },
                    { "CHAGEMilkTea006", 0.0, 60.0, "沐嵐熊貓奶", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGEMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGEMilkTea007", 0.0, 60.0, "沐嵐黃晶熊貓奶'", null },
                    { "CHAGEMilkTea001", 45.0, 50.0, "沐嵐奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGENaigai",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGENaigai004", 65.0, "沐雲蕎寶(限黑糖)", null },
                    { "CHAGENaigai003", 65.0, "沐雲可可 (甜度固定)", null },
                    { "CHAGENaigai001", 55.0, "沐雲金萱", null },
                    { "CHAGENaigai002", 55.0, "沐雲紅", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGEScentedTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGEScentedTea001", 0.0, 35.0, "香片姍姍", null },
                    { "CHAGEScentedTea002", 0.0, 55.0, "姍姍凍檸(限冷飲)", null },
                    { "CHAGEScentedTea003", 45.0, 55.0, "姍姍奶綠", null },
                    { "CHAGEScentedTea004", 55.0, 60.0, "姍姍葡柚綠 (限冷飲)", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGESeasonal",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGESeasonal001", 0.0, 50.0, "綠豆冰沙(甜度固定)(限冷飲)", null },
                    { "CHAGESeasonal002", 0.0, 60.0, "綠豆牛奶冰沙(甜度固定)(限冷飲)", null },
                    { "CHAGESeasonal003", 65.0, 0.0, "巧脆冰沙 (甜度固定)(限冷飲)", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGESpecialBlend",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGESpecialBlend006", 0.0, 30.0, "鮮寧蜜蘆薈(限冷飲)", null },
                    { "CHAGESpecialBlend005", 0.0, 55.0, "戀寧不知青(限冷飲)", null },
                    { "CHAGESpecialBlend004", 50.0, 55.0, "鮮寧不知青(限冷飲)", null },
                    { "CHAGESpecialBlend003", 50.0, 55.0, "沐嵐平安紅", null },
                    { "CHAGESpecialBlend001", 30.0, 35.0, "冬瓜玉露", null },
                    { "CHAGESpecialBlend002", 35.0, 45.0, "鮮檸檬冬瓜(限冷飲)", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGESug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "CHAGESug001", "正常糖" },
                    { "CHAGESug002", "少糖" },
                    { "CHAGESug003", "半糖" },
                    { "CHAGESug004", "微糖" },
                    { "CHAGESug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "CHAGETea",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGETea007", 45.0, "蕎寶茶(限黑糖)", null },
                    { "CHAGETea006", 45.0, "黃金芯芽(限黑糖)", null },
                    { "CHAGETea005", 35.0, "鳴翠金萱", null },
                    { "CHAGETea002", 35.0, "石泉烏青", null },
                    { "CHAGETea003", 35.0, "迎曦烏龍", null },
                    { "CHAGETea001", 35.0, "0816李果紅", null },
                    { "CHAGETea004", 35.0, "不知青", null }
                });

            migrationBuilder.InsertData(
                table: "CHAGETeaGoodMat",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "CHAGETeaGoodMat001", 55.0, "珍椰金萱", null },
                    { "CHAGETeaGoodMat002", 60.0, "珍芋冬瓜", null },
                    { "CHAGETeaGoodMat003", 65.0, "寒芋姍姍", null },
                    { "CHAGETeaGoodMat004", 70.0, "綠豆芋奶茶", null },
                    { "CHAGETeaGoodMat005", 75.0, "蘋果寒天凍", null },
                    { "CHAGETeaGoodMat006", 75.0, "膠原貴妃(限冷飲)", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYFreshFruitTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "COMEBUYFreshFruitTea013", 55.0, 60.0, "芭C檸檬綠(建議半糖少冰以上)", null },
                    { "COMEBUYFreshFruitTea012", 0.0, 60.0, "鳳梨冰茶", null },
                    { "COMEBUYFreshFruitTea011", 0.0, 60.0, "葡萄柚綠茶", null },
                    { "COMEBUYFreshFruitTea010", 45.0, 50.0, "蘋果冰茶", null },
                    { "COMEBUYFreshFruitTea009", 45.0, 50.0, "百香搖果樂", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYFreshFruitTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "COMEBUYFreshFruitTea008", 45.0, 50.0, "養樂多綠茶", null },
                    { "COMEBUYFreshFruitTea003", 40.0, 45.0, "蜂蜜紅茶", null },
                    { "COMEBUYFreshFruitTea006", 45.0, 50.0, "檸檬冰茶", null },
                    { "COMEBUYFreshFruitTea005", 0.0, 45.0, "玉荷冰綠", null },
                    { "COMEBUYFreshFruitTea004", 40.0, 45.0, "蜂蜜綠茶", null },
                    { "COMEBUYFreshFruitTea002", 25.0, 30.0, "茉莉綠茶", null },
                    { "COMEBUYFreshFruitTea001", 25.0, 30.0, "錫蘭紅茶", null },
                    { "COMEBUYFreshFruitTea007", 45.0, 50.0, "梅果茶", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYFreshTeaLatte",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "COMEBUYFreshTeaLatte005", 0.0, 60.0, "觀音拿鐵 (100%台灣茶)", null },
                    { "COMEBUYFreshTeaLatte004", 0.0, 60.0, "金萱拿鐵", null },
                    { "COMEBUYFreshTeaLatte002", 0.0, 60.0, "烏龍拿鐵 (100%台灣茶)", null },
                    { "COMEBUYFreshTeaLatte001", 55.0, 60.0, "紅茶拿鐵", null },
                    { "COMEBUYFreshTeaLatte003", 0.0, 60.0, "四季春拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "COMEBUYIce001", "標準冰" },
                    { "COMEBUYIce002", "少冰" }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "COMEBUYMat007", 10.0, "愛玉" },
                    { "COMEBUYMat012", 15.0, "布丁" },
                    { "COMEBUYMat011", 15.0, "仙草凍" },
                    { "COMEBUYMat010", 10.0, "紅豆(季節限定)" },
                    { "COMEBUYMat009", 10.0, "紫米(季節限定)" },
                    { "COMEBUYMat008", 10.0, "蘆薈" },
                    { "COMEBUYMat005", 10.0, "粉條" },
                    { "COMEBUYMat013", 0.0, "無" },
                    { "COMEBUYMat004", 10.0, "小芋圓(芋圓 + 薯圓)" },
                    { "COMEBUYMat003", 10.0, "新雙Q(珍珠 + 芋圓 + 薯圓)" },
                    { "COMEBUYMat002", 5.0, "小紫蘇" },
                    { "COMEBUYMat001", 5.0, "珍珠" },
                    { "COMEBUYMat006", 10.0, "搖果樂(珍珠 + 椰果 + 荔枝凍)" }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYMilkTeaCocoa",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "COMEBUYMilkTeaCocoa009", 65.0, 0.0, "港式厚奶", null },
                    { "COMEBUYMilkTeaCocoa008", 55.0, 60.0, "桂花奶綠", null },
                    { "COMEBUYMilkTeaCocoa010", 65.0, 0.0, "觀音厚奶", null },
                    { "COMEBUYMilkTeaCocoa011", 40.0, 45.0, "經典可可 (+15元升級鮮奶)", null },
                    { "COMEBUYMilkTeaCocoa007", 0.0, 60.0, "仙草凍奶茶 (+15元升級鮮奶)", null },
                    { "COMEBUYMilkTeaCocoa002", 40.0, 45.0, "黃金奶綠", null },
                    { "COMEBUYMilkTeaCocoa005", 0.0, 55.0, "海神奶茶", null },
                    { "COMEBUYMilkTeaCocoa004", 0.0, 50.0, "鮮萃大麥奶茶 (本產品含有麩質之穀物製品)", null },
                    { "COMEBUYMilkTeaCocoa003", 45.0, 50.0, "珍珠奶茶", null },
                    { "COMEBUYMilkTeaCocoa001", 40.0, 45.0, "招牌奶茶", null },
                    { "COMEBUYMilkTeaCocoa006", 50.0, 55.0, "絕代雙Q奶茶 (+15元升級鮮奶茶)", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYOriginalLeaves",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "COMEBUYOriginalLeaves014", 0.0, 50.0, "桂花四季春", null },
                    { "COMEBUYOriginalLeaves013", 0.0, 50.0, "洛神蜜香紅茶", null },
                    { "COMEBUYOriginalLeaves012", 0.0, 50.0, "白桃蜜烏龍", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYOriginalLeaves",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "COMEBUYOriginalLeaves011", 0.0, 50.0, "東方美人 (100%台灣茶)", null },
                    { "COMEBUYOriginalLeaves010", 0.0, 50.0, "文山包種 (100%台灣茶)", null },
                    { "COMEBUYOriginalLeaves009", 0.0, 40.0, "熟滄觀音 (100%台灣茶)", null },
                    { "COMEBUYOriginalLeaves008", 0.0, 40.0, "海神", null },
                    { "COMEBUYOriginalLeaves015", 0.0, 55.0, "柑橘金萱", null },
                    { "COMEBUYOriginalLeaves006", 0.0, 40.0, "茉莉烏龍 (100%台灣茶)", null },
                    { "COMEBUYOriginalLeaves005", 0.0, 40.0, "烏龍綠茶 (100%台灣茶)", null },
                    { "COMEBUYOriginalLeaves004", 0.0, 40.0, "玫瑰普洱", null },
                    { "COMEBUYOriginalLeaves003", 0.0, 40.0, "四季春", null },
                    { "COMEBUYOriginalLeaves002", 0.0, 40.0, "碧螺春", null },
                    { "COMEBUYOriginalLeaves001", 0.0, 35.0, "鮮萃大麥紅茶 (本產品含有麩質之穀物製品)", null },
                    { "COMEBUYOriginalLeaves007", 0.0, 40.0, "斯里蘭卡烏瓦紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYReally",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGFreshFruit001", 0.0, 45.0, "超桔霸氣飲", null },
                    { "LIKEFANGFreshFruit002", 40.0, 45.0, "蜂蜜蘆薈", null },
                    { "LIKEFANGFreshFruit003", 45.0, 50.0, "金桔檸檬", null },
                    { "LIKEFANGFreshFruit004", 45.0, 50.0, "荔枝玉露", null },
                    { "LIKEFANGFreshFruit005", 0.0, 60.0, "纖美小紫蘇", null },
                    { "LIKEFANGFreshFruit006", 60.0, 80.0, "芭C檸檬多多 (不提供去冰)", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYSpecialCoffee",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[] { "COMEBUYSpecialCoffee001", 40.0, 45.0, "特調咖啡", null });

            migrationBuilder.InsertData(
                table: "COMEBUYSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "COMEBUYSug001", "標準糖" },
                    { "COMEBUYSug002", "少糖" },
                    { "COMEBUYSug003", "半糖" },
                    { "COMEBUYSug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYSummerOnly",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGSpecialBlend001", 0.0, 50.0, "檸檬愛玉", null },
                    { "LIKEFANGSpecialBlend002", 0.0, 50.0, "百香果冰沙", null },
                    { "LIKEFANGSpecialBlend003", 0.0, 60.0, "七巧歐蕾 (本產品含有花生、牛奶製品)", null },
                    { "LIKEFANGSpecialBlend004", 0.0, 60.0, "金芒果優酪 (本產品含有花生、牛奶製品)", null },
                    { "LIKEFANGSpecialBlend005", 0.0, 70.0, "青檸香柚QQ", null }
                });

            migrationBuilder.InsertData(
                table: "COMEBUYWinterOnly",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "COMEBUYWinterOnly010", 60.0, 80.0, "抹茶拿鐵", null },
                    { "COMEBUYWinterOnly009", 60.0, 0.0, "宇治抹茶", null },
                    { "COMEBUYWinterOnly007", 50.0, 55.0, "紫米可可", null },
                    { "COMEBUYWinterOnly006", 0.0, 55.0, "黑糖薑汁可可", null },
                    { "COMEBUYWinterOnly008", 50.0, 55.0, "紫米奶茶", null },
                    { "COMEBUYWinterOnly004", 45.0, 50.0, "熱檸茶", null },
                    { "COMEBUYWinterOnly003", 0.0, 50.0, "暖薑奶茶", null },
                    { "COMEBUYWinterOnly005", 45.0, 50.0, "熱桔茶", null },
                    { "COMEBUYWinterOnly002", 0.0, 40.0, "暖薑茶", null },
                    { "COMEBUYWinterOnly001", 0.0, 40.0, "桂圓紅棗", null }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewClassic",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DaMingJadeDewClassic001", 30.0, "冬瓜玉露青", null },
                    { "DaMingJadeDewClassic002", 60.0, "蘋果玉露青", null },
                    { "DaMingJadeDewClassic003", 60.0, "甘蔗玉露青", null },
                    { "DaMingJadeDewClassic004", 60.0, "鮮檸玉露青", null }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewClassic",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[] { "DaMingJadeDewClassic005", 60.0, "鳳梨玉露青", null });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewFreshFruit",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DaMingJadeDewFreshFruit011", 80.0, "草莓翡翠青", null },
                    { "DaMingJadeDewFreshFruit010", 75.0, "藍莓翡翠青'", null },
                    { "DaMingJadeDewFreshFruit009", 70.0, "奇異果翡翠青", null },
                    { "DaMingJadeDewFreshFruit008", 65.0, "葡萄柚桂花青", null },
                    { "DaMingJadeDewFreshFruit007", 60.0, "甘蔗檸檬", null },
                    { "DaMingJadeDewFreshFruit002", 50.0, "鮮檸翡翠青茶", null },
                    { "DaMingJadeDewFreshFruit005", 55.0, "翡翠多多青'", null },
                    { "DaMingJadeDewFreshFruit004", 55.0, "翡翠百香青'", null },
                    { "DaMingJadeDewFreshFruit003", 50.0, "鮮檸翡翠紅茶", null },
                    { "DaMingJadeDewFreshFruit001", 45.0, "鮮檸冬瓜露", null },
                    { "DaMingJadeDewFreshFruit006", 60.0, "紫蝶蜜檸凍(蝶豆花+檸檬汁+蜂蜜+蘆薈)", null }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "CHAGEIce004", "去冰" },
                    { "CHAGEIce003", "微冰" },
                    { "CHAGEIce002", "少冰" },
                    { "CHAGEIce001", "正常" }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewLatte",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DaMingJadeDewLatte001", 50.0, 0.0, "黑糖珍珠", null },
                    { "DaMingJadeDewLatte002", 0.0, 60.0, "玉露拿鐵", null },
                    { "DaMingJadeDewLatte003", 0.0, 60.0, "紅茶拿鐵", null },
                    { "DaMingJadeDewLatte004", 0.0, 60.0, "鐵觀音拿鐵", null },
                    { "DaMingJadeDewLatte005", 0.0, 60.0, "鮮草嫩奶", null }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "CHAGEMat008", 0.0, "無" },
                    { "CHAGEMat007", 15.0, "酪梨奶蓋" },
                    { "CHAGEMat005", 10.0, "蘆薈" },
                    { "CHAGEMat006", 10.0, "仙草" },
                    { "CHAGEMat003", 10.0, "黑糖珍珠" },
                    { "CHAGEMat001", 5.0, "珍珠" },
                    { "CHAGEMat004", 10.0, "咖啡凍" }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewMilkTea",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DaMingJadeDewMilkTea001", 50.0, "嚴選厚奶茶", null },
                    { "DaMingJadeDewMilkTea002", 50.0, "嚴選厚綠茶", null },
                    { "DaMingJadeDewMilkTea003", 50.0, "嚴選厚鐵觀音", null },
                    { "DaMingJadeDewMilkTea004", 50.0, "咖啡凍鐵觀音厚奶茶", null },
                    { "DaMingJadeDewMilkTea005", 55.0, "波霸厚奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewNaigai",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DaMingJadeDewNaigai007", 55.0, "酪梨冬瓜青'", null },
                    { "DaMingJadeDewNaigai008", 90.0, "酪梨奶蓋草莓青", null },
                    { "DaMingJadeDewNaigai005", 55.0, "酪梨冬瓜茶", null },
                    { "DaMingJadeDewNaigai006", 55.0, "酪梨青茶", null },
                    { "DaMingJadeDewNaigai003", 55.0, "酪梨鐵觀音", null },
                    { "DaMingJadeDewNaigai001", 55.0, "酪梨奶茶", null },
                    { "DaMingJadeDewNaigai004", 55.0, "酪梨綠茶'", null },
                    { "DaMingJadeDewNaigai002", 55.0, "酪梨紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewOriginalTea",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[] { "DaMingJadeDewOriginalTea008", 50.0, "冰釀烏龍", null });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewOriginalTea",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DaMingJadeDewOriginalTea001", 30.0, "玉露青茶", null },
                    { "DaMingJadeDewOriginalTea002", 30.0, "紅玉紅茶", null },
                    { "DaMingJadeDewOriginalTea003", 30.0, "四薰綠茶", null },
                    { "DaMingJadeDewOriginalTea004", 30.0, "覆焙鐵觀音", null },
                    { "DaMingJadeDewOriginalTea005", 30.0, "御品冬瓜綠", null },
                    { "DaMingJadeDewOriginalTea006", 40.0, "翡翠青茶", null },
                    { "DaMingJadeDewOriginalTea007", 40.0, "桂花青茶", null }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "CHAGESug006", "無糖(0%)" },
                    { "CHAGESug005", "一分糖(1%)" },
                    { "CHAGESug004", "微糖(30%)" },
                    { "CHAGESug002", "少糖(70%)" },
                    { "CHAGESug001", "正常(100%)" },
                    { "CHAGESug003", "半糖(50%)" }
                });

            migrationBuilder.InsertData(
                table: "DaMingJadeDewWinterOnly",
                columns: new[] { "ID", "Money1", "Name", "temperature" },
                values: new object[,]
                {
                    { "DaMingJadeDewWinterOnly001", 40.0, "暖薑原萃", null },
                    { "DaMingJadeDewWinterOnly002", 45.0, "暖薑紅玉", null },
                    { "DaMingJadeDewWinterOnly003", 45.0, "暖薑厚奶茶", null },
                    { "DaMingJadeDewWinterOnly004", 60.0, "蔗香暖薑", null }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaClassicSpecialties",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DedeTeaClassicSpecialties004", 60.0, 65.0, "香濃可可'", null },
                    { "DedeTeaClassicSpecialties005", 0.0, 75.0, "可可布丁冰沙", null },
                    { "DedeTeaClassicSpecialties003", 55.0, 65.0, "白露拿鐵", null },
                    { "DedeTeaClassicSpecialties001", 30.0, 35.0, "白露冬瓜", null },
                    { "DedeTeaClassicSpecialties002", 40.0, 50.0, "白露青檸", null }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "DedeTeaIce001", "正常冰" },
                    { "DedeTeaIce002", "少冰" },
                    { "DedeTeaIce003", "微冰" },
                    { "DedeTeaIce004", "去冰" },
                    { "DedeTeaIce005", "完全去冰" },
                    { "DedeTeaIce006", "常溫" },
                    { "DedeTeaIce007", "熱" }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "DedeTeaMat009", 0.0, "無" },
                    { "DedeTeaMat008", 15.0, "統一布丁" },
                    { "DedeTeaMat007", 15.0, "奶蓋" },
                    { "DedeTeaMat006", 10.0, "黑糖珍珠" },
                    { "DedeTeaMat004", 10.0, "綠茶凍" },
                    { "DedeTeaMat003", 10.0, "奇亞籽" },
                    { "DedeTeaMat002", 10.0, "椰果" },
                    { "DedeTeaMat001", 10.0, "珍珠" },
                    { "DedeTeaMat005", 10.0, "玫瑰凍" }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaPrincessofFlowers",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DedeTeaPrincessofFlowers010", 0.0, 55.0, "蜜桃青茶", null },
                    { "DedeTeaPrincessofFlowers015", 0.0, 75.0, "蜜桃沙沙", null },
                    { "DedeTeaPrincessofFlowers014", 0.0, 65.0, "咕溜蜜桃烏龍", null },
                    { "DedeTeaPrincessofFlowers013", 0.0, 65.0, "咕溜蜜桃青茶", null }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaPrincessofFlowers",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DedeTeaPrincessofFlowers012", 0.0, 65.0, "咕溜蜜桃紅玉", null },
                    { "DedeTeaPrincessofFlowers011", 0.0, 55.0, "蜜桃烏龍", null },
                    { "DedeTeaPrincessofFlowers009", 0.0, 55.0, "蜜桃紅玉", null },
                    { "DedeTeaPrincessofFlowers007", 60.0, 70.0, "丹荔玫瑰公主", null },
                    { "DedeTeaPrincessofFlowers008", 55.0, 65.0, "青檸青森蘋果飲", null },
                    { "DedeTeaPrincessofFlowers006", 50.0, 60.0, "甘蔗青茶", null },
                    { "DedeTeaPrincessofFlowers005", 0.0, 60.0, "紅柚烏龍", null },
                    { "DedeTeaPrincessofFlowers004", 0.0, 55.0, "凍檸茶", null },
                    { "DedeTeaPrincessofFlowers003", 55.0, 65.0, "黛黛紅玉果茶", null },
                    { "DedeTeaPrincessofFlowers002", 50.0, 60.0, "黃金香橙大吉嶺", null },
                    { "DedeTeaPrincessofFlowers001", 55.0, 65.0, "馥麗莓果大吉嶺", null }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaRoyalFragrantMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DedeTeaRoyalFragrantMilkTea004", 45.0, 55.0, "烏龍奶茶", null },
                    { "DedeTeaRoyalFragrantMilkTea003", 50.0, 60.0, "皇家珍珠奶茶", null },
                    { "DedeTeaRoyalFragrantMilkTea001", 0.0, 55.0, "三皇奶茶", null },
                    { "DedeTeaRoyalFragrantMilkTea002", 45.0, 55.0, "皇家奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaRoyalLatte",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DedeTeaRoyalLatte001", 65.0, 0.0, "焦糖布蕾王子", null },
                    { "DedeTeaRoyalLatte002", 65.0, 80.0, "黑糖珍珠鮮奶", null },
                    { "DedeTeaRoyalLatte003", 55.0, 65.0, "皇家拿鐵", null },
                    { "DedeTeaRoyalLatte004", 55.0, 65.0, "烏龍拿鐵", null },
                    { "DedeTeaRoyalLatte005", 0.0, 70.0, "凡爾賽玫瑰拿鐵", null },
                    { "DedeTeaRoyalLatte006", 0.0, 75.0, "甘蔗拿鐵", null },
                    { "DedeTeaRoyalLatte007", 50.0, 55.0, "皇家奶蓋茶", null }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaRoyalchoiceitem",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "DedeteaRoyalchoiceitem006", 35.0, 40.0, "琥珀烏龍", null },
                    { "DedeteaRoyalchoiceitem004", 30.0, 35.0, "金萱綠茶", null },
                    { "DedeteaRoyalchoiceitem005", 30.0, 35.0, "四季青茶", null },
                    { "DedeteaRoyalchoiceitem002", 30.0, 35.0, "凱薩琳皇后大吉嶺", null },
                    { "DedeteaRoyalchoiceitem001", 0.0, 45.0, "三皇黛黛茶", null },
                    { "DedeteaRoyalchoiceitem003", 35.0, 40.0, "維多莉亞女王紅玉", null }
                });

            migrationBuilder.InsertData(
                table: "DedeTeaSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "DedeTeaSug001", "全糖" },
                    { "DedeTeaSug002", "少糖" },
                    { "DedeTeaSug003", "半糖" },
                    { "DedeTeaSug004", "微糖" },
                    { "DedeTeaSug005", "一分糖" },
                    { "DedeTeaSug006", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanFresh",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "FiftyLanFresh006", 55.0, 75.0, "檸檬多多", null },
                    { "FiftyLanFresh005", 50.0, 65.0, "檸檬梅汁", null },
                    { "FiftyLanFresh004", 50.0, 65.0, "金桔檸檬", null },
                    { "FiftyLanFresh002", 40.0, 55.0, "8冰茶", null },
                    { "FiftyLanFresh001", 40.0, 55.0, "柚子茶", null },
                    { "FiftyLanFresh003", 50.0, 65.0, "檸檬汁", null }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "FiftyLanIce001", "正常冰" },
                    { "FiftyLanIce002", "少冰" }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "FiftyLanIce003", "微冰" },
                    { "FiftyLanIce004", "去冰" },
                    { "FiftyLanIce005", "溫" },
                    { "FiftyLanIce006", "熱" }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanLatte",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "FiftyLanLatte007", 55.0, 75.0, "布丁紅茶拿鐵", null },
                    { "FiftyLanLatte010", 55.0, 75.0, "可可芭蕾拿鐵", null },
                    { "FiftyLanLatte009", 55.0, 75.0, "阿華田拿鐵", null },
                    { "FiftyLanLatte008", 55.0, 75.0, "冰淇淋紅茶拿鐵", null },
                    { "FiftyLanLatte006", 50.0, 65.0, "燕麥紅茶拿鐵", null },
                    { "FiftyLanLatte004", 50.0, 65.0, "珍珠紅茶拿鐵", null },
                    { "FiftyLanLatte001", 50.0, 65.0, "紅茶拿鐵", null },
                    { "FiftyLanLatte005", 50.0, 65.0, "波霸紅茶拿鐵", null },
                    { "FiftyLanLatte003", 50.0, 65.0, "烏龍拿鐵", null },
                    { "FiftyLanLatte002", 50.0, 65.0, "綠茶拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "FiftyLanMat001", 0.0, "珍珠" },
                    { "FiftyLanMat002", 0.0, "波霸" },
                    { "FiftyLanMat003", 0.0, "椰果" },
                    { "FiftyLanMat005", 0.0, "珍波椰" },
                    { "FiftyLanMat006", 10.0, "布丁" },
                    { "FiftyLanMat007", 0.0, "珍椰" },
                    { "FiftyLanMat008", 0.0, "波椰" },
                    { "FiftyLanMat009", 0.0, "無" },
                    { "FiftyLanMat004", 0.0, "混珠" }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanSeasonal",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "FiftyLanSeasonal008", 55.0, 75.0, "葡萄柚多多", null },
                    { "FiftyLanSeasonal005", 55.0, 75.0, "檸檬蜜", null },
                    { "FiftyLanSeasonal007", 55.0, 75.0, "葡萄柚蜜", null },
                    { "FiftyLanSeasonal006", 55.0, 75.0, "金桔檸檬蜜", null },
                    { "FiftyLanSeasonal004", 50.0, 65.0, "葡萄柚汁", null },
                    { "FiftyLanSeasonal002", 50.0, 65.0, "蜜蜂奶茶", null },
                    { "FiftyLanSeasonal001", 40.0, 55.0, "蜜蜂綠茶", null },
                    { "FiftyLanSeasonal003", 50.0, 65.0, "鮮柚綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "FiftyLanSug001", "全糖" },
                    { "FiftyLanSug002", "少糖" },
                    { "FiftyLanSug003", "半糖" },
                    { "FiftyLanSug004", "微糖" },
                    { "FiftyLanSug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "FiftyLanTea029", 40.0, 55.0, "奶茶", null },
                    { "FiftyLanTea028", 40.0, 55.0, "柚子烏茶", null },
                    { "FiftyLanTea027", 40.0, 55.0, "柚子青茶", null },
                    { "FiftyLanTea024", 40.0, 55.0, "旺來青茶", null },
                    { "FiftyLanTea042", 50.0, 65.0, "可可芭蕾", null },
                    { "FiftyLanTea025", 40.0, 55.0, "柚子紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "FiftyLanTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "FiftyLanTea030", 40.0, 55.0, "綠茶", null },
                    { "FiftyLanTea026", 40.0, 55.0, "柚子綠茶", null },
                    { "FiftyLanTea031", 40.0, 55.0, "烏龍奶茶", null },
                    { "FiftyLanTea023", 40.0, 55.0, "旺來綠茶", null },
                    { "FiftyLanTea033", 40.0, 55.0, "椰果奶茶", null },
                    { "FiftyLanTea034", 40.0, 55.0, "珍珠奶茶", null },
                    { "FiftyLanTea035", 40.0, 55.0, "波霸奶茶", null },
                    { "FiftyLanTea036", 40.0, 55.0, "燕麥奶茶", null },
                    { "FiftyLanTea037", 50.0, 65.0, "布丁奶茶", null },
                    { "FiftyLanTea038", 50.0, 65.0, "冰淇淋奶茶", null },
                    { "FiftyLanTea039", 40.0, 55.0, "紅茶瑪奇朵(鮮奶油)", null },
                    { "FiftyLanTea040", 40.0, 55.0, "青茶瑪奇朵(鮮奶油)", null },
                    { "FiftyLanTea041", 45.0, 60.0, "阿華田", null },
                    { "FiftyLanTea032", 40.0, 55.0, "奶青茶", null },
                    { "FiftyLanTea022", 40.0, 55.0, "旺來紅茶", null },
                    { "FiftyLanTea017", 40.0, 55.0, "梅の綠茶", null },
                    { "FiftyLanTea020", 40.0, 55.0, "多多綠", null },
                    { "FiftyLanTea021", 40.0, 55.0, "冰淇淋紅茶", null },
                    { "FiftyLanTea001", 30.0, 35.0, "茉莉綠茶", null },
                    { "FiftyLanTea002", 30.0, 35.0, "阿薩姆紅茶", null },
                    { "FiftyLanTea003", 30.0, 35.0, "四季春青茶", null },
                    { "FiftyLanTea004", 30.0, 35.0, "黃金烏龍茶", null },
                    { "FiftyLanTea005", 35.0, 45.0, "椰果紅茶", null },
                    { "FiftyLanTea006", 35.0, 45.0, "椰果綠茶", null },
                    { "FiftyLanTea007", 35.0, 45.0, "椰果青茶", null },
                    { "FiftyLanTea008", 35.0, 45.0, "椰果烏茶", null },
                    { "FiftyLanTea009", 35.0, 45.0, "波霸紅茶", null },
                    { "FiftyLanTea010", 35.0, 45.0, "波霸綠茶", null },
                    { "FiftyLanTea011", 35.0, 45.0, "燕麥紅茶", null },
                    { "FiftyLanTea012", 35.0, 45.0, "燕麥綠茶", null },
                    { "FiftyLanTea013", 35.0, 45.0, "微檸檬紅茶", null },
                    { "FiftyLanTea014", 35.0, 45.0, "微檸檬綠茶", null },
                    { "FiftyLanTea015", 40.0, 55.0, "檸檬綠茶", null },
                    { "FiftyLanTea016", 40.0, 55.0, "檸檬青茶", null },
                    { "FiftyLanTea018", 40.0, 55.0, "8冰綠茶", null },
                    { "FiftyLanTea019", 40.0, 55.0, "情人茶", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuGoldenFresh",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "JinchaWuGoldenFresh004", 55.0, "柳丁果果粒 (台灣柳丁)", null },
                    { "JinchaWuGoldenFresh003", 55.0, "紅柚果果粒", null },
                    { "JinchaWuGoldenFresh001", 60.0, "紅蔗青茶", null },
                    { "JinchaWuGoldenFresh002", 60.0, "翡翠鮮檸", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuGoldenGoodTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "JinchaWuGoldenGoodTea001", 55.0, "金青茶王", null },
                    { "JinchaWuGoldenGoodTea002", 60.0, "冬採四季青", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuGoldenGoodTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "JinchaWuGoldenGoodTea003", 65.0, "日光金萱", null },
                    { "JinchaWuGoldenGoodTea004", 55.0, "金牌紅茶", null },
                    { "JinchaWuGoldenGoodTea005", 60.0, "清新小茉綠", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "JinchaWuIce003", "微冰(30%)" },
                    { "JinchaWuIce001", "正常冰(100%)" },
                    { "JinchaWuIce002", "半冰(50%)" },
                    { "JinchaWuIce004", "去冰(0%)" }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuJinHaomian",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "JinchaWuJinHaomian006", 65.0, "憨厚冬瓜 (固定甜度)", null },
                    { "JinchaWuJinHaomian005", 65.0, "冬露菊花 (固定甜度)", null },
                    { "JinchaWuJinHaomian004", 65.0, "冰糖菊花", null },
                    { "JinchaWuJinHaomian007", 65.0, "冬檸冰茶 (固定甜度)", null },
                    { "JinchaWuJinHaomian002", 65.0, "蕎麥厚奶", null },
                    { "JinchaWuJinHaomian001", 65.0, "黃金蕎麥茶", null },
                    { "JinchaWuJinHaomian003", 65.0, "蕎麥拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuJinYoumi",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "JinchaWuJinYoumi003", 65.0, "蜂蜜鮮檸 (固定甜度)", null },
                    { "JinchaWuJinYoumi004", 65.0, "粒粒蜜紅柚 (固定甜度)", null },
                    { "JinchaWuJinYoumi001", 65.0, "百花蜜綠 (固定甜度)", null },
                    { "JinchaWuJinYoumi002", 65.0, "秋菊香蜜 (固定甜度)", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuKimHougong",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "JinchaWuKimHougong001", 50.0, "金紅拿鐵", null },
                    { "JinchaWuKimHougong002", 60.0, "砲彈金紅拿鐵", null },
                    { "JinchaWuKimHougong003", 50.0, "醇濃厚奶", null },
                    { "JinchaWuKimHougong004", 65.0, "砲彈厚奶", null },
                    { "JinchaWuKimHougong005", 65.0, "奶蓋金紅", null },
                    { "JinchaWuKimHougong006", 50.0, "梅釀小茉綠", null },
                    { "JinchaWuKimHougong007", 65.0, "多多翠綠", null },
                    { "JinchaWuKimHougong008", 50.0, "綠豆沙牛奶 (固定甜度與冰量)", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "JinchaWuMat004", 0.0, "無" },
                    { "JinchaWuMat003", 20.0, "水果Q粿(份)" },
                    { "JinchaWuMat001", 10.0, "砲彈(份)" },
                    { "JinchaWuMat002", 15.0, "純蜜Q粿(份)" }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuQKueh",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "JinchaWuQKueh001", 40.0, "Q粿紅茶", null },
                    { "JinchaWuQKueh002", 35.0, "Q粿蕎麥厚奶", null },
                    { "JinchaWuQKueh003", 35.0, "Q粿厚奶", null },
                    { "JinchaWuQKueh004", 35.0, "柳丁Q粿果粒茶", null },
                    { "JinchaWuQKueh005", 35.0, "荔枝Q粿果粒茶", null },
                    { "JinchaWuQKueh006", 35.0, "紅柚Q粿果粒茶", null }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "JinchaWuSug007", "無糖(0%)" },
                    { "JinchaWuSug006", "一分糖(10%)" },
                    { "JinchaWuSug005", "兩分糖(20%)" },
                    { "JinchaWuSug003", "半糖(50%)" },
                    { "JinchaWuSug002", "少糖(80%)" },
                    { "JinchaWuSug001", "全糖(100%)" }
                });

            migrationBuilder.InsertData(
                table: "JinchaWuSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[] { "JinchaWuSug004", "微糖(30%)" });

            migrationBuilder.InsertData(
                table: "LIKEFANGBrownSugar",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGBrownSugar001", 45.0, 55.0, "黑糖珍珠奶茶", null },
                    { "LIKEFANGBrownSugar002", 60.0, 75.0, "黑糖珍珠鮮奶", null },
                    { "LIKEFANGBrownSugar003", 60.0, 80.0, "黑糖珍珠可可鮮奶", null },
                    { "LIKEFANGBrownSugar004", 60.0, 80.0, "黑糖珍珠抹茶鮮奶", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGFreshFruit",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGFreshFruit007", 0.0, 60.0, "旺來百香綠", null },
                    { "LIKEFANGFreshFruit006", 0.0, 50.0, "鮮百香綠茶", null },
                    { "LIKEFANGFreshFruit005", 0.0, 55.0, "百香QQ綠", null },
                    { "LIKEFANGFreshFruit004", 0.0, 60.0, "清檸芭樂", null },
                    { "LIKEFANGFreshFruit002", 0.0, 60.0, "甘蔗清茶", null },
                    { "LIKEFANGFreshFruit001", 0.0, 50.0, "冬瓜檸檬", null },
                    { "LIKEFANGFreshFruit003", 0.0, 60.0, "甘蔗檸檬", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGFreshMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGFreshMilkTea001", 55.0, 65.0, "經典鮮奶茶", null },
                    { "LIKEFANGFreshMilkTea002", 45.0, 55.0, "紅茶鮮奶茶", null },
                    { "LIKEFANGFreshMilkTea003", 45.0, 55.0, "格雷鮮奶茶", null },
                    { "LIKEFANGFreshMilkTea004", 45.0, 55.0, "小葉綠鮮奶茶", null },
                    { "LIKEFANGFreshMilkTea005", 45.0, 55.0, "大禹嶺鮮奶茶", null },
                    { "LIKEFANGFreshMilkTea006", 55.0, 65.0, "OREO鮮奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "LIKEFANGIce006", "熱" },
                    { "LIKEFANGIce004", "去冰" },
                    { "LIKEFANGIce005", "常溫" },
                    { "LIKEFANGIce002", "少冰" },
                    { "LIKEFANGIce003", "微冰" },
                    { "LIKEFANGIce001", "正常" }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGKitKat",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGKitKat001", 0.0, 55.0, "幸運奶茶", null },
                    { "LIKEFANGKitKat002", 0.0, 90.0, "滿分草莓", null },
                    { "LIKEFANGKitKat003", 0.0, 65.0, "幸運鮮奶茶", null },
                    { "LIKEFANGKitKat004", 0.0, 90.0, "元氣奇異果", null },
                    { "LIKEFANGKitKat005", 0.0, 90.0, "勝利法芙娜", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "LIKEFANGMat003", 10.0, "椰果" },
                    { "LIKEFANGMat001", 10.0, "珍珠" },
                    { "LIKEFANGMat002", 10.0, "蒟蒻" },
                    { "LIKEFANGMat004", 10.0, "OREO" },
                    { "LIKEFANGMat005", 15.0, "LitKat" },
                    { "LIKEFANGMat006", 15.0, "黑糖珍珠" },
                    { "LIKEFANGMat007", 15.0, "經典(珍珠+蒟蒻+椰果)" },
                    { "LIKEFANGMat008", 20.0, "厚奶蓋" },
                    { "LIKEFANGMat009", 0.0, "無" }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGMilkTea007", 45.0, 55.0, "OREO奶茶", null },
                    { "LIKEFANGMilkTea005", 50.0, 60.0, "經典奶茶", null },
                    { "LIKEFANGMilkTea004", 45.0, 55.0, "可可奶茶", null },
                    { "LIKEFANGMilkTea006", 40.0, 50.0, "小葉綠奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGMilkTea002", 40.0, 50.0, "格雷奶茶", null },
                    { "LIKEFANGMilkTea001", 40.0, 50.0, "手作奶茶", null },
                    { "LIKEFANGMilkTea003", 45.0, 55.0, "珍珠奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGSpecialBlend",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGSpecialBlend001", 0.0, 45.0, "綠豆沙", null },
                    { "LIKEFANGSpecialBlend002", 0.0, 50.0, "多多綠茶", null },
                    { "LIKEFANGSpecialBlend003", 0.0, 55.0, "綠豆沙牛奶", null },
                    { "LIKEFANGSpecialBlend004", 0.0, 60.0, "港式檸檬奶", null },
                    { "LIKEFANGSpecialBlend005", 0.0, 50.0, "蜂蜜蘋果醋飲", null },
                    { "LIKEFANGSpecialBlend006", 0.0, 50.0, "翡翠檸檬紅茶", null },
                    { "LIKEFANGSpecialBlend007", 0.0, 50.0, "翡翠檸檬綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "LIKEFANGSug005", "無糖" },
                    { "LIKEFANGSug004", "微糖" },
                    { "LIKEFANGSug003", "半糖" },
                    { "LIKEFANGSug001", "全糖" },
                    { "LIKEFANGSug002", "少糖" }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGTea001", 30.0, 35.0, "冬瓜茶", null },
                    { "LIKEFANGTea002", 25.0, 30.0, "小葉綠茶", null },
                    { "LIKEFANGTea003", 30.0, 35.0, "格雷紅茶", null },
                    { "LIKEFANGTea004", 30.0, 35.0, "仙草甘茶", null },
                    { "LIKEFANGTea005", 30.0, 35.0, "大禹嶺清茶", null },
                    { "LIKEFANGTea006", 25.0, 30.0, "斯里蘭卡紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "LIKEFANGThickMilkCover",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LIKEFANGThickMilkCover006", 65.0, 75.0, "厚奶蓋鮮奶茶", null },
                    { "LIKEFANGThickMilkCover008", 0.0, 85.0, "厚奶蓋濃情可可", null },
                    { "LIKEFANGThickMilkCover007", 55.0, 65.0, "厚奶蓋黑糖珍奶", null },
                    { "LIKEFANGThickMilkCover009", 0.0, 85.0, "厚奶蓋靜岡抹茶", null },
                    { "LIKEFANGThickMilkCover005", 60.0, 70.0, "厚奶蓋奶茶", null },
                    { "LIKEFANGThickMilkCover003", 50.0, 55.0, "厚奶蓋青茶", null },
                    { "LIKEFANGThickMilkCover001", 45.0, 50.0, "厚奶蓋紅茶", null },
                    { "LIKEFANGThickMilkCover004", 50.0, 55.0, "厚奶蓋格雷", null },
                    { "LIKEFANGThickMilkCover002", 45.0, 50.0, "厚奶蓋綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "LaiAncient",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiAncient001", 55.0, 175.0, "手工豆漿", null },
                    { "LaiAncient002", 50.0, 160.0, "熬煮青草茶(不可加料)", null }
                });

            migrationBuilder.InsertData(
                table: "LaiFacia",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiFacia007", 55.0, 70.0, "冬瓜檸檬", null },
                    { "LaiFacia008", 50.0, 70.0, "青草紅茶(不可加料)", null },
                    { "LaiFacia006", 50.0, 70.0, "烏梅紅茶", null },
                    { "LaiFacia005", 55.0, 70.0, "珍珠奶茶", null },
                    { "LaiFacia003", 65.0, 65.0, "太后牛乳", null },
                    { "LaiFacia002", 55.0, 65.0, "豆香紅茶", null },
                    { "LaiFacia001", 35.0, 65.0, "老賴紅茶", null },
                    { "LaiFacia004", 45.0, 60.0, "珍珠紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "LaiIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "LaiIce001", "正常冰" },
                    { "LaiIce002", "少冰" }
                });

            migrationBuilder.InsertData(
                table: "LaiIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "LaiIce003", "微冰" },
                    { "LaiIce004", "去冰" },
                    { "LaiIce005", "完全去冰" }
                });

            migrationBuilder.InsertData(
                table: "LaiMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "LaiMat005", 10.0, "愛玉" },
                    { "LaiMat006", 15.0, "布丁" },
                    { "LaiMat007", 0.0, "無" },
                    { "LaiMat004", 10.0, "椰果" },
                    { "LaiMat002", 20.0, "茶凍" },
                    { "LaiMat001", 10.0, "珍珠" },
                    { "LaiMat003", 10.0, "胚芽" }
                });

            migrationBuilder.InsertData(
                table: "LaiMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiMilkTea008", 0.0, 65.0, "珍珠胚芽奶茶", null },
                    { "LaiMilkTea007", 65.0, 0.0, "布丁綠奶", null },
                    { "LaiMilkTea006", 55.0, 0.0, "珍珠綠奶", null },
                    { "LaiMilkTea005", 0.0, 55.0, "香綠奶茶", null },
                    { "LaiMilkTea009", 0.0, 70.0, "珍珠布丁奶茶", null },
                    { "LaiMilkTea003", 65.0, 0.0, "布丁奶茶", null },
                    { "LaiMilkTea002", 65.0, 0.0, "胚芽奶茶", null },
                    { "LaiMilkTea001", 55.0, 175.0, "招牌奶茶", null },
                    { "LaiMilkTea004", 0.0, 65.0, "椰果奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "LaiOolong",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiOolong001", 35.0, 115.0, "文清烏龍", null },
                    { "LaiOolong002", 40.0, 130.0, "文清冬瓜", null },
                    { "LaiOolong003", 50.0, 160.0, "文清檸檬", null },
                    { "LaiOolong004", 55.0, 175.0, "文清阿梅", null },
                    { "LaiOolong005", 55.0, 0.0, "文清樂多(不可加料)", null }
                });

            migrationBuilder.InsertData(
                table: "LaiQueen",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiQueen001", 65.0, 205.0, "太后冬瓜奶", null },
                    { "LaiQueen002", 65.0, 0.0, "太后香綠奶", null },
                    { "LaiQueen003", 70.0, 0.0, "珍珠太后牛乳", null },
                    { "LaiQueen004", 75.0, 0.0, "布丁太后牛乳", null }
                });

            migrationBuilder.InsertData(
                table: "LaiSesame",
                columns: new[] { "ID", "Money1", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiSesame006", 85.0, "黑芝麻珍珠太后牛乳(不可加料)", null },
                    { "LaiSesame004", 75.0, "黑芝麻胚芽奶茶(不可加料)", null },
                    { "LaiSesame005", 80.0, "黑芝麻太后牛乳(不可加料)", null },
                    { "LaiSesame002", 65.0, "黑芝麻奶茶(不可加料)", null },
                    { "LaiSesame003", 70.0, "黑芝麻珍珠奶茶(不可加料)", null },
                    { "LaiSesame001", 65.0, "黑芝麻豆漿(不可加料)", null }
                });

            migrationBuilder.InsertData(
                table: "LaiSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "LaiSug001", "正常糖" },
                    { "LaiSug002", "半糖" },
                    { "LaiSug003", "微糖" },
                    { "LaiSug004", "一分糖" },
                    { "LaiSug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "LaiTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiTea002", 35.0, 0.0, "茉翠香綠", null },
                    { "LaiTea003", 35.0, 115.0, "青霧綠茶", null },
                    { "LaiTea001", 35.0, 0.0, "四季青茶", null }
                });

            migrationBuilder.InsertData(
                table: "LaiTeaBag",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[] { "LaiTeaBag001", 149.0, "台灣茶后茶包(10入一盒)", null });

            migrationBuilder.InsertData(
                table: "LaiTune",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiTune001", 50.0, 160.0, "青檸紅茶", null },
                    { "LaiTune002", 50.0, 160.0, "青檸青霧綠茶", null },
                    { "LaiTune003", 50.0, 0.0, "青檸香綠茶", null },
                    { "LaiTune004", 50.0, 0.0, "青檸香青茶", null },
                    { "LaiTune005", 60.0, 0.0, "玉檸香綠茶(不可加料)", null },
                    { "LaiTune006", 55.0, 0.0, "樂多香綠茶(不可加料)", null },
                    { "LaiTune007", 55.0, 0.0, "樂多香青茶(不可加料)", null }
                });

            migrationBuilder.InsertData(
                table: "LaiWinterMelon",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "LaiWinterMelon006", 65.0, 0.0, "愛玉冬瓜檸檬", null },
                    { "LaiWinterMelon005", 40.0, 0.0, "冬瓜香綠", null },
                    { "LaiWinterMelon004", 40.0, 0.0, "冬瓜香青", null },
                    { "LaiWinterMelon002", 40.0, 130.0, "冬瓜紅茶", null },
                    { "LaiWinterMelon001", 40.0, 130.0, "熬煮冬瓜茶", null },
                    { "LaiWinterMelon003", 40.0, 130.0, "冬瓜青霧", null }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkCheeseMilkCap",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeaMilkCheeseMilkCap001", 60.0, "紅茶芝芝", null },
                    { "MakeYourOwnBlackTeaMilkCheeseMilkCap002", 60.0, "綠茶芝芝", null },
                    { "MakeYourOwnBlackTeaMilkCheeseMilkCap003", 60.0, "冬瓜芝芝", null },
                    { "MakeYourOwnBlackTeaMilkCheeseMilkCap004", 60.0, "仙草芝芝", null }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkFreshMilkTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeaMilkFreshMilkTea005", 55.0, "炭焙烏龍鮮乳", null },
                    { "MakeYourOwnBlackTeaMilkFreshMilkTea003", 55.0, "茉香綠茶鮮乳", null },
                    { "MakeYourOwnBlackTeaMilkFreshMilkTea004", 55.0, "黑糖冬瓜鮮乳", null },
                    { "MakeYourOwnBlackTeaMilkFreshMilkTea001", 55.0, "古早味紅茶鮮乳(正常甜)", null },
                    { "MakeYourOwnBlackTeaMilkFreshMilkTea002", 55.0, "金典味紅茶鮮乳(微甜)", null }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkFreshSheep",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeaMilkFreshSheep001", 60.0, "古早味紅茶羊乳(正常甜)", null },
                    { "MakeYourOwnBlackTeaMilkFreshSheep002", 60.0, "金典味紅茶羊乳(微甜)", null },
                    { "MakeYourOwnBlackTeaMilkFreshSheep003", 60.0, "茉香綠茶羊乳", null },
                    { "MakeYourOwnBlackTeaMilkFreshSheep004", 60.0, "黑糖冬瓜羊乳", null },
                    { "MakeYourOwnBlackTeaMilkFreshSheep005", 60.0, "炭焙烏龍羊乳", null }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkFreshlySqueezed",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeaMilkFreshlySqueezed003", 45.0, "檸檬茉香綠茶", null },
                    { "MakeYourOwnBlackTeaMilkFreshlySqueezed001", 45.0, "檸檬古早味紅茶", null },
                    { "MakeYourOwnBlackTeaMilkFreshlySqueezed002", 45.0, "檸檬金典味紅茶", null },
                    { "MakeYourOwnBlackTeaMilkFreshlySqueezed004", 45.0, "檸檬黑糖冬瓜", null }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkGoodTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeaMilkGoodTea006", 30.0, "炭焙烏龍茶", null },
                    { "MakeYourOwnBlackTeaMilkGoodTea005", 30.0, "仙草甘茶", null },
                    { "MakeYourOwnBlackTeaMilkGoodTea004", 30.0, "黑糖冬瓜茶", null },
                    { "MakeYourOwnBlackTeaMilkGoodTea002", 30.0, "金典味紅茶 微甜", null },
                    { "MakeYourOwnBlackTeaMilkGoodTea001", 30.0, "古早味紅茶 正常甜", null },
                    { "MakeYourOwnBlackTeaMilkGoodTea003", 30.0, "茉香綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkIce",
                columns: new[] { "ID", "IceName" },
                values: new object[] { "ANiceholidayIce001", "無法調整" });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeaMilkMat001", 40.0, "銀耳晶露(限好茶系列可加)" },
                    { "MakeYourOwnBlackTeaMilkMat002", 5.0, "黑糖珍珠(鮮牛系列)" },
                    { "MakeYourOwnBlackTeaMilkMat003", 0.0, "黑糖珍珠(鮮羊系列)" }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeaMilkMat004", 10.0, "黑糖珍珠(好茶系列)" },
                    { "MakeYourOwnBlackTeaMilkMat005", 0.0, "無" }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkSoyMilk",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ANiWinterMelonTea002", 45.0, "紅茶豆漿", null },
                    { "ANiWinterMelonTea001", 45.0, "冬瓜豆漿", null }
                });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[] { "ANiceholidaySug001", "無法調整" });

            migrationBuilder.InsertData(
                table: "MakeYourOwnBlackTeaMilkbreasts",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "MakeYourOwnBlackTeabreasts001", 60.0, "古早味紅茶牛羊乳", null },
                    { "MakeYourOwnBlackTeabreasts002", 60.0, "金典味紅茶牛羊乳", null }
                });

            migrationBuilder.InsertData(
                table: "MrQueenCoffee",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "MrQueenCoffee001", 35.0, 45.0, "美式咖啡", null },
                    { "MrQueenCoffee002", 50.0, 60.0, "雲朵拿鐵咖啡", null },
                    { "MrQueenCoffee003", 55.0, 65.0, "雲朵香草拿鐵", null },
                    { "MrQueenCoffee004", 55.0, 65.0, "雲朵榛果拿鐵", null },
                    { "MrQueenCoffee005", 55.0, 65.0, "雲朵焦糖拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "MrQueenFive",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "MrQueenFive005", 35.0, 40.0, "話梅綠茶", null },
                    { "MrQueenFive003", 40.0, 50.0, "國王奶綠", null },
                    { "MrQueenFive004", 40.0, 50.0, "養樂多綠茶", null },
                    { "MrQueenFive001", 40.0, 50.0, "珍珠奶茶", null },
                    { "MrQueenFive002", 45.0, 55.0, "布丁奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "MrQueenIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "MrQueenIce001", "正常冰" },
                    { "MrQueenIce002", "少冰" },
                    { "MrQueenIce003", "微冰" },
                    { "MrQueenIce004", "去冰" },
                    { "MrQueenIce005", "溫熱" }
                });

            migrationBuilder.InsertData(
                table: "MrQueenMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "MrQueenMat005", 0.0, "無" },
                    { "MrQueenMat004", 15.0, "統一布丁" },
                    { "MrQueenMat003", 10.0, "燕麥粒" },
                    { "MrQueenMat002", 10.0, "椰果" },
                    { "MrQueenMat001", 10.0, "珍珠" }
                });

            migrationBuilder.InsertData(
                table: "MrQueenMilk",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "MrQueenMilk001", 40.0, 50.0, "國王奶茶", null },
                    { "MrQueenMilk002", 40.0, 50.0, "國王奶綠", null },
                    { "MrQueenMilk003", 40.0, 50.0, "國王烏龍奶綠", null },
                    { "MrQueenMilk004", 40.0, 50.0, "國王奶青", null },
                    { "MrQueenMilk005", 40.0, 50.0, "濃情巧克力奶", null },
                    { "MrQueenMilk006", 40.0, 50.0, "國王燕麥奶", null }
                });

            migrationBuilder.InsertData(
                table: "MrQueenSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "MrQueenSug003", "半糖" },
                    { "MrQueenSug004", "微糖" },
                    { "MrQueenSug001", "全糖" },
                    { "MrQueenSug002", "少糖" },
                    { "MrQueenSug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "MrQueenTallMilk",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "MrQueenTallMilk005", 55.0, 65.0, "濃情巧克力歐蕾", null },
                    { "MrQueenTallMilk003", 55.0, 65.0, "烏龍綠拿鐵", null },
                    { "MrQueenTallMilk004", 55.0, 65.0, "岩山青拿鐵", null },
                    { "MrQueenTallMilk002", 55.0, 65.0, "綠茶拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "MrQueenTallMilk",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[] { "MrQueenTallMilk001", 55.0, 65.0, "紅茶拿鐵", null });

            migrationBuilder.InsertData(
                table: "MrQueenTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "MrQueenTea001", 30.0, 35.0, "國王紅茶", null },
                    { "MrQueenTea002", 30.0, 35.0, "國王綠茶", null },
                    { "MrQueenTea003", 30.0, 35.0, "岩山青茶", null },
                    { "MrQueenTea004", 30.0, 35.0, "焙香烏龍綠", null }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionFruit",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "RestingPavilionFruit009", 65.0, "金橙3Q鮮果茶", null },
                    { "RestingPavilionFruit008", 65.0, "野莓果粒茶", null },
                    { "RestingPavilionFruit007", 65.0, "芒果果粒茶", null },
                    { "RestingPavilionFruit006", 65.0, "鳳梨果粒茶", null },
                    { "RestingPavilionFruit004", 60.0, "霸氣柳橙綠", null },
                    { "RestingPavilionFruit003", 60.0, "霸氣檸檬綠", null },
                    { "RestingPavilionFruit002", 70.0, "葡萄柚綠茶", null },
                    { "RestingPavilionFruit001", 70.0, "爆爆水果茶2.0", null },
                    { "RestingPavilionFruit005", 60.0, "樂活百香綠+話梅", null }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionGlobal",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "RestingPavilionGlobal008", 55.0, "熊貓珍奶", null },
                    { "RestingPavilionGlobal011", 60.0, "手搗芋頭奶綠", null },
                    { "RestingPavilionGlobal010", 55.0, "100分奶茶(粉條+珍珠)", null },
                    { "RestingPavilionGlobal009", 55.0, "小美冰淇淋紅茶", null },
                    { "RestingPavilionGlobal007", 50.0, "經典可可", null },
                    { "RestingPavilionGlobal005", 50.0, "荔枝椰果奶茶", null },
                    { "RestingPavilionGlobal004", 50.0, "經典鐵觀音", null },
                    { "RestingPavilionGlobal003", 50.0, "經典奶綠", null },
                    { "RestingPavilionGlobal002", 50.0, "經典奶茶", null },
                    { "RestingPavilionGlobal001", 50.0, "招牌珍奶", null },
                    { "RestingPavilionGlobal006", 50.0, "泰式奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "RestingPavilionIce005", "完全去冰" },
                    { "RestingPavilionIce001", "正常冰" },
                    { "RestingPavilionIce002", "少冰" },
                    { "RestingPavilionIce003", "微冰" },
                    { "RestingPavilionIce004", "去冰(小碎冰)" }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionLatte",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "RestingPavilionLatte007", 65.0, "泰式拿鐵", null },
                    { "RestingPavilionLatte006", 65.0, "可可拿鐵", null },
                    { "RestingPavilionLatte005", 55.0, "經典拿鐵鐵觀音", null },
                    { "RestingPavilionLatte008", 65.0, "手作綠豆沙牛奶", null },
                    { "RestingPavilionLatte003", 55.0, "經典拿鐵紅茶", null },
                    { "RestingPavilionLatte002", 80.0, "QQ手搗芋頭奶", null },
                    { "RestingPavilionLatte001", 80.0, "手搗芋頭拿鐵", null },
                    { "RestingPavilionLatte004", 55.0, "經典拿鐵翠綠", null },
                    { "RestingPavilionLatte009", 65.0, "珍珠鮮奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "RestingPavilionMat008", 0.0, "無" },
                    { "RestingPavilionMat006", 10.0, "蘆薈" },
                    { "RestingPavilionMat005", 10.0, "茶凍" }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "RestingPavilionMat007", 15.0, "小美冰淇淋(2球)" },
                    { "RestingPavilionMat003", 10.0, "粉條" },
                    { "RestingPavilionMat002", 10.0, "熊貓珍珠" },
                    { "RestingPavilionMat004", 10.0, "荔枝椰果" },
                    { "RestingPavilionMat001", 10.0, "珍珠" }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionMilk",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "RestingPavilionMilk001", 70.0, "珍珠鐵觀音厚奶", null },
                    { "RestingPavilionMilk002", 50.0, "經典厚奶紅茶", null },
                    { "RestingPavilionMilk003", 50.0, "經典厚奶翠綠", null },
                    { "RestingPavilionMilk004", 60.0, "鐵觀音厚奶", null },
                    { "RestingPavilionMilk005", 65.0, "焦糖布蕾厚奶", null }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionMilkCheese",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "RestingPavilionMilkCheese004", 70.0, "蓋士可可", null },
                    { "RestingPavilionMilkCheese003", 60.0, "蓋士鐵觀音", null },
                    { "RestingPavilionMilkCheese001", 50.0, "蓋士紅茶", null },
                    { "RestingPavilionMilkCheese002", 50.0, "蓋士翠綠", null }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionRemember",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "RestingPavilionRemember009", 45.0, "手熬冬瓜茶+珍珠", null },
                    { "RestingPavilionRemember013", 55.0, "蜂蜜檸檬+蘆薈", null },
                    { "RestingPavilionRemember014", 60.0, "養樂多多檸檬綠", null },
                    { "RestingPavilionRemember011", 45.0, "一顆脆梅綠", null },
                    { "RestingPavilionRemember010", 45.0, "手熬冬瓜茶+粉條", null },
                    { "RestingPavilionRemember008", 45.0, "手作綠豆雪沙", null },
                    { "RestingPavilionRemember012", 50.0, "冬瓜尬檸檬", null },
                    { "RestingPavilionRemember006", 35.0, "手熬青茶", null },
                    { "RestingPavilionRemember005", 35.0, "手熬冬瓜茶", null },
                    { "RestingPavilionRemember004", 35.0, "嗡嗡綠茶", null },
                    { "RestingPavilionRemember003", 35.0, "嗡嗡紅茶", null },
                    { "RestingPavilionRemember002", 35.0, "嗡嗡蜜茶", null },
                    { "RestingPavilionRemember001", 50.0, "養樂多多綠", null },
                    { "RestingPavilionRemember007", 40.0, "水水蜜桃青", null }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "RestingPavilionSug001", "全糖" },
                    { "RestingPavilionSug002", "少糖" },
                    { "RestingPavilionSug003", "半糖" },
                    { "RestingPavilionSug004", "微糖" },
                    { "RestingPavilionSug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "RestingPavilionTaiwan",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "RestingPavilionTaiwan005", 40.0, "高山鐵觀音", null },
                    { "RestingPavilionTaiwan004", 30.0, "南投四季春", null },
                    { "RestingPavilionTaiwan003", 30.0, "黃金翠綠", null },
                    { "RestingPavilionTaiwan001", 40.0, "凍頂烏龍", null },
                    { "RestingPavilionTaiwan002", 30.0, "經典紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "RicChewySeries",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicChewySeries001", 60.0, "金桔百QQ", null },
                    { "RicChewySeries002", 60.0, "青清檸香3Q", null },
                    { "RicChewySeries003", 55.0, "府城冬瓜蜜珍珠", null },
                    { "RicChewySeries004", 65.0, "冰梅青翡翠凍", null }
                });

            migrationBuilder.InsertData(
                table: "RicChewySeries",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[] { "RicChewySeries005", 65.0, "柳橙百香綠茶凍", null });

            migrationBuilder.InsertData(
                table: "RicFragrantMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicFragrantMilkTea007", 50.0, 60.0, "醇厚烏龍可可", null },
                    { "RicFragrantMilkTea001", 40.0, 50.0, "英式奶茶", null },
                    { "RicFragrantMilkTea002", 40.0, 50.0, "茉香奶綠", null },
                    { "RicFragrantMilkTea003", 45.0, 55.0, "珍珠奶茶", null },
                    { "RicFragrantMilkTea004", 50.0, 60.0, "炭焙觀音奶茶", null },
                    { "RicFragrantMilkTea005", 50.0, 60.0, "茉香凍‧綠奶茶", null },
                    { "RicFragrantMilkTea006", 50.0, 60.0, "手做布丁奶茶", null },
                    { "RicFragrantMilkTea008", 0.0, 65.0, "五力全開奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "RicMilkCapSpecialBlend",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicMilkCapSpecialBlend005", 75.0, 85.0, "雲朵奶蓋‧日式綠茶", null },
                    { "RicMilkCapSpecialBlend004", 65.0, 75.0, "雲朵奶蓋‧濃醇可可", null },
                    { "RicMilkCapSpecialBlend001", 50.0, 60.0, "雲朵奶蓋‧金蕎麥", null },
                    { "RicMilkCapSpecialBlend002", 55.0, 65.0, "雲朵奶蓋‧厚顏紅", null },
                    { "RicMilkCapSpecialBlend003", 55.0, 65.0, "雲朵奶蓋‧茉香綠", null }
                });

            migrationBuilder.InsertData(
                table: "RicPureThickTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicPureThickTea001", 25.0, 30.0, "黃金蕎麥茶", null },
                    { "RicPureThickTea002", 30.0, 35.0, "厚韻紅茶", null },
                    { "RicPureThickTea003", 30.0, 35.0, "茉香綠茶", null },
                    { "RicPureThickTea004", 30.0, 35.0, "翠韻高山青", null },
                    { "RicPureThickTea005", 35.0, 40.0, "金鳳烏龍茶", null },
                    { "RicPureThickTea006", 40.0, 45.0, "炭焙鐵觀音", null }
                });

            migrationBuilder.InsertData(
                table: "RicRefreshingFruitTea",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicRefreshingFruitTea007", 60.0, "柳橙翡翠", null },
                    { "RicRefreshingFruitTea006", 55.0, "鮮果百香綠", null },
                    { "RicRefreshingFruitTea005", 50.0, "金桔鮮檸", null },
                    { "RicRefreshingFruitTea004", 60.0, "金桔脆梅青", null },
                    { "RicRefreshingFruitTea003", 55.0, "雪花梅子綠", null },
                    { "RicRefreshingFruitTea002", 55.0, "檸檬百香紅", null },
                    { "RicRefreshingFruitTea001", 55.0, "翡翠檸檬", null }
                });

            migrationBuilder.InsertData(
                table: "RicRoyalGradeSpecialBlend",
                columns: new[] { "ID", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicRoyalGradeSpecialBlend001", 60.0, "檸夏冬瓜露", null },
                    { "RicRoyalGradeSpecialBlend002", 60.0, "懷舊蕎麥冬瓜", null },
                    { "RicRoyalGradeSpecialBlend003", 60.0, "蜂蜜烏龍奶茶", null },
                    { "RicRoyalGradeSpecialBlend004", 65.0, "府城冬瓜冰茶", null },
                    { "RicRoyalGradeSpecialBlend005", 90.0, "多多綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "RicSmallFarmerThickBreasts",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicSmallFarmerThickBreasts005", 75.0, 85.0, "小芋園布丁鮮奶", null },
                    { "RicSmallFarmerThickBreasts003", 65.0, 75.0, "鐵觀音小農鮮奶", null },
                    { "RicSmallFarmerThickBreasts004", 70.0, 80.0, "冬瓜珍珠鮮奶", null },
                    { "RicSmallFarmerThickBreasts001", 60.0, 70.0, "紅茶小農鮮奶", null },
                    { "RicSmallFarmerThickBreasts002", 55.0, 65.0, "金蕎麥小農鮮奶", null }
                });

            migrationBuilder.InsertData(
                table: "RicThickMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicThickMilkTea001", 50.0, 60.0, "經典‧厚奶茶", null },
                    { "RicThickMilkTea002", 45.0, 55.0, "金蕎麥‧厚奶茶", null },
                    { "RicThickMilkTea003", 55.0, 65.0, "烏龍‧厚奶茶", null },
                    { "RicThickMilkTea004", 55.0, 65.0, "蜜珍珠‧厚奶茶", null },
                    { "RicThickMilkTea005", 65.0, 75.0, "日式抹茶‧厚奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "RicThickMilkTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "RicThickMilkTea006", 65.0, 75.0, "法式濃情‧厚奶茶", null },
                    { "RicThickMilkTea007", 75.0, 85.0, "小芋園炭焙‧厚奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "RichteaIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "RichteaIce003", "微冰" },
                    { "RichteaIce006", "熱" },
                    { "RichteaIce005", "溫" },
                    { "RichteaIce002", "少冰" },
                    { "RichteaIce001", "正常" },
                    { "RichteaIce004", "去冰" }
                });

            migrationBuilder.InsertData(
                table: "RichteaMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "RichteaMat005", 10.0, "綠茶凍" },
                    { "RichteaMat001", 5.0, "珍珠" },
                    { "RichteaMat002", 10.0, "椰果" },
                    { "RichteaMat003", 15.0, "雙色小芋園" },
                    { "RichteaMat004", 10.0, "手作布丁" },
                    { "RichteaMat006", 0.0, "無" }
                });

            migrationBuilder.InsertData(
                table: "RichteaSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "RichteaSug006", "無糖" },
                    { "RichteaSug005", "一分糖" },
                    { "RichteaSug004", "微糖" },
                    { "RichteaSug003", "半糖" },
                    { "RichteaSug002", "少糖" },
                    { "RichteaSug001", "全糖" }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinHealth",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ShangYulinHealth001", 55.0, "桂圓紅棗茶", null },
                    { "ShangYulinHealth002", 75.0, "桂圓紅棗鮮奶茶", null },
                    { "ShangYulinHealth003", 55.0, "薑軍茶", null },
                    { "ShangYulinHealth004", 75.0, "薑軍鮮奶茶'", null }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "ShangYulinIce001", "正常冰" },
                    { "ShangYulinIce002", "少冰" },
                    { "ShangYulinIce003", "微冰" },
                    { "ShangYulinIce004", "去冰" }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "ShangYulinMat011", 0.0, "無" },
                    { "ShangYulinMat010", 15.0, "布丁" },
                    { "ShangYulinMat009", 15.0, "話梅" },
                    { "ShangYulinMat008", 20.0, "香草冰淇淋" },
                    { "ShangYulinMat007", 20.0, "多多" },
                    { "ShangYulinMat004", 10.0, "手工粉角" },
                    { "ShangYulinMat005", 10.0, "QQ" },
                    { "ShangYulinMat003", 10.0, "仙草凍" },
                    { "ShangYulinMat002", 10.0, "椰果" },
                    { "ShangYulinMat001", 10.0, "珍珠" },
                    { "ShangYulinMat006", 10.0, "太極" }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinMilk",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ShangYulinMilk010", 70.0, "冬瓜鮮奶茶", null },
                    { "ShangYulinMilk016", 70.0, "珍珠鮮奶茶", null },
                    { "ShangYulinMilk015", 75.0, "布丁鮮奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinMilk",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ShangYulinMilk014", 70.0, "椰果鮮奶茶", null },
                    { "ShangYulinMilk013", 70.0, "仙草凍鮮奶茶", null },
                    { "ShangYulinMilk012", 70.0, "手工粉角鮮奶茶", null },
                    { "ShangYulinMilk011", 80.0, "冰淇淋鮮奶茶", null },
                    { "ShangYulinMilk009", 60.0, "冬瓜鮮奶", null },
                    { "ShangYulinMilk001", 60.0, "鼎極鮮奶茶", null },
                    { "ShangYulinMilk007", 60.0, "烏龍鮮奶茶", null },
                    { "ShangYulinMilk006", 60.0, "鮮奶青茶", null },
                    { "ShangYulinMilk005", 60.0, "鮮奶綠茶", null },
                    { "ShangYulinMilk004", 60.0, "鐵觀音鮮奶茶", null },
                    { "ShangYulinMilk003", 60.0, "紅龍鮮奶茶", null },
                    { "ShangYulinMilk002", 70.0, "太極鮮奶茶", null },
                    { "ShangYulinMilk008", 60.0, "美人鮮奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinMountain",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[] { "ShangYulinMountain001", 60.0, "精鐉雨林", null });

            migrationBuilder.InsertData(
                table: "ShangYulinRich",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ShangYulinRich001", 60.0, "雪浮奶紅茶", null },
                    { "ShangYulinRich002", 60.0, "雪浮奶綠茶", null },
                    { "ShangYulinRich003", 60.0, "雪浮奶青茶", null },
                    { "ShangYulinRich004", 60.0, "雪浮奶烏龍茶", null },
                    { "ShangYulinRich005", 60.0, "雪浮奶美人", null }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "ShangYulinSug004", "微糖" },
                    { "ShangYulinSug005", "無糖" },
                    { "ShangYulinSug003", "半糖" },
                    { "ShangYulinSug001", "正常糖" },
                    { "ShangYulinSug002", "少糖" }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ShangYulinTea025", 45.0, "仙草凍青茶", null },
                    { "ShangYulinTea026", 45.0, "仙草凍綠茶", null },
                    { "ShangYulinTea027", 45.0, "仙草凍烏龍茶", null },
                    { "ShangYulinTea028", 45.0, "仙草凍冬瓜茶", null },
                    { "ShangYulinTea029", 45.0, "太極紅茶", null },
                    { "ShangYulinTea030", 45.0, "太極青茶", null },
                    { "ShangYulinTea031", 45.0, "太極綠茶", null },
                    { "ShangYulinTea032", 45.0, "太極烏龍茶", null },
                    { "ShangYulinTea033", 45.0, "太極冬瓜茶", null },
                    { "ShangYulinTea034", 45.0, "椰果紅茶", null },
                    { "ShangYulinTea035", 45.0, "椰果青茶", null },
                    { "ShangYulinTea036", 45.0, "椰果綠茶", null },
                    { "ShangYulinTea037", 45.0, "椰果烏龍茶", null },
                    { "ShangYulinTea038", 45.0, "椰果冬瓜茶", null },
                    { "ShangYulinTea039", 45.0, "珍珠紅茶", null },
                    { "ShangYulinTea040", 45.0, "珍珠青茶", null },
                    { "ShangYulinTea041", 45.0, "珍珠綠茶", null },
                    { "ShangYulinTea042", 45.0, "珍珠烏龍茶", null }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ShangYulinTea043", 45.0, "珍珠冬瓜茶", null },
                    { "ShangYulinTea024", 45.0, "仙草凍紅茶", null },
                    { "ShangYulinTea022", 55.0, "冰淇淋烏龍茶", null },
                    { "ShangYulinTea023", 55.0, "冰淇淋冬瓜茶", null },
                    { "ShangYulinTea009", 45.0, "冬瓜綠茶", null },
                    { "ShangYulinTea002", 50.0, "布丁紅茶", null },
                    { "ShangYulinTea003", 50.0, "布丁綠茶", null },
                    { "ShangYulinTea004", 50.0, "布丁青茶", null },
                    { "ShangYulinTea005", 50.0, "布丁烏龍茶", null },
                    { "ShangYulinTea006", 55.0, "脆梅綠茶", null },
                    { "ShangYulinTea007", 35.0, "冬瓜茶", null },
                    { "ShangYulinTea008", 45.0, "冬瓜青茶", null },
                    { "ShangYulinTea021", 55.0, "冰淇淋綠茶", null },
                    { "ShangYulinTea010", 55.0, "黃金多多綠", null },
                    { "ShangYulinTea011", 60.0, "檸檬紅茶", null },
                    { "ShangYulinTea012", 60.0, "檸檬青茶", null },
                    { "ShangYulinTea013", 60.0, "檸檬綠茶", null },
                    { "ShangYulinTea014", 60.0, "檸檬冬瓜茶", null },
                    { "ShangYulinTea015", 60.0, "香橙青茶", null },
                    { "ShangYulinTea016", 60.0, "香橙綠茶", null },
                    { "ShangYulinTea017", 60.0, "葡萄柚青茶", null },
                    { "ShangYulinTea018", 60.0, "葡萄柚綠茶", null },
                    { "ShangYulinTea019", 55.0, "冰淇淋紅茶", null },
                    { "ShangYulinTea020", 55.0, "冰淇淋青茶", null },
                    { "ShangYulinTea001", 50.0, "布丁冬瓜茶", null }
                });

            migrationBuilder.InsertData(
                table: "ShangYulinTop",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "ShangYulinTop008", 35.0, "青龍茗茶", null },
                    { "ShangYulinTop006", 35.0, "紅龍茗茶", null },
                    { "ShangYulinTop007", 35.0, "綠龍茗茶", null },
                    { "ShangYulinTop005", 35.0, "東方美人", null },
                    { "ShangYulinTop002", 35.0, "上宇林紅茶", null },
                    { "ShangYulinTop003", 35.0, "三窨花綠茶", null },
                    { "ShangYulinTop001", 35.0, "上宇林青茶", null },
                    { "ShangYulinTop004", 35.0, "蟲蝕烏龍茶", null }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaCorridor",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "SunriseTeaCorridor008", 45.0, "東方美人", null },
                    { "SunriseTeaCorridor007", 45.0, "焙香鐵觀音", null },
                    { "SunriseTeaCorridor005", 35.0, "雲霧烏龍茶", null },
                    { "SunriseTeaCorridor006", 45.0, "台茶12金萱", null },
                    { "SunriseTeaCorridor003", 30.0, "四季春青茶", null },
                    { "SunriseTeaCorridor002", 30.0, "春摘綠茶", null },
                    { "SunriseTeaCorridor001", 30.0, "日出璞玉紅茶", null },
                    { "SunriseTeaCorridor004", 35.0, "極上焙茶", null }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaFresh",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[] { "SunriseTeaFresh008", 50.0, "葡萄柚美麗綠茶", null });

            migrationBuilder.InsertData(
                table: "SunriseTeaFresh",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "SunriseTeaFresh012", 55.0, "真的養樂多青茶", null },
                    { "SunriseTeaFresh013", 60.0, "黃金蜜香柚子茶", null },
                    { "SunriseTeaFresh010", 60.0, "蔗香青茶", null },
                    { "SunriseTeaFresh009", 50.0, "葡萄柚美麗青茶", null },
                    { "SunriseTeaFresh007", 50.0, "鮮榨檸檬青茶", null },
                    { "SunriseTeaFresh011", 55.0, "真的養樂多綠茶", null },
                    { "SunriseTeaFresh005", 50.0, "黃金芒果青茶", null },
                    { "SunriseTeaFresh004", 50.0, "黃金芒果綠茶", null },
                    { "SunriseTeaFresh003", 50.0, "黃金芒果烏龍茶", null },
                    { "SunriseTeaFresh002", 50.0, "鮮粒百香青茶", null },
                    { "SunriseTeaFresh001", 50.0, "鮮粒百香綠茶", null },
                    { "SunriseTeaFresh006", 50.0, "鮮榨檸檬綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaHealthy",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "SunriseTeaHealthy010", 65.0, "紫玫瑰荔枝凍飲", null },
                    { "SunriseTeaHealthy009", 65.0, "養樂多百香", null },
                    { "SunriseTeaHealthy008", 65.0, "養樂多檸檬", null },
                    { "SunriseTeaHealthy006", 55.0, "鮮榨檸檬蜜", null },
                    { "SunriseTeaHealthy007", 60.0, "蔗香鮮榨檸檬", null },
                    { "SunriseTeaHealthy004", 55.0, "鮮粒百香QQ", null },
                    { "SunriseTeaHealthy003", 45.0, "信義梅子露", null },
                    { "SunriseTeaHealthy002", 45.0, "鮮榨檸檬冬瓜", null },
                    { "SunriseTeaHealthy001", 30.0, "秘釀冬瓜茶", null },
                    { "SunriseTeaHealthy005", 55.0, "黃金芒果QQ", null }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "SunriseTeaIce001", "正常冰" },
                    { "SunriseTeaIce002", "少冰" },
                    { "SunriseTeaIce003", "微冰" },
                    { "SunriseTeaIce004", "去冰" }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "SunriseTeaMat008", 10.0, "QQ" },
                    { "SunriseTeaMat011", 0.0, "無" },
                    { "SunriseTeaMat010", 15.0, "芋泥 " },
                    { "SunriseTeaMat009", 10.0, "紅豆" },
                    { "SunriseTeaMat007", 10.0, "布丁" },
                    { "SunriseTeaMat001", 5.0, "黑珍珠" },
                    { "SunriseTeaMat005", 10.0, "椰果" },
                    { "SunriseTeaMat004", 10.0, "蒟蒻晶球" },
                    { "SunriseTeaMat003", 10.0, "太極珍珠" },
                    { "SunriseTeaMat002", 5.0, "仙草凍" },
                    { "SunriseTeaMat006", 10.0, "粉粿 " }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaMilk",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "SunriseTeaMilk013", 55.0, "四季春奶蓋", null },
                    { "SunriseTeaMilk012", 50.0, "春摘奶綠", null },
                    { "SunriseTeaMilk011", 55.0, "手作芋泥奶茶", null },
                    { "SunriseTeaMilk010", 60.0, "莊園可可", null },
                    { "SunriseTeaMilk009", 50.0, "極上特選烤奶", null }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaMilk",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "SunriseTeaMilk008", 55.0, "Q嫩布丁奶茶", null },
                    { "SunriseTeaMilk005", 45.0, "日不落經典奶茶", null },
                    { "SunriseTeaMilk006", 50.0, "日不落珍珠奶茶", null },
                    { "SunriseTeaMilk014", 55.0, "雲霧烏龍奶蓋", null },
                    { "SunriseTeaMilk004", 60.0, "烏龍奶三寶(椰果+粉粿+珍珠)", null },
                    { "SunriseTeaMilk003", 60.0, "紅豆粉粿珍奶", null },
                    { "SunriseTeaMilk002", 65.0, "太極粉粿珍奶", null },
                    { "SunriseTeaMilk001", 55.0, "太極珍珠奶茶", null },
                    { "SunriseTeaMilk007", 50.0, "雲霧烏龍奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "SunriseTeaSug006", "無糖" },
                    { "SunriseTeaSug003", "微糖" },
                    { "SunriseTeaSug001", "正常糖" },
                    { "SunriseTeaSug002", "半糖" }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaTeaLatte",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "SunriseTeaTeaLatte007", 60.0, "手工仙草凍鮮奶", null },
                    { "SunriseTeaTeaLatte001", 60.0, "珍珠紅茶拿鐵", null },
                    { "SunriseTeaTeaLatte002", 60.0, "熟成紅茶拿鐵", null },
                    { "SunriseTeaTeaLatte003", 60.0, "春摘綠茶拿鐵", null },
                    { "SunriseTeaTeaLatte004", 65.0, "極上焙茶拿鐵", null },
                    { "SunriseTeaTeaLatte005", 65.0, "鐵觀音茶拿鐵", null },
                    { "SunriseTeaTeaLatte006", 65.0, "莊園可可拿鐵", null },
                    { "SunriseTeaTeaLatte008", 75.0, "黑糖珍珠鮮奶", null },
                    { "SunriseTeaTeaLatte009", 85.0, "芋泥珍珠拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "SunriseTeaThickTeaLatte",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "SunriseTeaThickTeaLatte002", 70.0, "熟成厚茶拿鐵", null },
                    { "SunriseTeaThickTeaLatte001", 70.0, "太極厚茶拿鐵", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalChew",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalChew013", 0.0, 45.0, 0.0, "愛玉冰茶", null },
                    { "TeasOriginalChew014", 0.0, 50.0, 0.0, "布丁奶茶", null },
                    { "TeasOriginalChew015", 0.0, 55.0, 0.0, "檸檬愛玉", null },
                    { "TeasOriginalChew016", 0.0, 45.0, 0.0, "仙草凍奶茶", null },
                    { "TeasOriginalChew012", 0.0, 45.0, 0.0, "冬瓜愛玉", null },
                    { "TeasOriginalChew018", 0.0, 45.0, 0.0, "圓圓奶茶", null },
                    { "TeasOriginalChew019", 0.0, 60.0, 0.0, "圓圓鮮奶茶", null },
                    { "TeasOriginalChew020", 0.0, 70.0, 0.0, "焦糖布蕾珍奶", null },
                    { "TeasOriginalChew017", 0.0, 60.0, 0.0, "奶茶三兄弟", null },
                    { "TeasOriginalChew011", 0.0, 45.0, 75.0, "椰果咖啡凍奶茶", null },
                    { "TeasOriginalChew010", 0.0, 45.0, 75.0, "椰果奶茶", null },
                    { "TeasOriginalChew009", 0.0, 45.0, 75.0, "雙Q奶茶", null },
                    { "TeasOriginalChew008", 0.0, 45.0, 75.0, "雙珠奶綠", null },
                    { "TeasOriginalChew007", 0.0, 45.0, 75.0, "雙珠奶茶", null },
                    { "TeasOriginalChew006", 35.0, 45.0, 75.0, "小珍珠奶綠", null },
                    { "TeasOriginalChew005", 35.0, 45.0, 75.0, "小珍珠奶茶", null },
                    { "TeasOriginalChew004", 35.0, 45.0, 75.0, "波霸奶綠", null },
                    { "TeasOriginalChew003", 35.0, 45.0, 75.0, "波霸奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalChew",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalChew002", 0.0, 45.0, 75.0, "蜂蜜蘆薈", null },
                    { "TeasOriginalChew001", 0.0, 60.0, 0.0, "紅茶三兄弟", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalFruit",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalFruit012", 0.0, 60.0, 0.0, "鮮葡萄柚綠茶", null },
                    { "TeasOriginalFruit011", 0.0, 50.0, 80.0, "金桔檸檬", null },
                    { "TeasOriginalFruit010", 0.0, 50.0, 80.0, "百香紅茶", null },
                    { "TeasOriginalFruit009", 0.0, 50.0, 80.0, "百香綠茶", null },
                    { "TeasOriginalFruit008", 0.0, 50.0, 80.0, "港式凍檸茶", null },
                    { "TeasOriginalFruit007", 0.0, 55.0, 0.0, "檸檬多多", null },
                    { "TeasOriginalFruit013", 0.0, 60.0, 0.0, "鮮柳橙綠茶", null },
                    { "TeasOriginalFruit005", 0.0, 50.0, 80.0, "蜂蜜檸檬", null },
                    { "TeasOriginalFruit004", 0.0, 50.0, 80.0, "冬瓜檸檬", null },
                    { "TeasOriginalFruit003", 0.0, 50.0, 0.0, "情人茶", null },
                    { "TeasOriginalFruit002", 0.0, 45.0, 75.0, "檸檬汁", null },
                    { "TeasOriginalFruit001", 0.0, 45.0, 75.0, "鮮桔茶", null },
                    { "TeasOriginalFruit006", 0.0, 45.0, 0.0, "檸檬梅子", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalHot",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalHot010", 50.0, 0.0, 0.0, "金牌熱咖啡", null },
                    { "TeasOriginalHot009", 45.0, 0.0, 0.0, "熱阿華田", null },
                    { "TeasOriginalHot007", 45.0, 50.0, 0.0, "桂圓奶茶", null },
                    { "TeasOriginalHot006", 45.0, 55.0, 0.0, "薑汁熱鮮奶", null },
                    { "TeasOriginalHot008", 50.0, 0.0, 0.0, "熱巧克力可可", null },
                    { "TeasOriginalHot004", 40.0, 45.0, 0.0, "桂圓薑母", null },
                    { "TeasOriginalHot003", 35.0, 40.0, 0.0, "黑糖薑茶", null },
                    { "TeasOriginalHot002", 45.0, 0.0, 0.0, "熱桔茶", null },
                    { "TeasOriginalHot001", 45.0, 0.0, 0.0, "熱黑糖奶茶", null },
                    { "TeasOriginalHot005", 40.0, 45.0, 0.0, "桂圓紅棗", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "TeasOriginalIce001", "正常冰" },
                    { "TeasOriginalIce002", "少冰" },
                    { "TeasOriginalIce003", "微冰" },
                    { "TeasOriginalIce004", "去冰/薄冰" }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalJapan",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalJapan001", 0.0, 50.0, 0.0, "靜岡抹茶拿鐵", null },
                    { "TeasOriginalJapan002", 0.0, 60.0, 0.0, "靜岡抹茶波霸冰淇淋", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "TeasOriginalMat007", 10.0, "雙Q" },
                    { "TeasOriginalMat011", 0.0, "無" },
                    { "TeasOriginalMat009", 15.0, "布丁" },
                    { "TeasOriginalMat008", 15.0, "愛玉" },
                    { "TeasOriginalMat006", 10.0, "椰果" },
                    { "TeasOriginalMat010", 15.0, "圓圓(芋圓+地瓜圓)" },
                    { "TeasOriginalMat004", 10.0, "蘆薈" },
                    { "TeasOriginalMat003", 10.0, "仙草凍" },
                    { "TeasOriginalMat002", 20.0, "小珍珠" },
                    { "TeasOriginalMat001", 10.0, "波霸" },
                    { "TeasOriginalMat005", 10.0, "咖啡凍" }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalMilk",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalMilk010", 0.0, 60.0, 0.0, "波霸綠茶拿鐵", null },
                    { "TeasOriginalMilk009", 0.0, 60.0, 0.0, "波霸紅茶拿鐵", null },
                    { "TeasOriginalMilk008", 0.0, 50.0, 80.0, "黑糖鮮奶茶", null },
                    { "TeasOriginalMilk007", 0.0, 55.0, 0.0, "鮮奶仙草凍", null },
                    { "TeasOriginalMilk006", 0.0, 50.0, 80.0, "冬瓜鮮奶", null },
                    { "TeasOriginalMilk005", 0.0, 50.0, 80.0, "鐵觀音拿鐵", null },
                    { "TeasOriginalMilk004", 0.0, 50.0, 80.0, "紅茶拿鐵", null },
                    { "TeasOriginalMilk003", 0.0, 50.0, 80.0, "綠茶拿鐵", null },
                    { "TeasOriginalMilk002", 0.0, 50.0, 0.0, "芝士奶蓋綠", null },
                    { "TeasOriginalMilk001", 0.0, 50.0, 0.0, "芝士奶蓋紅", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalMilkAroma",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalMilkAroma010", 0.0, 50.0, 0.0, "金牌冰咖啡", null },
                    { "TeasOriginalMilkAroma009", 0.0, 50.0, 0.0, "冰淇淋紅茶", null },
                    { "TeasOriginalMilkAroma007", 0.0, 45.0, 75.0, "阿華田", null },
                    { "TeasOriginalMilkAroma006", 0.0, 50.0, 80.0, "巧克力可可", null },
                    { "TeasOriginalMilkAroma008", 0.0, 50.0, 80.0, "焦糖奶茶", null },
                    { "TeasOriginalMilkAroma004", 0.0, 45.0, 0.0, "芋香奶茶", null },
                    { "TeasOriginalMilkAroma003", 25.0, 35.0, 65.0, "烏龍奶茶", null },
                    { "TeasOriginalMilkAroma002", 25.0, 35.0, 65.0, "奶綠", null },
                    { "TeasOriginalMilkAroma001", 25.0, 35.0, 65.0, "奶茶", null },
                    { "TeasOriginalMilkAroma005", 0.0, 45.0, 75.0, "黑糖奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalSpecialBlend",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalSpecialBlend010", 0.0, 50.0, 0.0, "長島冰茶", null },
                    { "TeasOriginalSpecialBlend009", 0.0, 50.0, 0.0, "海尼根綠茶", null },
                    { "TeasOriginalSpecialBlend007", 0.0, 50.0, 0.0, "芒果綠茶", null },
                    { "TeasOriginalSpecialBlend006", 0.0, 40.0, 0.0, "綠茶多多", null },
                    { "TeasOriginalSpecialBlend008", 0.0, 50.0, 0.0, "芒果青茶", null },
                    { "TeasOriginalSpecialBlend004", 0.0, 40.0, 70.0, "蜂蜜綠茶", null },
                    { "TeasOriginalSpecialBlend003", 0.0, 40.0, 70.0, "蜂蜜茶", null },
                    { "TeasOriginalSpecialBlend002", 0.0, 40.0, 65.0, "梅子紅茶", null },
                    { "TeasOriginalSpecialBlend001", 0.0, 40.0, 65.0, "梅子綠茶", null },
                    { "TeasOriginalSpecialBlend005", 0.0, 40.0, 70.0, "蜂蜜紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "TeasOriginalSug001", "正常糖" },
                    { "TeasOriginalSug002", "少糖" },
                    { "TeasOriginalSug003", "半糖" },
                    { "TeasOriginalSug004", "微糖" },
                    { "TeasOriginalSug005", "無糖" }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalTea",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalTea008", 25.0, 30.0, 50.0, "鐵觀音烏龍茶", null },
                    { "TeasOriginalTea011", 30.0, 35.0, 55.0, "洛神花茶", null },
                    { "TeasOriginalTea010", 30.0, 35.0, 55.0, "古早味冬瓜", null },
                    { "TeasOriginalTea012", 25.0, 30.0, 50.0, "仙草干茶", null },
                    { "TeasOriginalTea007", 25.0, 30.0, 50.0, "烏龍青茶", null },
                    { "TeasOriginalTea009", 30.0, 35.0, 55.0, "冬瓜青茶", null },
                    { "TeasOriginalTea005", 25.0, 30.0, 50.0, "高纖綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "TeasOriginalTea",
                columns: new[] { "ID", "Money", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "TeasOriginalTea004", 20.0, 25.0, 45.0, "炭焙麥茶", null },
                    { "TeasOriginalTea003", 20.0, 25.0, 45.0, "古早味紅茶", null },
                    { "TeasOriginalTea002", 20.0, 25.0, 45.0, "伯爵紅茶", null },
                    { "TeasOriginalTea001", 25.0, 30.0, 50.0, "阿里山香片", null },
                    { "TeasOriginalTea006", 25.0, 30.0, 50.0, "文山青茶", null }
                });

            migrationBuilder.InsertData(
                table: "WanboFeatured",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WanboFeatured005", 30.0, 35.0, "金萱青茶", null },
                    { "WanboFeatured004", 30.0, 35.0, "麗雅烏龍", null },
                    { "WanboFeatured006", 30.0, 35.0, "烏龍鐵觀音", null },
                    { "WanboFeatured002", 30.0, 35.0, "普通紅茶", null },
                    { "WanboFeatured001", 30.0, 35.0, "島嶼紅茶", null },
                    { "WanboFeatured003", 30.0, 35.0, "宣橋綠茶", null }
                });

            migrationBuilder.InsertData(
                table: "WanboFruit",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WanboFruit001", 50.0, 60.0, "島嶼檸檬茶王", null },
                    { "WanboFruit002", 65.0, 75.0, "白柚烏龍", null },
                    { "WanboFruit003", 65.0, 75.0, "白柚翡翠", null },
                    { "WanboFruit004", 65.0, 75.0, "白柚金萱", null },
                    { "WanboFruit005", 50.0, 60.0, "紅蘋島嶼", null },
                    { "WanboFruit006", 50.0, 60.0, "埔里甘蔗青", null },
                    { "WanboFruit007", 50.0, 60.0, "翠涎香檸綠", null },
                    { "WanboFruit008", 50.0, 60.0, "大青梅果綠", null },
                    { "WanboFruit009", 50.0, 60.0, "蔗香煙燻烏梅(茶)", null },
                    { "WanboFruit010", 55.0, 65.0, "甘蔗檸檬", null }
                });

            migrationBuilder.InsertData(
                table: "WanboHandPath",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WanboHandPath005", 45.0, 55.0, "杏花雨露(糖固)(茶)", null },
                    { "WanboHandPath003", 45.0, 50.0, "金萱珍波粉", null },
                    { "WanboHandPath004", 50.0, 60.0, "金牌愛玉檸檬(茶)", null },
                    { "WanboHandPath001", 45.0, 50.0, "蜂蜜金萱", null },
                    { "WanboHandPath002", 45.0, 50.0, "蜂蜜麗雅", null }
                });

            migrationBuilder.InsertData(
                table: "WanboIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "WanboIce001", "正常冰" },
                    { "WanboIce002", "少冰" },
                    { "WanboIce003", "微冰" },
                    { "WanboIce004", "去冰" },
                    { "WanboIce005", "溫熱" }
                });

            migrationBuilder.InsertData(
                table: "WanboMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "WanboMat010", 0.0, "無" },
                    { "WanboMat009", 15.0, "換購燕麥奶" },
                    { "WanboMat008", 15.0, "紅白小湯圓" },
                    { "WanboMat007", 15.0, "珍波粉" },
                    { "WanboMat006", 15.0, "粉粿" },
                    { "WanboMat004", 10.0, "小珍珠" },
                    { "WanboMat003", 10.0, "波霸" },
                    { "WanboMat002", 10.0, "芋園" },
                    { "WanboMat001", 10.0, "愛玉" },
                    { "WanboMat005", 10.0, "杏仁凍" }
                });

            migrationBuilder.InsertData(
                table: "WanboMilKTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[] { "WanboMilKTea001", 55.0, 65.0, "蘭葉那堤", null });

            migrationBuilder.InsertData(
                table: "WanboMilKTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WanboMilKTea002", 50.0, 60.0, "鐵觀音那堤", null },
                    { "WanboMilKTea003", 50.0, 60.0, "茉莉那堤", null },
                    { "WanboMilKTea004", 65.0, 0.0, "黑糖珍珠鮮奶 (冰固)", null },
                    { "WanboMilKTea005", 65.0, 0.0, "紅豆粉粿鮮奶 (冰固)", null },
                    { "WanboMilKTea006", 70.0, 80.0, "燕麥蘭葉那堤", null }
                });

            migrationBuilder.InsertData(
                table: "WanboMilk",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WanboMilk006", 40.0, 50.0, "宣橋奶綠", null },
                    { "WanboMilk005", 50.0, 60.0, "波霸奶茶", null },
                    { "WanboMilk004", 40.0, 50.0, "鐵觀音奶茶", null },
                    { "WanboMilk002", 40.0, 50.0, "普通奶茶", null },
                    { "WanboMilk001", 40.0, 50.0, "萬波奶茶", null },
                    { "WanboMilk003", 50.0, 60.0, "芋園茉香奶綠", null }
                });

            migrationBuilder.InsertData(
                table: "WanboOld",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WanboOld001", 30.0, 40.0, "永良冬瓜露 (糖固)", null },
                    { "WanboOld002", 35.0, 45.0, "冬瓜金萱青", null },
                    { "WanboOld003", 50.0, 60.0, "冬瓜鮮奶", null },
                    { "WanboOld004", 40.0, 50.0, "冬瓜檸檬", null }
                });

            migrationBuilder.InsertData(
                table: "WanboSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "WanboSug006", "無糖" },
                    { "WanboSug005", "微微糖" },
                    { "WanboSug004", "微糖" },
                    { "WanboSug003", "半糖" },
                    { "WanboSug002", "少糖" },
                    { "WanboSug001", "正常糖" }
                });

            migrationBuilder.InsertData(
                table: "WanboWinter",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WanboWinter010", 0.0, 60.0, "薑汁紅白小湯圓 (冬至上市)", null },
                    { "WanboWinter009", 0.0, 50.0, "薑汁撞奶", null },
                    { "WanboWinter008", 0.0, 50.0, "薑汁紅茶", null },
                    { "WanboWinter007", 0.0, 45.0, "黑糖薑茶", null },
                    { "WanboWinter006", 65.0, 75.0, "春橙愛玉 (茶)", null },
                    { "WanboWinter002", 75.0, 85.0, "芋頭波霸鮮奶 (冰固)", null },
                    { "WanboWinter004", 65.0, 75.0, "春橙翡翠", null },
                    { "WanboWinter003", 75.0, 85.0, "芋芋三混圓 (冰固)", null },
                    { "WanboWinter001", 70.0, 80.0, "芋頭鮮奶 (冰固)", null },
                    { "WanboWinter005", 65.0, 75.0, "春橙烏龍", null }
                });

            migrationBuilder.InsertData(
                table: "WongKeeTeaHouseIce",
                columns: new[] { "ID", "IceName" },
                values: new object[] { "WongKeeTeaHouseIce001", "無法調整" });

            migrationBuilder.InsertData(
                table: "WongKeeTeaHouseMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[] { "WongKeeTeaHouseMat001", 0.0, "無" });

            migrationBuilder.InsertData(
                table: "WongKeeTeaHouseSpecialBlend",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WongKeeTeaHouseSpecialBlend006", 40.0, 50.0, "多多綠", null },
                    { "WongKeeTeaHouseSpecialBlend007", 40.0, 50.0, "多多紅", null },
                    { "WongKeeTeaHouseSpecialBlend004", 40.0, 50.0, "吾優奶茶", null },
                    { "WongKeeTeaHouseSpecialBlend005", 40.0, 50.0, "豆漿紅茶", null },
                    { "WongKeeTeaHouseSpecialBlend002", 40.0, 50.0, "綠奶茶", null },
                    { "WongKeeTeaHouseSpecialBlend001", 40.0, 50.0, "鮮奶茶", null },
                    { "WongKeeTeaHouseSpecialBlend003", 40.0, 50.0, "烏龍奶茶", null }
                });

            migrationBuilder.InsertData(
                table: "WongKeeTeaHouseSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[] { "WongKeeTeaHouseSug001", "無法調整" });

            migrationBuilder.InsertData(
                table: "WongKeeTeaHouseTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[] { "WongKeeTeaHouseTea006", 25.0, 30.0, "真美麗(紅茶配綠茶=真美麗)", null });

            migrationBuilder.InsertData(
                table: "WongKeeTeaHouseTea",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WongKeeTeaHouseTea001", 25.0, 30.0, "紅茶", null },
                    { "WongKeeTeaHouseTea002", 25.0, 30.0, "綠茶", null },
                    { "WongKeeTeaHouseTea003", 25.0, 30.0, "烏龍茶", null },
                    { "WongKeeTeaHouseTea004", 30.0, 35.0, "冬瓜茶", null },
                    { "WongKeeTeaHouseTea005", 25.0, 30.0, "吾優茶 (烏龍茶配綠茶=吾優)", null }
                });

            migrationBuilder.InsertData(
                table: "WulinFifty",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinFifty028", 80.0, "凍頂碳焙烏龍(重乳輕茶)", null },
                    { "WulinFifty027", 70.0, "凍頂碳焙烏龍(重茶輕乳)", null },
                    { "WulinFifty026", 60.0, "凍頂碳焙烏龍(奶蓋微冰)", null },
                    { "WulinFifty022", 60.0, "冬瓜風味茶(奶蓋微冰)", null },
                    { "WulinFifty024", 80.0, "冬瓜風味茶(重乳輕茶)", null },
                    { "WulinFifty023", 70.0, "冬瓜風味茶(重茶輕乳)", null },
                    { "WulinFifty029", 40.0, "翡冷綠(研萃手沖)", null },
                    { "WulinFifty025", 40.0, "凍頂碳焙烏龍(研萃手沖)", null },
                    { "WulinFifty030", 60.0, "翡冷綠(奶蓋微冰)", null },
                    { "WulinFifty036", 80.0, "翠玉迎春(重乳輕茶)", null },
                    { "WulinFifty032", 80.0, "翡冷綠(重乳輕茶)", null },
                    { "WulinFifty033", 40.0, "翠玉迎春(研萃手沖)", null },
                    { "WulinFifty034", 60.0, "翠玉迎春(奶蓋微冰)", null },
                    { "WulinFifty035", 70.0, "翠玉迎春(重茶輕乳)", null },
                    { "WulinFifty037", 50.0, "小山抹茶(研萃手沖)", null },
                    { "WulinFifty038", 65.0, "小山抹茶(奶蓋微冰)", null },
                    { "WulinFifty039", 75.0, "小山抹茶(重茶輕乳)", null },
                    { "WulinFifty040", 85.0, "小山抹茶(重乳輕茶)", null },
                    { "WulinFifty031", 70.0, "翡冷綠(重茶輕乳)", null },
                    { "WulinFifty021", 35.0, "冬瓜風味茶(研萃手沖)", null },
                    { "WulinFifty006", 60.0, "杉夏露高山青茶(奶蓋微冰)", null },
                    { "WulinFifty019", 70.0, "霂灆紅茶(重茶輕乳)", null },
                    { "WulinFifty001", 35.0, "凍頂山烏龍茶(研萃手沖)", null },
                    { "WulinFifty002", 60.0, "凍頂山烏龍茶(奶蓋微冰)", null },
                    { "WulinFifty003", 70.0, "凍頂山烏龍茶(重茶輕乳)", null },
                    { "WulinFifty004", 80.0, "凍頂山烏龍茶(重乳輕茶)", null },
                    { "WulinFifty020", 80.0, "霂灆紅茶(重乳輕茶)", null },
                    { "WulinFifty007", 70.0, "杉夏露高山青茶(重茶輕乳)", null },
                    { "WulinFifty008", 80.0, "杉夏露高山青茶(重乳輕茶)", null },
                    { "WulinFifty009", 35.0, "臺灣四季春(研萃手沖)", null },
                    { "WulinFifty005", 35.0, "杉夏露高山青茶(研萃手沖)", null },
                    { "WulinFifty011", 70.0, "臺灣四季春(重茶輕乳)", null },
                    { "WulinFifty012", 80.0, "臺灣四季春(重乳輕茶)", null },
                    { "WulinFifty013", 35.0, "金萱烏龍(研萃手沖)", null },
                    { "WulinFifty014", 60.0, "金萱烏龍(奶蓋微冰)", null },
                    { "WulinFifty015", 70.0, "金萱烏龍(重茶輕乳)", null },
                    { "WulinFifty016", 80.0, "金萱烏龍(重乳輕茶)", null }
                });

            migrationBuilder.InsertData(
                table: "WulinFifty",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinFifty017", 35.0, "霂灆紅茶(研萃手沖)", null },
                    { "WulinFifty018", 60.0, "霂灆紅茶(奶蓋微冰)", null },
                    { "WulinFifty010", 60.0, "臺灣四季春(奶蓋微冰)", null }
                });

            migrationBuilder.InsertData(
                table: "WulinFruit",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinFruit021", 90.0, "蘋果皇金磚莎莎", null },
                    { "WulinFruit014", 70.0, "啡香金桔檸檬茶", null },
                    { "WulinFruit015", 70.0, "凍頂金桔檸檬", null },
                    { "WulinFruit016", 70.0, "凍頂檸檬蘆薈", null },
                    { "WulinFruit020", 90.0, "鳳梨皇金磚莎莎", null },
                    { "WulinFruit018", 65.0, "鮮百香果茶", null },
                    { "WulinFruit019", 75.0, "四季春百香蘆薈飲", null },
                    { "WulinFruit012", 65.0, "四季春鳳梨茶", null },
                    { "WulinFruit017", 70.0, "凍頂檸檬晶凍飲", null },
                    { "WulinFruit011", 65.0, "蜜香甘蔗紅", null },
                    { "WulinFruit013", 65.0, "蜜香旺萊紅", null },
                    { "WulinFruit009", 70.0, "杉芭青茶", null },
                    { "WulinFruit008", 75.0, "杉夏露柳橙青", null },
                    { "WulinFruit007", 80.0, "紅柚楊桃露", null },
                    { "WulinFruit006", 80.0, "葡萄柚多多", null },
                    { "WulinFruit005", 80.0, "葡萄柚多酚", null },
                    { "WulinFruit004", 80.0, "柳橙多多檸檬凍飲", null },
                    { "WulinFruit003", 80.0, "金萱鮮橙百香飲", null },
                    { "WulinFruit002", 75.0, "凍頂紅鑽葡萄柚", null },
                    { "WulinFruit001", 80.0, "凍春山", null },
                    { "WulinFruit010", 65.0, "杉夏露甘蔗青", null }
                });

            migrationBuilder.InsertData(
                table: "WulinIce",
                columns: new[] { "ID", "IceName" },
                values: new object[,]
                {
                    { "WulinIce005", "去冰(2%)" },
                    { "WulinIce004", "微冰(20%)" },
                    { "WulinIce001", "全冰(70%)" },
                    { "WulinIce002", "半冰(50%)" },
                    { "WulinIce003", "少冰(40%)" }
                });

            migrationBuilder.InsertData(
                table: "WulinMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "WulinMat011", 15.0, "仙草凍" },
                    { "WulinMat016", 0.0, "無" },
                    { "WulinMat015", 15.0, "乳香鹹奶蓋" },
                    { "WulinMat014", 15.0, "黑白Q" },
                    { "WulinMat013", 15.0, "白木耳" },
                    { "WulinMat012", 15.0, "珍椰Q" },
                    { "WulinMat009", 15.0, "焙茶凍" },
                    { "WulinMat010", 15.0, "蘋果凍" },
                    { "WulinMat007", 10.0, "黑晶晶" },
                    { "WulinMat006", 10.0, "白晶晶" },
                    { "WulinMat005", 10.0, "蘆薈" },
                    { "WulinMat004", 5.0, "甘甜梅" },
                    { "WulinMat003", 5.0, "Q纖果" }
                });

            migrationBuilder.InsertData(
                table: "WulinMat",
                columns: new[] { "ID", "Money", "TeaMaterialName" },
                values: new object[,]
                {
                    { "WulinMat002", 5.0, "椰果" },
                    { "WulinMat001", 5.0, "珍波" },
                    { "WulinMat008", 15.0, "檸檬棟" }
                });

            migrationBuilder.InsertData(
                table: "WulinMaterial",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinMaterial012", 70.0, "鳳梨白木耳飲", null },
                    { "WulinMaterial011", 70.0, "胭脂桂花紅白木耳飲", null },
                    { "WulinMaterial010", 70.0, "甘蔗珍波白木耳飲", null },
                    { "WulinMaterial009", 70.0, "翡冷綠百香Q霸", null },
                    { "WulinMaterial008", 70.0, "凍頂檸檬霸", null },
                    { "WulinMaterial007", 50.0, "冬瓜三兄弟", null },
                    { "WulinMaterial006", 50.0, "銀耳舞Q", null },
                    { "WulinMaterial004", 60.0, "金萱舞凍", null },
                    { "WulinMaterial003", 60.0, "冬瓜仙草皇金磚", null },
                    { "WulinMaterial002", 65.0, "蘋果皇金磚", null },
                    { "WulinMaterial001", 55.0, "焙茶皇金磚", null },
                    { "WulinMaterial005", 50.0, "金萱舞Q", null }
                });

            migrationBuilder.InsertData(
                table: "WulinMilkTea",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinMilkTea009", 65.0, "四季春椰果奶", null },
                    { "WulinMilkTea013", 65.0, "黑糖風味焙茶烤奶", null },
                    { "WulinMilkTea012", 70.0, "阿華田奶茶", null },
                    { "WulinMilkTea011", 65.0, "仙草奶凍", null },
                    { "WulinMilkTea014", 65.0, "抹茶奶茶", null },
                    { "WulinMilkTea010", 65.0, "桂花奶茶", null },
                    { "WulinMilkTea008", 80.0, "泰紅皇金磚", null },
                    { "WulinMilkTea004", 70.0, "碳焙烤茶晶凍奶", null },
                    { "WulinMilkTea006", 70.0, "金萱舞Ｑ醇奶茶", null },
                    { "WulinMilkTea005", 70.0, "碳焙珍波晶凍奶", null },
                    { "WulinMilkTea003", 70.0, "雙焙奶茶皇金磚", null },
                    { "WulinMilkTea002", 65.0, "碳香珍波奶茶", null },
                    { "WulinMilkTea001", 60.0, "霂灆奶茶", null },
                    { "WulinMilkTea007", 65.0, "泰紅", null }
                });

            migrationBuilder.InsertData(
                table: "WulinPurple",
                columns: new[] { "ID", "Money1", "Money2", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinPurple001", 70.0, 0.0, "紫心牛奶", null },
                    { "WulinPurple002", 0.0, 75.0, "珍波紫心牛奶", null },
                    { "WulinPurple003", 0.0, 75.0, "紫芋薯牛奶", null },
                    { "WulinPurple004", 70.0, 0.0, "芋頭牛奶", null },
                    { "WulinPurple005", 0.0, 70.0, "金萱芋頭奶", null },
                    { "WulinPurple006", 0.0, 75.0, "金萱芋頭珍波奶", null }
                });

            migrationBuilder.InsertData(
                table: "WulinSoul",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinSoul010", 75.0, "凍頂檸檬多酚", null },
                    { "WulinSoul008", 60.0, "桂花檸檬露", null },
                    { "WulinSoul007", 60.0, "幼幼班檸檬茶", null },
                    { "WulinSoul006", 70.0, "檸檬宏白木耳飲", null },
                    { "WulinSoul009", 60.0, "冬瓜檸檬", null },
                    { "WulinSoul004", 65.0, "啡香翠玉", null },
                    { "WulinSoul003", 65.0, "啡香紅茶", null }
                });

            migrationBuilder.InsertData(
                table: "WulinSoul",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinSoul002", 65.0, "啡香檸檬", null },
                    { "WulinSoul001", 60.0, "招牌雙茶檸檬 (甜冰固定)", null },
                    { "WulinSoul005", 65.0, "啡香凍頂", null }
                });

            migrationBuilder.InsertData(
                table: "WulinSpecialBlend",
                columns: new[] { "ID", "Money", "Name", "temperature" },
                values: new object[,]
                {
                    { "WulinSpecialBlend013", 60.0, "胭脂桂花紅", null },
                    { "WulinSpecialBlend012", 60.0, "凍頂桂花烏龍", null },
                    { "WulinSpecialBlend011", 60.0, "青梅胭脂紅", null },
                    { "WulinSpecialBlend010", 60.0, "凍頂烏龍梅果", null },
                    { "WulinSpecialBlend009", 60.0, "武仙甘茶", null },
                    { "WulinSpecialBlend007", 60.0, "楊桃烏龍", null },
                    { "WulinSpecialBlend008", 60.0, "武冰綠", null },
                    { "WulinSpecialBlend005", 60.0, "四季荔荔", null },
                    { "WulinSpecialBlend004", 60.0, "茶多多綠茶", null },
                    { "WulinSpecialBlend003", 60.0, "茶多多金萱", null },
                    { "WulinSpecialBlend002", 60.0, "茶多酚綠茶", null },
                    { "WulinSpecialBlend001", 60.0, "茶多酚金萱", null },
                    { "WulinSpecialBlend006", 60.0, "蘋果迎春", null }
                });

            migrationBuilder.InsertData(
                table: "WulinSug",
                columns: new[] { "ID", "SugarName" },
                values: new object[,]
                {
                    { "WulinSug006", "提味(3%)" },
                    { "WulinSug001", "全糖" },
                    { "WulinSug002", "七分(70%)" },
                    { "WulinSug003", "半糖(50%)" },
                    { "WulinSug004", "微糖(30%)" },
                    { "WulinSug005", "一分(10%)" },
                    { "WulinSug007", "無糖(0%)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ANiceholidayIce");

            migrationBuilder.DropTable(
                name: "ANiceholidayMat");

            migrationBuilder.DropTable(
                name: "ANiceholidaySug");

            migrationBuilder.DropTable(
                name: "ANiCheeseMilkCap");

            migrationBuilder.DropTable(
                name: "ANiflavoredTea");

            migrationBuilder.DropTable(
                name: "ANiFreshMilkTea");

            migrationBuilder.DropTable(
                name: "ANiMilkTea");

            migrationBuilder.DropTable(
                name: "ANiOriginalTea");

            migrationBuilder.DropTable(
                name: "ANiTasteTea");

            migrationBuilder.DropTable(
                name: "ANiWinterMelonTea");

            migrationBuilder.DropTable(
                name: "AsherAncient");

            migrationBuilder.DropTable(
                name: "AsherChew");

            migrationBuilder.DropTable(
                name: "AsherFresh");

            migrationBuilder.DropTable(
                name: "AsherIce");

            migrationBuilder.DropTable(
                name: "AsherMat");

            migrationBuilder.DropTable(
                name: "AsherMatcha");

            migrationBuilder.DropTable(
                name: "AsherMilk");

            migrationBuilder.DropTable(
                name: "AsherMilkCover");

            migrationBuilder.DropTable(
                name: "AsherSug");

            migrationBuilder.DropTable(
                name: "AsherSummerSmoothies");

            migrationBuilder.DropTable(
                name: "AsherTaro");

            migrationBuilder.DropTable(
                name: "AsherTea");

            migrationBuilder.DropTable(
                name: "AsherYakult");

            migrationBuilder.DropTable(
                name: "BalCloudcover");

            migrationBuilder.DropTable(
                name: "BalFreshmilktea");

            migrationBuilder.DropTable(
                name: "BalFruity");

            migrationBuilder.DropTable(
                name: "BalHandpath");

            migrationBuilder.DropTable(
                name: "BallsTeaIce");

            migrationBuilder.DropTable(
                name: "BallsTeaMat");

            migrationBuilder.DropTable(
                name: "BallsTeaSug");

            migrationBuilder.DropTable(
                name: "BalMilk");

            migrationBuilder.DropTable(
                name: "BalMilktea");

            migrationBuilder.DropTable(
                name: "BalSnowfungus");

            migrationBuilder.DropTable(
                name: "BalSpecialblend");

            migrationBuilder.DropTable(
                name: "BalTea");

            migrationBuilder.DropTable(
                name: "BalThickslices");

            migrationBuilder.DropTable(
                name: "BalWinterlimited");

            migrationBuilder.DropTable(
                name: "CHAGEIce");

            migrationBuilder.DropTable(
                name: "CHAGEMat");

            migrationBuilder.DropTable(
                name: "CHAGEMilk");

            migrationBuilder.DropTable(
                name: "CHAGEMilkTea");

            migrationBuilder.DropTable(
                name: "CHAGENaigai");

            migrationBuilder.DropTable(
                name: "CHAGEScentedTea");

            migrationBuilder.DropTable(
                name: "CHAGESeasonal");

            migrationBuilder.DropTable(
                name: "CHAGESpecialBlend");

            migrationBuilder.DropTable(
                name: "CHAGESug");

            migrationBuilder.DropTable(
                name: "CHAGETea");

            migrationBuilder.DropTable(
                name: "CHAGETeaGoodMat");

            migrationBuilder.DropTable(
                name: "COMEBUYFreshFruitTea");

            migrationBuilder.DropTable(
                name: "COMEBUYFreshTeaLatte");

            migrationBuilder.DropTable(
                name: "COMEBUYIce");

            migrationBuilder.DropTable(
                name: "COMEBUYMat");

            migrationBuilder.DropTable(
                name: "COMEBUYMilkTeaCocoa");

            migrationBuilder.DropTable(
                name: "COMEBUYOriginalLeaves");

            migrationBuilder.DropTable(
                name: "COMEBUYReally");

            migrationBuilder.DropTable(
                name: "COMEBUYSpecialCoffee");

            migrationBuilder.DropTable(
                name: "COMEBUYSug");

            migrationBuilder.DropTable(
                name: "COMEBUYSummerOnly");

            migrationBuilder.DropTable(
                name: "COMEBUYWinterOnly");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewClassic");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewFreshFruit");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewIce");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewLatte");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewMat");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewMilkTea");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewNaigai");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewOriginalTea");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewSug");

            migrationBuilder.DropTable(
                name: "DaMingJadeDewWinterOnly");

            migrationBuilder.DropTable(
                name: "DedeTeaClassicSpecialties");

            migrationBuilder.DropTable(
                name: "DedeTeaIce");

            migrationBuilder.DropTable(
                name: "DedeTeaMat");

            migrationBuilder.DropTable(
                name: "DedeTeaPrincessofFlowers");

            migrationBuilder.DropTable(
                name: "DedeTeaRoyalchoiceitem");

            migrationBuilder.DropTable(
                name: "DedeTeaRoyalFragrantMilkTea");

            migrationBuilder.DropTable(
                name: "DedeTeaRoyalLatte");

            migrationBuilder.DropTable(
                name: "DedeTeaSug");

            migrationBuilder.DropTable(
                name: "FiftyLanFresh");

            migrationBuilder.DropTable(
                name: "FiftyLanIce");

            migrationBuilder.DropTable(
                name: "FiftyLanLatte");

            migrationBuilder.DropTable(
                name: "FiftyLanMat");

            migrationBuilder.DropTable(
                name: "FiftyLanSeasonal");

            migrationBuilder.DropTable(
                name: "FiftyLanSug");

            migrationBuilder.DropTable(
                name: "FiftyLanTea");

            migrationBuilder.DropTable(
                name: "JinchaWuGoldenFresh");

            migrationBuilder.DropTable(
                name: "JinchaWuGoldenGoodTea");

            migrationBuilder.DropTable(
                name: "JinchaWuIce");

            migrationBuilder.DropTable(
                name: "JinchaWuJinHaomian");

            migrationBuilder.DropTable(
                name: "JinchaWuJinYoumi");

            migrationBuilder.DropTable(
                name: "JinchaWuKimHougong");

            migrationBuilder.DropTable(
                name: "JinchaWuMat");

            migrationBuilder.DropTable(
                name: "JinchaWuQKueh");

            migrationBuilder.DropTable(
                name: "JinchaWuSug");

            migrationBuilder.DropTable(
                name: "LaiAncient");

            migrationBuilder.DropTable(
                name: "LaiFacia");

            migrationBuilder.DropTable(
                name: "LaiIce");

            migrationBuilder.DropTable(
                name: "LaiMat");

            migrationBuilder.DropTable(
                name: "LaiMilkTea");

            migrationBuilder.DropTable(
                name: "LaiOolong");

            migrationBuilder.DropTable(
                name: "LaiQueen");

            migrationBuilder.DropTable(
                name: "LaiSesame");

            migrationBuilder.DropTable(
                name: "LaiSug");

            migrationBuilder.DropTable(
                name: "LaiTea");

            migrationBuilder.DropTable(
                name: "LaiTeaBag");

            migrationBuilder.DropTable(
                name: "LaiTune");

            migrationBuilder.DropTable(
                name: "LaiWinterMelon");

            migrationBuilder.DropTable(
                name: "LIKEFANGBrownSugar");

            migrationBuilder.DropTable(
                name: "LIKEFANGFreshFruit");

            migrationBuilder.DropTable(
                name: "LIKEFANGFreshMilkTea");

            migrationBuilder.DropTable(
                name: "LIKEFANGIce");

            migrationBuilder.DropTable(
                name: "LIKEFANGKitKat");

            migrationBuilder.DropTable(
                name: "LIKEFANGMat");

            migrationBuilder.DropTable(
                name: "LIKEFANGMilkTea");

            migrationBuilder.DropTable(
                name: "LIKEFANGSpecialBlend");

            migrationBuilder.DropTable(
                name: "LIKEFANGSug");

            migrationBuilder.DropTable(
                name: "LIKEFANGTea");

            migrationBuilder.DropTable(
                name: "LIKEFANGThickMilkCover");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkbreasts");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkCheeseMilkCap");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkFreshlySqueezed");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkFreshMilkTea");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkFreshSheep");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkGoodTea");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkIce");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkMat");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkSoyMilk");

            migrationBuilder.DropTable(
                name: "MakeYourOwnBlackTeaMilkSug");

            migrationBuilder.DropTable(
                name: "MrQueenCoffee");

            migrationBuilder.DropTable(
                name: "MrQueenFive");

            migrationBuilder.DropTable(
                name: "MrQueenIce");

            migrationBuilder.DropTable(
                name: "MrQueenMat");

            migrationBuilder.DropTable(
                name: "MrQueenMilk");

            migrationBuilder.DropTable(
                name: "MrQueenSug");

            migrationBuilder.DropTable(
                name: "MrQueenTallMilk");

            migrationBuilder.DropTable(
                name: "MrQueenTea");

            migrationBuilder.DropTable(
                name: "RestingPavilionFruit");

            migrationBuilder.DropTable(
                name: "RestingPavilionGlobal");

            migrationBuilder.DropTable(
                name: "RestingPavilionIce");

            migrationBuilder.DropTable(
                name: "RestingPavilionLatte");

            migrationBuilder.DropTable(
                name: "RestingPavilionMat");

            migrationBuilder.DropTable(
                name: "RestingPavilionMilk");

            migrationBuilder.DropTable(
                name: "RestingPavilionMilkCheese");

            migrationBuilder.DropTable(
                name: "RestingPavilionRemember");

            migrationBuilder.DropTable(
                name: "RestingPavilionSug");

            migrationBuilder.DropTable(
                name: "RestingPavilionTaiwan");

            migrationBuilder.DropTable(
                name: "RicChewySeries");

            migrationBuilder.DropTable(
                name: "RicFragrantMilkTea");

            migrationBuilder.DropTable(
                name: "RichteaIce");

            migrationBuilder.DropTable(
                name: "RichteaMat");

            migrationBuilder.DropTable(
                name: "RichteaSug");

            migrationBuilder.DropTable(
                name: "RicMilkCapSpecialBlend");

            migrationBuilder.DropTable(
                name: "RicPureThickTea");

            migrationBuilder.DropTable(
                name: "RicRefreshingFruitTea");

            migrationBuilder.DropTable(
                name: "RicRoyalGradeSpecialBlend");

            migrationBuilder.DropTable(
                name: "RicSmallFarmerThickBreasts");

            migrationBuilder.DropTable(
                name: "RicThickMilkTea");

            migrationBuilder.DropTable(
                name: "ShangYulinHealth");

            migrationBuilder.DropTable(
                name: "ShangYulinIce");

            migrationBuilder.DropTable(
                name: "ShangYulinMat");

            migrationBuilder.DropTable(
                name: "ShangYulinMilk");

            migrationBuilder.DropTable(
                name: "ShangYulinMountain");

            migrationBuilder.DropTable(
                name: "ShangYulinRich");

            migrationBuilder.DropTable(
                name: "ShangYulinSug");

            migrationBuilder.DropTable(
                name: "ShangYulinTea");

            migrationBuilder.DropTable(
                name: "ShangYulinTop");

            migrationBuilder.DropTable(
                name: "SunriseTeaCorridor");

            migrationBuilder.DropTable(
                name: "SunriseTeaFresh");

            migrationBuilder.DropTable(
                name: "SunriseTeaHealthy");

            migrationBuilder.DropTable(
                name: "SunriseTeaIce");

            migrationBuilder.DropTable(
                name: "SunriseTeaMat");

            migrationBuilder.DropTable(
                name: "SunriseTeaMilk");

            migrationBuilder.DropTable(
                name: "SunriseTeaSug");

            migrationBuilder.DropTable(
                name: "SunriseTeaTeaLatte");

            migrationBuilder.DropTable(
                name: "SunriseTeaThickTeaLatte");

            migrationBuilder.DropTable(
                name: "TeasOriginalChew");

            migrationBuilder.DropTable(
                name: "TeasOriginalFruit");

            migrationBuilder.DropTable(
                name: "TeasOriginalHot");

            migrationBuilder.DropTable(
                name: "TeasOriginalIce");

            migrationBuilder.DropTable(
                name: "TeasOriginalJapan");

            migrationBuilder.DropTable(
                name: "TeasOriginalMat");

            migrationBuilder.DropTable(
                name: "TeasOriginalMilk");

            migrationBuilder.DropTable(
                name: "TeasOriginalMilkAroma");

            migrationBuilder.DropTable(
                name: "TeasOriginalSpecialBlend");

            migrationBuilder.DropTable(
                name: "TeasOriginalSug");

            migrationBuilder.DropTable(
                name: "TeasOriginalTea");

            migrationBuilder.DropTable(
                name: "WanboFeatured");

            migrationBuilder.DropTable(
                name: "WanboFruit");

            migrationBuilder.DropTable(
                name: "WanboHandPath");

            migrationBuilder.DropTable(
                name: "WanboIce");

            migrationBuilder.DropTable(
                name: "WanboMat");

            migrationBuilder.DropTable(
                name: "WanboMilk");

            migrationBuilder.DropTable(
                name: "WanboMilKTea");

            migrationBuilder.DropTable(
                name: "WanboOld");

            migrationBuilder.DropTable(
                name: "WanboSug");

            migrationBuilder.DropTable(
                name: "WanboWinter");

            migrationBuilder.DropTable(
                name: "WongKeeTeaHouseIce");

            migrationBuilder.DropTable(
                name: "WongKeeTeaHouseMat");

            migrationBuilder.DropTable(
                name: "WongKeeTeaHouseSpecialBlend");

            migrationBuilder.DropTable(
                name: "WongKeeTeaHouseSug");

            migrationBuilder.DropTable(
                name: "WongKeeTeaHouseTea");

            migrationBuilder.DropTable(
                name: "WulinFifty");

            migrationBuilder.DropTable(
                name: "WulinFruit");

            migrationBuilder.DropTable(
                name: "WulinIce");

            migrationBuilder.DropTable(
                name: "WulinMat");

            migrationBuilder.DropTable(
                name: "WulinMaterial");

            migrationBuilder.DropTable(
                name: "WulinMilkTea");

            migrationBuilder.DropTable(
                name: "WulinPurple");

            migrationBuilder.DropTable(
                name: "WulinSoul");

            migrationBuilder.DropTable(
                name: "WulinSpecialBlend");

            migrationBuilder.DropTable(
                name: "WulinSug");
        }
    }
}
