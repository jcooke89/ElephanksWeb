﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ElephanksWeb.Repository;

namespace ElephanksWeb.Migrations
{
    [DbContext(typeof(TrunkContext))]
    partial class TrunkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("PostalAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("Building");

                    b.Property<string>("City");

                    b.Property<string>("CountyRegion");

                    b.Property<string>("PostCode");

                    b.Property<string>("Province");

                    b.HasKey("Id");

                    b.ToTable("PostalAddress");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Trunk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<string>("Message");

                    b.Property<int?>("ProductId");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ProductId");

                    b.ToTable("Trunks");
                });

            modelBuilder.Entity("Trunk", b =>
                {
                    b.HasOne("PostalAddress", "RecipientAddress")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
        }
    }
}
