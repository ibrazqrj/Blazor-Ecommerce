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
                Title = "Hobbu - VIP (Lifetime)",
                Description = "Geniesse Hobbu mit verschiedenen Vorteile für immer!",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                Price = 9.99m,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Title = "Hobbu - Rare Pack (Mini)",
                Description = "Bis zu 8 Rares für das Hobbu Hotel (Frei wählbar!)",
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
            },            
            new Product
            {
                Id = 4,
                Title = "Hobbu - Taler (1 Mio.)",
                Description = "Erhalte 1 Mio. Taler für das Hobbu Hotel!",
                ImageUrl = "https://media.karousell.com/media/photos/products/2015/11/22/habbo_coins_10cents_1448207029_42efc8a0.jpg",
                Price = 5m,
                CategoryId = 3
            }, new Product
            {
                Id = 5,
                Title = "Hobbu - Duckets (1 Mio.)",
                Description = "Bis zu 10 Rares für das Hobbu Hotel (Frei wählbar!)",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAGmXZnYohNKEHtj_59MTJg4N-Xo4uM1KK2A&s",
                Price = 2.50m,
                CategoryId = 3
            }, new Product
            {
                Id = 6,
                Title = "Hobbu - Rare Pack (Mid)",
                Description = "Bis zu 12 Rares für das Hobbu Hotel (Frei wählbar!)",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRrJnqIoVeMZDcHwyA2thmrTN4gsMZcqL6N40bI34kiOUhN_BHhyyqV1n3eMdvOgGDPtyI&usqp=CAU",
                Price = 9.99m,
                CategoryId = 2
            }, new Product
            {
                Id = 7,
                Title = "Hobbu - Rare Pack (Big)",
                Description = "Bis zu 15 Rares für das Hobbu Hotel (Frei wählbar!)",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHQ9MTAhD-PtZmuvI6W9tfQXFs7kvbZwFKbAlCzdAdCTdPLW98gyz-2IEM6LWmur0o6O4&usqp=CAU",
                Price = 13m,
                CategoryId = 2
            }, new Product
            {
                Id = 8,
                Title = "Hobbu - VIP (1 Monat)",
                Description = "Erhalte dein eigenes Badge und bestimmte Titel wie auch Beschreibung! (Badges in Verbindung zu Belästigung, Mobbing oder ausgeben eines Staffs sind verboten!)",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                Price = 2m,
                CategoryId = 2
            }, new Product
            {
                Id = 9,
                Title = "Hobbu - VIP (3 Monate)",
                Description = "Geniesse Hobbu mit verschiedenen Vorteile für 3 Monate!",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                Price = 7.99m,
                CategoryId = 1
            }, new Product
            {
                Id = 10,
                Title = "Hobbu - VIP (6 Monate)",
                Description = "Geniesse Hobbu mit verschiedenen Vorteile für ein halbes Jahr!",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                Price = 7.99m,
                CategoryId = 1
            }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }

}