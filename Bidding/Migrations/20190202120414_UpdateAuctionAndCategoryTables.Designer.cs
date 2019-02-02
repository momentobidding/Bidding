﻿// <auto-generated />
using System;
using BiddingAPI.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bidding.Migrations
{
    [DbContext(typeof(BiddingContext))]
    [Migration("20190202120414_UpdateAuctionAndCategoryTables")]
    partial class UpdateAuctionAndCategoryTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.Auction", b =>
                {
                    b.Property<int>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuctionEndDate");

                    b.Property<string>("AuctionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("AuctionStartDate");

                    b.Property<int>("AuctionStartingPrice");

                    b.HasKey("AuctionId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionCategory", b =>
                {
                    b.Property<int>("AuctionCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionId");

                    b.Property<int>("CategoryId");

                    b.HasKey("AuctionCategoryId");

                    b.HasIndex("AuctionId");

                    b.HasIndex("CategoryId");

                    b.ToTable("AuctionCategories");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionId");

                    b.Property<string>("AuctionType");

                    b.Property<int>("Evaluation");

                    b.Property<string>("VehicleIdentificationNumber");

                    b.Property<string>("VehicleRegistrationNumber");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.ToTable("AuctionDetails");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("CategoryStatus");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.CategoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TypeId");

                    b.ToTable("CategoryType");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeatureId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetail");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.TypeProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TypeId");

                    b.ToTable("TypeProduct");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionCategory", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.Auction", "Auction")
                        .WithMany("AuctionCategories")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.CategoryType", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Category", "Category")
                        .WithMany("CategoryTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Type", "Type")
                        .WithMany("CategoryTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.ProductDetail", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Feature", "Feature")
                        .WithMany("ProductDetails")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.TypeProduct", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Product", "Product")
                        .WithMany("TypeProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Type", "Type")
                        .WithMany("TypeProducts")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
