namespace BlazorEcommerceNEW.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "1 Monat" },
                new ProductType { Id = 2, Name = "3 Monate" },
                new ProductType { Id = 3, Name = "6 Monate" },
                new ProductType { Id = 4, Name = "Lifetime" },
                new ProductType { Id = 5, Name = "500'000" },
                new ProductType { Id = 6, Name = "1'000'000" },
                new ProductType { Id = 7, Name = "Normal" },
                new ProductType { Id = 8, Name = "XL" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 3.00m,
                    OriginalPrice = 3.00m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 8.00m,
                    OriginalPrice = 5.00m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 15.00m,
                    OriginalPrice = 8.00m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 25.00m,
                    OriginalPrice = 10.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 7,
                    Price = 5.00m,
                    OriginalPrice = 5.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 8,
                    Price = 10.00m,
                    OriginalPrice = 10.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 5,
                    Price = 5.00m,
                    OriginalPrice = 5.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 6,
                    Price = 10.00m,
                    OriginalPrice = 10.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 5.00m,
                    OriginalPrice = 5.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 6,
                    Price = 10.00m,
                    OriginalPrice = 10.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 5,
                    Price = 2.50m,
                    OriginalPrice = 2.50m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 6,
                    Price = 10.00m,
                    OriginalPrice = 5.00m
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "VIP",
                    Url = "vip"
                },
                new Category
                {
                    Id = 2,
                    Name = "Packs",
                    Url = "packs"
                },
                new Category
                {
                    Id = 3,
                    Name = "Currencies",
                    Url = "currencies"
                }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "Hobbu - VIP",
                Description = "Geniesse Hobbu mit verschiedenen Vorteile!",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Title = "Hobbu - Rare Pack",
                Description = "Hobbu Rare Paket. Die Rares sind frei wählbar.",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYy9p1iZa44jfYqXC2NNBU1e4QbUtW5g9xeQ&s",
                CategoryId = 2
            },
            new Product
            {
                Id = 3,
                Title = "Hobbu - Diamonds",
                Description = "Erhalte Diamanten für den Hobbu Client!",
                ImageUrl = "https://scontent-zrh1-1.xx.fbcdn.net/v/t39.30808-6/274978441_10158590467262963_5370902555679068282_n.png?_nc_cat=106&ccb=1-7&_nc_sid=127cfc&_nc_ohc=vOYzWEKGu0kQ7kNvgFk_LTV&_nc_ht=scontent-zrh1-1.xx&oh=00_AYByiUjSlVZghuOJ4fOKuQ2kWmBxsqzil7uPqguD6lFW6A&oe=66BFCF27",
                CategoryId = 3
            },            
            new Product
            {
                Id = 4,
                Title = "Hobbu - Taler",
                Description = "Erhalte Taler für den Hobbu Client!",
                ImageUrl = "https://media.karousell.com/media/photos/products/2015/11/22/habbo_coins_10cents_1448207029_42efc8a0.jpg",
                CategoryId = 3
            },
            new Product
            {
                Id = 5,
                Title = "Hobbu - Duckets",
                Description = "Erhalte Taler für den Hobbu Client!",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAGmXZnYohNKEHtj_59MTJg4N-Xo4uM1KK2A&s",
                CategoryId = 3
            }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }

    }

}