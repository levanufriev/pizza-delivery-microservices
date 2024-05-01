using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Aussie slow cooked lamb, feta, spinach, tomato, onion & olives, on a crème fraîche base, sprinkled with oregano & drizzled with tzatziki sauce", "https://www.dominos.com.au/ManagedAssets/AU/product/P813/AU_P813_en_hero_12804.jpg?v-1796631664", "GREEK LAMB TZATZIKI", 15.0 },
                    { 2, "Aussie slow cooked lamb, Italian sausage, pepperoni, smokey leg ham, ground beef & crispy bacon all on a BBQ sauce base, drizzled with Hickory BBQ sauce", "https://www.dominos.com.au/ManagedAssets/AU/product/P812/AU_P812_en_hero_12804.jpg?v-359603694", "LAMB MEATLOVERS", 14.0 },
                    { 3, "Juicy Australian prawns with diced tomato, red onion and feta drizzled with an Australian avocado sauce.", "https://www.dominos.com.au/ManagedAssets/AU/product/P807/AU_P807_en_hero_12711.jpg?v-2074398491", "AVOCADO PRAWN", 10.0 },
                    { 4, "Juicy Australian prawns with Indian Tikka sauce, paneer cheese, fresh capsicum and onion.", "https://www.dominos.com.au/ManagedAssets/AU/product/P809/AU_P809_en_hero_12711.jpg?v-460834707", "INDIAN TIKKA PRAWN", 13.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
