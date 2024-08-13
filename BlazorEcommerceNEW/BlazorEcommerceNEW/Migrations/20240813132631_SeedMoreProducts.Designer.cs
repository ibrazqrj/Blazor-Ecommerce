﻿// <auto-generated />
using BlazorEcommerceNEW.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerceNEW.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240813132631_SeedMoreProducts")]
    partial class SeedMoreProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerceNEW.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "VIP",
                            Url = "vip"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Packs",
                            Url = "packs"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Currencies",
                            Url = "currencies"
                        });
                });

            modelBuilder.Entity("BlazorEcommerceNEW.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Geniesse Hobbu mit verschiedenen Vorteile für immer!",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                            Price = 9.99m,
                            Title = "Hobbu - VIP (Lifetime)"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Bis zu 8 Rares für das Hobbu Hotel (Frei wählbar!)",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYy9p1iZa44jfYqXC2NNBU1e4QbUtW5g9xeQ&s",
                            Price = 7.99m,
                            Title = "Hobbu - Rare Pack (Mini)"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Erhalte 250 Diamonds für das Hobbu Hotel!",
                            ImageUrl = "https://scontent-zrh1-1.xx.fbcdn.net/v/t39.30808-6/274978441_10158590467262963_5370902555679068282_n.png?_nc_cat=106&ccb=1-7&_nc_sid=127cfc&_nc_ohc=vOYzWEKGu0kQ7kNvgFk_LTV&_nc_ht=scontent-zrh1-1.xx&oh=00_AYByiUjSlVZghuOJ4fOKuQ2kWmBxsqzil7uPqguD6lFW6A&oe=66BFCF27",
                            Price = 6.99m,
                            Title = "Hobbu - Diamonds (250)"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Erhalte 1 Mio. Taler für das Hobbu Hotel!",
                            ImageUrl = "https://media.karousell.com/media/photos/products/2015/11/22/habbo_coins_10cents_1448207029_42efc8a0.jpg",
                            Price = 5m,
                            Title = "Hobbu - Taler (1 Mio.)"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Bis zu 10 Rares für das Hobbu Hotel (Frei wählbar!)",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAGmXZnYohNKEHtj_59MTJg4N-Xo4uM1KK2A&s",
                            Price = 2.50m,
                            Title = "Hobbu - Duckets (1 Mio.)"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Bis zu 12 Rares für das Hobbu Hotel (Frei wählbar!)",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRrJnqIoVeMZDcHwyA2thmrTN4gsMZcqL6N40bI34kiOUhN_BHhyyqV1n3eMdvOgGDPtyI&usqp=CAU",
                            Price = 9.99m,
                            Title = "Hobbu - Rare Pack (Mid)"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Bis zu 15 Rares für das Hobbu Hotel (Frei wählbar!)",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHQ9MTAhD-PtZmuvI6W9tfQXFs7kvbZwFKbAlCzdAdCTdPLW98gyz-2IEM6LWmur0o6O4&usqp=CAU",
                            Price = 13m,
                            Title = "Hobbu - Rare Pack (Big)"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Erhalte dein eigenes Badge und bestimmte Titel wie auch Beschreibung! (Badges in Verbindung zu Belästigung, Mobbing oder ausgeben eines Staffs sind verboten!)",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                            Price = 2m,
                            Title = "Hobbu - VIP (1 Monat)"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Geniesse Hobbu mit verschiedenen Vorteile für 3 Monate!",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                            Price = 7.99m,
                            Title = "Hobbu - VIP (3 Monate)"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "Geniesse Hobbu mit verschiedenen Vorteile für ein halbes Jahr!",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTntRWnAmtPso89KDj2fqwHBE_aHRbf8mmSqQ&s",
                            Price = 7.99m,
                            Title = "Hobbu - VIP (6 Monate)"
                        });
                });

            modelBuilder.Entity("BlazorEcommerceNEW.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerceNEW.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
