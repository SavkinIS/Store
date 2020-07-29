using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Migrations
{
    public partial class Frst_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CODE = table.Column<string>(maxLength: 8, nullable: false),
                    NAME = table.Column<string>(nullable: true),
                    ADDRESS = table.Column<string>(nullable: true),
                    DISCOUNT = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ORDER_ID = table.Column<Guid>(nullable: false),
                    ITEM_ID = table.Column<Guid>(nullable: false),
                    ITEMS_COUNT = table.Column<long>(nullable: false),
                    ITEM_PRICE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Customer_ID = table.Column<Guid>(nullable: false),
                    ORDER_DATE = table.Column<DateTime>(nullable: false),
                    SHIPMENT_DATE = table.Column<DateTime>(nullable: false),
                    ORDER_NUMBER = table.Column<int>(nullable: false),
                    STATUS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CODE = table.Column<string>(maxLength: 12, nullable: false),
                    NAME = table.Column<string>(nullable: false),
                    PRICE = table.Column<int>(nullable: false),
                    CATEGORY = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
