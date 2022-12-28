﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using restaurantApp.Data;

#nullable disable

namespace restaurantApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221228185752_initialmigration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("restaurantApp.Models.Desserts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Desserts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 5.5,
                            Type = "Coconut Cake"
                        },
                        new
                        {
                            Id = 2,
                            Price = 4.0,
                            Type = "Coco-butter Cake"
                        },
                        new
                        {
                            Id = 3,
                            Price = 6.9900000000000002,
                            Type = "Pear-creme Cake"
                        },
                        new
                        {
                            Id = 4,
                            Price = 5.5,
                            Type = "Ginger Cake"
                        },
                        new
                        {
                            Id = 5,
                            Price = 5.5,
                            Type = "Lemon cake"
                        });
                });

            modelBuilder.Entity("restaurantApp.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 8.9900000000000002,
                            Type = "Spagetti Bolognese"
                        },
                        new
                        {
                            Id = 2,
                            Price = 8.9900000000000002,
                            Type = "Spagetti Carbonaro"
                        },
                        new
                        {
                            Id = 3,
                            Price = 6.9900000000000002,
                            Type = "Spagetti Pomodoro"
                        },
                        new
                        {
                            Id = 4,
                            Price = 8.0,
                            Type = "Spagetti Puttanesca"
                        },
                        new
                        {
                            Id = 5,
                            Price = 11.99,
                            Type = "Spagetti Sardine"
                        });
                });

            modelBuilder.Entity("restaurantApp.Models.Soup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Soups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 5.9900000000000002,
                            Type = "Tomato Soup"
                        },
                        new
                        {
                            Id = 2,
                            Price = 5.9900000000000002,
                            Type = "Cheese Soup"
                        },
                        new
                        {
                            Id = 3,
                            Price = 7.9900000000000002,
                            Type = "Mushroom Soup"
                        },
                        new
                        {
                            Id = 4,
                            Price = 10.0,
                            Type = "Duck Soup"
                        },
                        new
                        {
                            Id = 5,
                            Price = 7.9900000000000002,
                            Type = "Potato Soup"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
