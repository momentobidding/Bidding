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
    [Migration("20190404180721_AddGetAuctionsStoredProcedure")]
    partial class AddGetAuctionsStoredProcedure
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

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AuctionStatusId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("AuctionStatuses");

                    b.HasData(
                        new
                        {
                            AuctionStatusId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Aktīva"
                        },
                        new
                        {
                            AuctionStatusId = 2,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Pārtraukta"
                        },
                        new
                        {
                            AuctionStatusId = 3,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Beigusies"
                        });
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

                    b.HasData(
                        new
                        {
                            AuctionTypeId = 1,
                            AuctionId = 1,
                            TypeId = 1
                        },
                        new
                        {
                            AuctionTypeId = 2,
                            AuctionId = 2,
                            TypeId = 3
                        },
                        new
                        {
                            AuctionTypeId = 3,
                            AuctionId = 3,
                            TypeId = 2
                        });
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.Auction", b =>
                {
                    b.Property<int>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApplyDate");

                    b.Property<int>("AuctionStatusId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("StartingPrice");

                    b.HasKey("AuctionId");

                    b.HasIndex("AuctionStatusId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Auctions");

                    b.HasData(
                        new
                        {
                            AuctionId = 1,
                            ApplyDate = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuctionStatusId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            EndDate = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tesla Model 3",
                            StartDate = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartingPrice = 15000
                        },
                        new
                        {
                            AuctionId = 2,
                            ApplyDate = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuctionStatusId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            EndDate = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Penthouse tipa dzīvoklis Vecrīgas sirdī",
                            StartDate = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartingPrice = 50000
                        },
                        new
                        {
                            AuctionId = 3,
                            ApplyDate = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuctionStatusId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            EndDate = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vīna skapis",
                            StartDate = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartingPrice = 900
                        });
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

                    b.HasData(
                        new
                        {
                            AuctionCategoryId = 1,
                            AuctionId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            AuctionCategoryId = 2,
                            AuctionId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            AuctionCategoryId = 3,
                            AuctionId = 3,
                            CategoryId = 2
                        });
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", b =>
                {
                    b.Property<int>("AuctionDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionId");

                    b.HasKey("AuctionDetailsId");

                    b.HasIndex("AuctionId")
                        .IsUnique();

                    b.ToTable("AuctionDetails");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CategoryId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Transports"
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Manta"
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Nekustamais īpašums"
                        });
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

                    b.HasData(
                        new
                        {
                            CategoryTypeId = 1,
                            CategoryId = 1,
                            TypeId = 1
                        },
                        new
                        {
                            CategoryTypeId = 2,
                            CategoryId = 2,
                            TypeId = 2
                        },
                        new
                        {
                            CategoryTypeId = 3,
                            CategoryId = 3,
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "User"
                        },
                        new
                        {
                            RoleId = 2,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TypeId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            TypeId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Vieglais transports līdz 3,5t"
                        },
                        new
                        {
                            TypeId = 2,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Cita manta"
                        },
                        new
                        {
                            TypeId = 3,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Dzīvoklis"
                        });
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<int>("RoleId");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Email = "dummyadmin@bidding.lv",
                            FirstName = "Dummy",
                            LastName = "Admin",
                            RoleId = 2,
                            UniqueIdentifier = ""
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Email = "dummyuser@bidding.lv",
                            FirstName = "Dummy",
                            LastName = "User",
                            RoleId = 1,
                            UniqueIdentifier = ""
                        });
                });

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Auctions.AuctionStatus", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.User", "User")
                        .WithMany("AuctionStatuses")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Auctions.AuctionType", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.Auction", "Auction")
                        .WithMany("AuctionTypes")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Type", "Type")
                        .WithMany("AuctionTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.Auction", b =>
                {
                    b.HasOne("Bidding.Database.DatabaseModels.Auctions.AuctionStatus", "AuctionStatus")
                        .WithMany("Auctions")
                        .HasForeignKey("AuctionStatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.User", "User")
                        .WithMany("Auctions")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionCategory", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.Auction", "Auction")
                        .WithMany("AuctionCategories")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Category", "Category")
                        .WithMany("AuctionCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.Auction", "Auction")
                        .WithOne("AuctionDetails")
                        .HasForeignKey("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", "AuctionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Category", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.User", "User")
                        .WithMany("Categories")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.CategoryType", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Category", "Category")
                        .WithMany("CategoryTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Type", "Type")
                        .WithMany("CategoryTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Type", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.User", "User")
                        .WithMany("Types")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.User", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
