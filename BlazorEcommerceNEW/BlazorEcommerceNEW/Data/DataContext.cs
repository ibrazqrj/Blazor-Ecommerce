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
                    Name = "Pakete",
                    Url = "packs"
                },
                new Category
                {
                    Id = 3,
                    Name = "Währung",
                    Url = "currencies"
                }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "Hobbu - VIP",
                Description = "Geniesse Hobbu mit verschiedenen Vorteile!",
                ImageUrl = "https://i.imgur.com/ZhRJNod.png",
                CategoryId = 1,
                Featured = true
            },
            new Product
            {
                Id = 2,
                Title = "Hobbu - Rare Paket",
                Description = "Hobbu Rare Paket. Die Rares sind frei wählbar.",
                ImageUrl = "https://i.imgur.com/UQjhDCy.png",
                CategoryId = 2
            },
            new Product
            {
                Id = 3,
                Title = "Hobbu - Diamanten",
                Description = "Erhalte Diamanten für den Hobbu Client!",
                ImageUrl = "https://i.imgur.com/7mq1YzD.png",
                CategoryId = 3,
                Featured = true
            },            
            new Product
            {
                Id = 4,
                Title = "Hobbu - Taler",
                Description = "Erhalte Taler für den Hobbu Client!",
                ImageUrl = "https://i.imgur.com/qgAsu9u.png",
                CategoryId = 3
            },
            new Product
            {
                Id = 5,
                Title = "Hobbu - Duckets",
                Description = "Erhalte Taler für den Hobbu Client!",
                ImageUrl = "https://cdn.discordapp.com/attachments/1266160134665670797/1275056899997564952/DucketsBanner.png?ex=66c480c6&is=66c32f46&hm=c10369c0a81232057f634f538999324158777fa771527d1ef7b4dbfbf253b294&",
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