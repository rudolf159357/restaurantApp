using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace restaurantApp.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desserts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desserts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soups", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 5.5, "Coconut Cake" },
                    { 2, 4.0, "Coco-butter Cake" },
                    { 3, 6.9900000000000002, "Pear-creme Cake" },
                    { 4, 5.5, "Ginger Cake" },
                    { 5, 5.5, "Lemon cake" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 8.9900000000000002, "Spagetti Bolognese" },
                    { 2, 8.9900000000000002, "Spagetti Carbonaro" },
                    { 3, 6.9900000000000002, "Spagetti Pomodoro" },
                    { 4, 8.0, "Spagetti Puttanesca" },
                    { 5, 11.99, "Spagetti Sardine" }
                });

            migrationBuilder.InsertData(
                table: "Soups",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 5.9900000000000002, "Tomato Soup" },
                    { 2, 5.9900000000000002, "Cheese Soup" },
                    { 3, 7.9900000000000002, "Mushroom Soup" },
                    { 4, 10.0, "Duck Soup" },
                    { 5, 7.9900000000000002, "Potato Soup" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desserts");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Soups");
        }
    }
}
