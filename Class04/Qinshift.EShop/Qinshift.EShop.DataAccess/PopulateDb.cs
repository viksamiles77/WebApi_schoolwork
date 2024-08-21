using Microsoft.EntityFrameworkCore;
using Qinshift.EShop.DomainModels;

namespace Qinshift.EShop.DataAccess
{
    public static class PopulateDb
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(new List<Category> {
                new Category
                {
                    Id = 1,
                    Name = "Smartphones and Tablets",
                    Description = "All sort of smartphones and tablets.",
                },
            new Category
                {
                    Id = 2,
                    Name = "PC and hardware",
                    Description = "Different brands of PCs and all type of hardware components.",
                },
            new Category
                {
                    Id = 3,
                    Name = "Laptops",
                    Description = "Different brands of laptops.",
                },});

            modelBuilder.Entity<Product>()
                .HasData(new List<Product> {
                new Product
                {
                    Id = 1,
                    Name = "Iphone 15 Pro 256GB",
                    Description = "256GB | 5.8' | 8GB RAM",
                    Price = 1000,
                    StockQuantity = 50,
                    ImageUrl = "iphone15pro.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Lenovo Y700 Gaming Laptop",
                    Description = "500GB SSD | 17' | 16GB RAM",
                    Price = 2000,
                    StockQuantity = 20,
                    ImageUrl = "lenovoY700.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 3,
                    Name = "NVIDIA GeForce 4090",
                    Description = "16GB VRAM",
                    Price = 2200,
                    StockQuantity = 10,
                    ImageUrl = "nvidia.jpg",
                    CategoryId = 2
                },});

                modelBuilder.Entity<Review>()
                    .HasData(new List<Review> {
                new Review
                {
                    Id = 1,
                    ReviewerName = "Martin",
                    Comment = "Very nice product",
                    Rating = 5,
                    ImageUrl = "images/phone.jpg",
                    ProductId = 1
                },
                new Review
                {
                    Id = 2,
                    ReviewerName = "Slave",
                    Comment = "Bad product. It is very slow. The RAM is too much used.",
                    Rating = 2,
                    ImageUrl = "images/phone.jpg",
                    ProductId = 1
                },
                });
        }
    }
}
