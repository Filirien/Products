﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products.Data;

namespace Products.Data.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Products.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("TypeId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Description = "Gernier", TypeId = 1, UserId = 3 },
                        new { Id = 2, Description = "Head & Shoulders", TypeId = 1, UserId = 3 },
                        new { Id = 3, Description = "Leganza", TypeId = 1, UserId = 3 },
                        new { Id = 4, Description = "Loreal", TypeId = 1, UserId = 3 },
                        new { Id = 5, Description = "Shauma", TypeId = 1, UserId = 2 },
                        new { Id = 6, Description = "Shauma Nature", TypeId = 1, UserId = 2 },
                        new { Id = 7, Description = "Wash & Go", TypeId = 1, UserId = 1 },
                        new { Id = 8, Description = "ARGAN", TypeId = 1, UserId = 1 },
                        new { Id = 9, Description = "Banana", TypeId = 2, UserId = 3 },
                        new { Id = 10, Description = "Avocado", TypeId = 2, UserId = 3 },
                        new { Id = 11, Description = "Cherry", TypeId = 2, UserId = 2 },
                        new { Id = 12, Description = "Grapefruit", TypeId = 2, UserId = 2 },
                        new { Id = 13, Description = "Grape", TypeId = 2, UserId = 2 },
                        new { Id = 14, Description = "Lemon", TypeId = 2, UserId = 2 },
                        new { Id = 15, Description = "Mango", TypeId = 2, UserId = 1 },
                        new { Id = 16, Description = "Mandarin", TypeId = 2, UserId = 1 },
                        new { Id = 17, Description = "Carrot", TypeId = 3, UserId = 3 },
                        new { Id = 18, Description = "Cucumber", TypeId = 3, UserId = 3 },
                        new { Id = 19, Description = "Garlic", TypeId = 3, UserId = 2 },
                        new { Id = 20, Description = "Potato", TypeId = 3, UserId = 1 },
                        new { Id = 21, Description = "Melon", TypeId = 3, UserId = 1 },
                        new { Id = 22, Description = "Broccoli", TypeId = 3, UserId = 1 },
                        new { Id = 23, Description = "Asparagus", TypeId = 3, UserId = 1 },
                        new { Id = 24, Description = "Fennel", TypeId = 3, UserId = 1 }
                    );
                });

            modelBuilder.Entity("Products.Data.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new { Id = 1, Description = "Shampoos" },
                        new { Id = 2, Description = "Fruits" },
                        new { Id = 3, Description = "Vegetables" }
                    );
                });

            modelBuilder.Entity("Products.Data.Models.Product", b =>
                {
                    b.HasOne("Products.Data.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
