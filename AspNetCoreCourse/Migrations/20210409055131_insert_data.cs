using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AspNetCoreCourse.Migrations
{
    public partial class insert_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var items = new object[][]
           {
                new object[]{"Торт шоколадный", 1250.00},
                new object[]{"Торт фруктовый", 850.00},
                new object[]{"Наполеон", 950.00},
                new object[]{"Фруктовая корзина", 600.00},
                new object[]{"Венская вафля", 150.00},
                new object[]{"Тирамису", 950.00}
           };

            foreach (var item in items)
            {
                migrationBuilder.InsertData(
             table: "Item",
             columns: new[] { "Name", "Price" },
             values: item);
            }

            var orders = new object[][]
            {
                new object[]{"1", DateTime.Parse("2021-04-10")},
                new object[]{"2", DateTime.Parse("2021-04-17")},
                new object[]{"3", DateTime.Parse("2021-04-29") }
            };

            foreach (var order in orders)
            {
                migrationBuilder.InsertData(
                  table: "Order",
                  columns: new[] { "OrderNumber", "OrderDate" },
                  values: order);
            }

            var orderItems = new object[][]
           {
                new object[]{1,1,2},
                new object[]{1,6,2},
                new object[]{2,3,1},
                new object[]{2,1,1},
                new object[]{2,4,3},
                new object[]{3,5,5},
                new object[]{3,6,1},
          };
            foreach (var orderItem in orderItems)
            {
                migrationBuilder.InsertData(
                  table: "OrderItems",
                  columns: new[] { "OrderId", "ItemId", "Amount" },
                  values: orderItem);
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM OrderItems", true);
            migrationBuilder.Sql("DELETE FROM Order", true);
            migrationBuilder.Sql("DELETE FROM Item", true);
        }
    }
}

