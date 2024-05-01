﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Data;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Aussie slow cooked lamb, feta, spinach, tomato, onion & olives, on a crème fraîche base, sprinkled with oregano & drizzled with tzatziki sauce",
                            ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P813/AU_P813_en_hero_12804.jpg?v-1796631664",
                            Name = "GREEK LAMB TZATZIKI",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Aussie slow cooked lamb, Italian sausage, pepperoni, smokey leg ham, ground beef & crispy bacon all on a BBQ sauce base, drizzled with Hickory BBQ sauce",
                            ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P812/AU_P812_en_hero_12804.jpg?v-359603694",
                            Name = "LAMB MEATLOVERS",
                            Price = 14.0
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Juicy Australian prawns with diced tomato, red onion and feta drizzled with an Australian avocado sauce.",
                            ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P807/AU_P807_en_hero_12711.jpg?v-2074398491",
                            Name = "AVOCADO PRAWN",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Juicy Australian prawns with Indian Tikka sauce, paneer cheese, fresh capsicum and onion.",
                            ImageUrl = "https://www.dominos.com.au/ManagedAssets/AU/product/P809/AU_P809_en_hero_12711.jpg?v-460834707",
                            Name = "INDIAN TIKKA PRAWN",
                            Price = 13.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
