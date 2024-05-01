using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "GREEK LAMB TZATZIKI",
                Price = 15,
                Description = "Aussie slow cooked lamb, feta, spinach, tomato, onion & olives, on a crème fraîche base, sprinkled with oregano & drizzled with tzatziki sauce",
                ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P813/AU_P813_en_hero_12804.jpg?v-1796631664"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "LAMB MEATLOVERS",
                Price = 14,
                Description = "Aussie slow cooked lamb, Italian sausage, pepperoni, smokey leg ham, ground beef & crispy bacon all on a BBQ sauce base, drizzled with Hickory BBQ sauce",
                ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P812/AU_P812_en_hero_12804.jpg?v-359603694"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "AVOCADO PRAWN",
                Price = 10,
                Description = "Juicy Australian prawns with diced tomato, red onion and feta drizzled with an Australian avocado sauce.",
                ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P807/AU_P807_en_hero_12711.jpg?v-2074398491"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "INDIAN TIKKA PRAWN",
                Price = 13,
                Description = "Juicy Australian prawns with Indian Tikka sauce, paneer cheese, fresh capsicum and onion.",
                ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P809/AU_P809_en_hero_12711.jpg?v-460834707"
            });
        }
    }
}
