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
    [Migration("20190319170651_AddPropertyStateTable")]
    partial class AddPropertyStateTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Auctions.AuctionStatus", b =>
                {
                    b.Property<int>("AuctionStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuctionStatusName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Status");

                    b.HasKey("AuctionStatusId");

                    b.ToTable("AuctionStatuses");
                });

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Auctions.AuctionType", b =>
                {
                    b.Property<int>("AuctionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionId");

                    b.Property<int>("TypeId");

                    b.HasKey("AuctionTypeId");

                    b.HasIndex("AuctionId");

                    b.HasIndex("TypeId");

                    b.ToTable("AuctionTypes");
                });

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Users.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("PermissionStatus");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.Auction", b =>
                {
                    b.Property<int>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuctionApplyDate");

                    b.Property<DateTime>("AuctionEndDate");

                    b.Property<string>("AuctionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("AuctionStartDate");

                    b.Property<int>("AuctionStartingPrice");

                    b.Property<int>("AuctionStatusId");

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

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", b =>
                {
                    b.Property<int>("AuctionDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionId");

                    b.Property<int>("AuctionStatusId");

                    b.HasKey("AuctionDetailsId");

                    b.HasIndex("AuctionId")
                        .IsUnique();

                    b.HasIndex("AuctionStatusId");

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
                    b.Property<int>("CategoryTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("TypeId");

                    b.HasKey("CategoryTypeId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TypeId");

                    b.ToTable("CategoryTypes");
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
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ProductId");

                    b.ToTable("Products");
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

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("RoleStatus");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("TypeStatus");

                    b.HasKey("TypeId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.TypeProduct", b =>
                {
                    b.Property<int>("TypeProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<int>("TypeId");

                    b.HasKey("TypeProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TypeId");

                    b.ToTable("TypeProducts");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UserFirstName")
                        .HasMaxLength(50);

                    b.Property<string>("UserLastName")
                        .HasMaxLength(50);

                    b.Property<int>("UserRoleId");

                    b.Property<bool>("UserStatus");

                    b.Property<string>("UserUniqueIdentifier")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Auctions.AuctionType", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.Auction", "Auction")
                        .WithMany()
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.Auction", "Auction")
                        .WithOne("Details")
                        .HasForeignKey("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", "AuctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bidding.Database.DatabaseModels.Auctions.AuctionStatus", "AuctionStatus")
                        .WithMany()
                        .HasForeignKey("AuctionStatusId")
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
                modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Condition.PropertyState", b =>
                {
                    b.Property<int>("PropertyStateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PropertyStateName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("PropertyStateId");

                    b.ToTable("PropertyStates");
                });
#pragma warning restore 612, 618
        }
    }
}
