﻿// <auto-generated />
using System;
using MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("harga")
                        .HasColumnType("int");

                    b.Property<string>("nama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("MVC.Models.Cookie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("deskripsi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("harga")
                        .HasColumnType("int");

                    b.Property<string>("nama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Cookies");
                });

            modelBuilder.Entity("MVC.Models.Total", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Totals");
                });

            modelBuilder.Entity("MVC.Models.Transaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("alamat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("konsumen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("totalBelanja")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MVC.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("password")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
