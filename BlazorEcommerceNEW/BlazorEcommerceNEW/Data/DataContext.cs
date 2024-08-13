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
                Description = "Geniesse Hobbu mit verschiedenen Vorteile.",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                Price = 9.99m,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Title = "Hobbu - Rare Pack",
                Description = "Bis zu 10 Rares für das Hobbu Hotel (Frei wählbar!)",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYy9p1iZa44jfYqXC2NNBU1e4QbUtW5g9xeQ&s",
                Price = 7.99m,
                CategoryId = 2
            },
            new Product
            {
                Id = 3,
                Title = "Hobbu - Diamonds (250)",
                Description = "Erhalte 250 Diamonds für das Hobbu Hotel!",
                ImageUrl = "https://scontent-zrh1-1.xx.fbcdn.net/v/t39.30808-6/274978441_10158590467262963_5370902555679068282_n.png?_nc_cat=106&ccb=1-7&_nc_sid=127cfc&_nc_ohc=vOYzWEKGu0kQ7kNvgFk_LTV&_nc_ht=scontent-zrh1-1.xx&oh=00_AYByiUjSlVZghuOJ4fOKuQ2kWmBxsqzil7uPqguD6lFW6A&oe=66BFCF27",
                Price = 6.99m,
                CategoryId = 3
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }

}