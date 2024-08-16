using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatWithFriends.Migrations.Safe
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Safes",
                columns: table => new
                {
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CupCount = table.Column<int>(type: "int", nullable: false),
                    Money = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Money2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeaMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SugarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Safes", x => x.OrderTime);
                });

            migrationBuilder.InsertData(
                table: "Safes",
                columns: new[] { "OrderTime", "CupCount", "IceName", "Money", "Money1", "Money2", "Name", "OrderName", "Shop", "SugarName", "TeaMaterialName", "Total" },
                values: new object[,]
                {
                    { new DateTime(2024, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), 1, "去冰", null, null, "65", "沉香烏龍那提", "弟弟", "波仕-鮮奶茶系列", "半糖", "椰果", "75" },
                    { new DateTime(2024, 2, 13, 13, 28, 29, 0, DateTimeKind.Unspecified), 1, "去冰", null, null, "65", "沉香烏龍那提", "弟弟", "波仕-鮮奶茶系列", "半糖", "椰果", "75" },
                    { new DateTime(2024, 2, 13, 13, 30, 31, 0, DateTimeKind.Unspecified), 1, "去冰", null, null, "65", "沉香烏龍那提", "弟弟", "波仕-鮮奶茶系列", "半糖", "椰果", "75" },
                    { new DateTime(2024, 5, 9, 4, 2, 17, 0, DateTimeKind.Unspecified), 1, "去冰", null, null, "65", "沉香烏龍那提", "弟弟", "波仕-鮮奶茶系列", "半糖", "椰果", "75" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Safes");
        }
    }
}
