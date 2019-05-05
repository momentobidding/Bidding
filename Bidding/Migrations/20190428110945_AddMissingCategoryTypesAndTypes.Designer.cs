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
    [Migration("20190428110945_AddMissingCategoryTypesAndTypes")]
    partial class AddMissingCategoryTypesAndTypes
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
                        },
                        new
                        {
                            AuctionTypeId = 4,
                            AuctionId = 4,
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Auctions.Details.AuctionVehicleDetails", b =>
                {
                    b.Property<int>("AuctionVehicleDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<string>("EngineSize");

                    b.Property<int>("Evaluation");

                    b.Property<string>("FuelType");

                    b.Property<string>("Gearbox");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<int?>("LastUpdatedBy");

                    b.Property<string>("Make");

                    b.Property<DateTime>("ManufacturingDate");

                    b.Property<string>("Model");

                    b.Property<string>("Power");

                    b.Property<string>("Transmission");

                    b.Property<int?>("UserId");

                    b.Property<string>("VehicleIdentificationNumber")
                        .HasMaxLength(50);

                    b.Property<bool>("VehicleInspectionActive");

                    b.Property<string>("VehicleRegistrationNumber")
                        .HasMaxLength(50);

                    b.HasKey("AuctionVehicleDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("AuctionVehicleDetails");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.Auction", b =>
                {
                    b.Property<int>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ApplyDate")
                        .IsRequired();

                    b.Property<int>("AuctionStatusId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired();

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
                        },
                        new
                        {
                            AuctionId = 4,
                            ApplyDate = new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuctionStatusId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            EndDate = new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Audi A4",
                            StartDate = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartingPrice = 350
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
                        },
                        new
                        {
                            AuctionCategoryId = 4,
                            AuctionId = 4,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionCondition", b =>
                {
                    b.Property<int>("AuctionConditionId")
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

                    b.HasKey("AuctionConditionId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("AuctionConditions");

                    b.HasData(
                        new
                        {
                            AuctionConditionId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Lietota"
                        },
                        new
                        {
                            AuctionConditionId = 2,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Jauna"
                        },
                        new
                        {
                            AuctionConditionId = 3,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Apdzīvots"
                        },
                        new
                        {
                            AuctionConditionId = 4,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Neapdzīvots"
                        },
                        new
                        {
                            AuctionConditionId = 5,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Nepieciešams remonts"
                        });
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", b =>
                {
                    b.Property<int>("AuctionDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuctionConditionId");

                    b.Property<int>("AuctionFormatId");

                    b.Property<int>("AuctionId");

                    b.Property<string>("Description")
                        .HasMaxLength(50);

                    b.HasKey("AuctionDetailsId");

                    b.HasIndex("AuctionConditionId");

                    b.HasIndex("AuctionFormatId");

                    b.HasIndex("AuctionId")
                        .IsUnique();

                    b.ToTable("AuctionDetails");
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionFormat", b =>
                {
                    b.Property<int>("AuctionFormatId")
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

                    b.HasKey("AuctionFormatId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("AuctionFormats");

                    b.HasData(
                        new
                        {
                            AuctionFormatId = 1,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Cenu aptauja"
                        },
                        new
                        {
                            AuctionFormatId = 2,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Izsole elektroniski"
                        },
                        new
                        {
                            AuctionFormatId = 3,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Izsole klātienē"
                        });
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
                            CategoryId = 1,
                            TypeId = 2
                        },
                        new
                        {
                            CategoryTypeId = 3,
                            CategoryId = 1,
                            TypeId = 3
                        },
                        new
                        {
                            CategoryTypeId = 4,
                            CategoryId = 1,
                            TypeId = 4
                        },
                        new
                        {
                            CategoryTypeId = 5,
                            CategoryId = 1,
                            TypeId = 5
                        },
                        new
                        {
                            CategoryTypeId = 6,
                            CategoryId = 1,
                            TypeId = 6
                        },
                        new
                        {
                            CategoryTypeId = 7,
                            CategoryId = 2,
                            TypeId = 7
                        },
                        new
                        {
                            CategoryTypeId = 8,
                            CategoryId = 2,
                            TypeId = 8
                        },
                        new
                        {
                            CategoryTypeId = 9,
                            CategoryId = 2,
                            TypeId = 9
                        },
                        new
                        {
                            CategoryTypeId = 10,
                            CategoryId = 2,
                            TypeId = 10
                        },
                        new
                        {
                            CategoryTypeId = 11,
                            CategoryId = 2,
                            TypeId = 11
                        },
                        new
                        {
                            CategoryTypeId = 12,
                            CategoryId = 3,
                            TypeId = 12
                        },
                        new
                        {
                            CategoryTypeId = 13,
                            CategoryId = 3,
                            TypeId = 13
                        },
                        new
                        {
                            CategoryTypeId = 14,
                            CategoryId = 3,
                            TypeId = 14
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
                            Name = "Traktortehnika"
                        },
                        new
                        {
                            TypeId = 3,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Kravas auto"
                        },
                        new
                        {
                            TypeId = 4,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Mototehnika"
                        },
                        new
                        {
                            TypeId = 5,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Ūdens transports"
                        },
                        new
                        {
                            TypeId = 6,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Cits transports"
                        },
                        new
                        {
                            TypeId = 7,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Biroja tehnika"
                        },
                        new
                        {
                            TypeId = 8,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Elektrotehnika"
                        },
                        new
                        {
                            TypeId = 9,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Rūpniecības tehnika"
                        },
                        new
                        {
                            TypeId = 10,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Instrumenti"
                        },
                        new
                        {
                            TypeId = 11,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Cita manta"
                        },
                        new
                        {
                            TypeId = 12,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Dzīvoklis"
                        },
                        new
                        {
                            TypeId = 13,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Māja"
                        },
                        new
                        {
                            TypeId = 14,
                            CreatedAt = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Deleted = false,
                            Name = "Zeme"
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

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

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

            modelBuilder.Entity("Bidding.Database.DatabaseModels.Auctions.Details.AuctionVehicleDetails", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
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

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionCondition", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.User", "User")
                        .WithMany("AuctionConditions")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.AuctionCondition", "AuctionCondition")
                        .WithMany("AuctionDetails")
                        .HasForeignKey("AuctionConditionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.AuctionFormat", "AuctionFormat")
                        .WithMany("AuctionDetails")
                        .HasForeignKey("AuctionFormatId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BiddingAPI.Models.DatabaseModels.Bidding.Auction", "Auction")
                        .WithOne("AuctionDetails")
                        .HasForeignKey("BiddingAPI.Models.DatabaseModels.Bidding.AuctionDetails", "AuctionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BiddingAPI.Models.DatabaseModels.Bidding.AuctionFormat", b =>
                {
                    b.HasOne("BiddingAPI.Models.DatabaseModels.User", "User")
                        .WithMany("AuctionFormats")
                        .HasForeignKey("CreatedBy")
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