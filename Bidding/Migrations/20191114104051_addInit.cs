﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bidding.Migrations
{
    public partial class addInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PermissionsInRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IdentityId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuctionConditions",
                columns: table => new
                {
                    AuctionConditionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionConditions", x => x.AuctionConditionId);
                });

            migrationBuilder.CreateTable(
                name: "AuctionCreators",
                columns: table => new
                {
                    AuctionCreatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    ContactEmail = table.Column<string>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: false),
                    ContactAddress = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionCreators", x => x.AuctionCreatorId);
                });

            migrationBuilder.CreateTable(
                name: "AuctionFormats",
                columns: table => new
                {
                    AuctionFormatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionFormats", x => x.AuctionFormatId);
                });

            migrationBuilder.CreateTable(
                name: "AuctionStatuses",
                columns: table => new
                {
                    AuctionStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionStatuses", x => x.AuctionStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ItemConditions",
                columns: table => new
                {
                    ItemConditionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemConditions", x => x.ItemConditionId);
                });

            migrationBuilder.CreateTable(
                name: "ModulesForUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(maxLength: 36, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowedPaidForModules = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesForUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 100, nullable: true),
                    Vehicles = table.Column<bool>(nullable: false),
                    Items = table.Column<bool>(nullable: false),
                    Estate = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyMeasurementTypes",
                columns: table => new
                {
                    PropertyMeasurementTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyMeasurementTypes", x => x.PropertyMeasurementTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "RolesToPermissions",
                columns: table => new
                {
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    PermissionsInRole = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesToPermissions", x => x.RoleName);
                });

            migrationBuilder.CreateTable(
                name: "VehicleFuelTypes",
                columns: table => new
                {
                    VehicleFuelTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFuelTypes", x => x.VehicleFuelTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTransmissions",
                columns: table => new
                {
                    VehicleTransmissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTransmissions", x => x.VehicleTransmissionId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    AuctionCategoryId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                    table.ForeignKey(
                        name: "FK_Types_Categories_AuctionCategoryId",
                        column: x => x.AuctionCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    AuctionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    StartingPrice = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    ApplyTillDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    AuctionCategoryId = table.Column<int>(nullable: false),
                    AuctionTypeId = table.Column<int>(nullable: false),
                    AuctionStatusId = table.Column<int>(nullable: false),
                    AuctionFormatId = table.Column<int>(nullable: false),
                    AuctionCreatorId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.AuctionId);
                    table.ForeignKey(
                        name: "FK_Auctions_Categories_AuctionCategoryId",
                        column: x => x.AuctionCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auctions_AuctionCreators_AuctionCreatorId",
                        column: x => x.AuctionCreatorId,
                        principalTable: "AuctionCreators",
                        principalColumn: "AuctionCreatorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auctions_AuctionFormats_AuctionFormatId",
                        column: x => x.AuctionFormatId,
                        principalTable: "AuctionFormats",
                        principalColumn: "AuctionFormatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auctions_AuctionStatuses_AuctionStatusId",
                        column: x => x.AuctionStatusId,
                        principalTable: "AuctionStatuses",
                        principalColumn: "AuctionStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auctions_Types_AuctionTypeId",
                        column: x => x.AuctionTypeId,
                        principalTable: "Types",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuctionItems",
                columns: table => new
                {
                    AuctionItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    AuctionId = table.Column<int>(nullable: false),
                    AuctionItemCategoryId = table.Column<int>(nullable: false),
                    AuctionItemTypeId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionItems", x => x.AuctionItemId);
                    table.ForeignKey(
                        name: "FK_AuctionItems_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "AuctionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionItems_Categories_AuctionItemCategoryId",
                        column: x => x.AuctionItemCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionItems_Types_AuctionItemTypeId",
                        column: x => x.AuctionItemTypeId,
                        principalTable: "Types",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuctionDetails",
                columns: table => new
                {
                    AuctionDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuctionItemId = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ManufacturingYear = table.Column<int>(nullable: true),
                    RegistrationNumber = table.Column<string>(maxLength: 50, nullable: true),
                    IdentificationNumber = table.Column<string>(maxLength: 50, nullable: true),
                    InspectionActive = table.Column<bool>(nullable: true),
                    TransmissionId = table.Column<int>(nullable: true),
                    FuelTypeId = table.Column<int>(nullable: true),
                    EngineSize = table.Column<string>(nullable: true),
                    Axis = table.Column<string>(nullable: true),
                    ConditionId = table.Column<int>(nullable: true),
                    Coordinates = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    CadastreNumber = table.Column<int>(nullable: true),
                    MeasurementValue = table.Column<int>(nullable: true),
                    MeasurementTypeId = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    FloorCount = table.Column<int>(nullable: true),
                    RoomCount = table.Column<int>(nullable: true),
                    Evaluation = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionDetails", x => x.AuctionDetailsId);
                    table.ForeignKey(
                        name: "FK_AuctionDetails_AuctionItems_AuctionItemId",
                        column: x => x.AuctionItemId,
                        principalTable: "AuctionItems",
                        principalColumn: "AuctionItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionDetails_ItemConditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "ItemConditions",
                        principalColumn: "ItemConditionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionDetails_VehicleFuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "VehicleFuelTypes",
                        principalColumn: "VehicleFuelTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionDetails_PropertyMeasurementTypes_MeasurementTypeId",
                        column: x => x.MeasurementTypeId,
                        principalTable: "PropertyMeasurementTypes",
                        principalColumn: "PropertyMeasurementTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionDetails_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionDetails_VehicleTransmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "VehicleTransmissions",
                        principalColumn: "VehicleTransmissionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "PermissionsInRole" },
                values: new object[,]
                {
                    { 100, "c6a672a2-ca89-45fb-b1ec-8bf36c8b9186", null, "BasicUser", "BASICUSER", null },
                    { 200, "1a57844a-152a-4a0a-be49-1a744f11c321", null, "AuctionCreator", "AUCTIONCREATOR", null },
                    { 300, "5b45912c-9a63-46e3-9a50-ec625066db3a", null, "PageAdministrator", "PAGEADMINISTRATOR", null },
                    { 400, "b876c4db-2b6a-4b87-866e-4e4e54e67082", null, "SuperAdministrator", "SUPERADMINISTRATOR", null }
                });

            migrationBuilder.InsertData(
                table: "AuctionConditions",
                columns: new[] { "AuctionConditionId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lietota" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jauna" },
                    { 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Apdzīvots" },
                    { 4, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Neapdzīvots" },
                    { 5, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nepieciešams remonts" }
                });

            migrationBuilder.InsertData(
                table: "AuctionFormats",
                columns: new[] { "AuctionFormatId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Izsole klātienē" },
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cenu aptauja" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Izsole elektroniski" }
                });

            migrationBuilder.InsertData(
                table: "AuctionStatuses",
                columns: new[] { "AuctionStatusId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aktīva" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pārtraukta" },
                    { 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Beigusies" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Manta" },
                    { 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nekustamais īpašums" },
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Transports" }
                });

            migrationBuilder.InsertData(
                table: "ItemConditions",
                columns: new[] { "ItemConditionId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jauns" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lietots" }
                });

            migrationBuilder.InsertData(
                table: "PropertyMeasurementTypes",
                columns: new[] { "PropertyMeasurementTypeId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "m2" },
                    { 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ha" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "a" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ogre" },
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jelgava" }
                });

            migrationBuilder.InsertData(
                table: "RolesToPermissions",
                columns: new[] { "RoleName", "Description", "PermissionsInRole" },
                values: new object[,]
                {
                    { "PageAdministrator", "Can almost do evrything in the page", "ReadAuctionList,ReadBasicAuctionDetails,ChangeOwnProfile,ReadAdvancedDetailsForOwnAuction,ChangeOwnAuction" },
                    { "BasicUser", "Basic user without anything extra", "ReadAuctionList,ReadBasicAuctionDetails,ChangeOwnProfile" },
                    { "AuctionCreator", "Can change data for own auctions", "ReadAuctionList,ReadBasicAuctionDetails,ChangeOwnProfile,ReadAdvancedDetailsForOwnAuction,ChangeOwnAuction" },
                    { "SuperAdministrator", "Can access everything", "AccessAll" }
                });

            migrationBuilder.InsertData(
                table: "VehicleFuelTypes",
                columns: new[] { "VehicleFuelTypeId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Benzīns" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Dīzelis" },
                    { 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Benzīns/Naftas gāze" },
                    { 4, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Elektroniskais" },
                    { 5, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hibrīds" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTransmissions",
                columns: new[] { "VehicleTransmissionId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Automatiskā" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mehāniskā" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeId", "AuctionCategoryId", "CreatedAt", "Deleted", "LastUpdatedAt", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vieglais transports līdz 3,5t" },
                    { 22, 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Zeme" },
                    { 21, 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Māja" },
                    { 20, 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Dzīvoklis" },
                    { 19, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cita manta" },
                    { 18, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Biroja mēbeles" },
                    { 17, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sadzīves mēbeles" },
                    { 16, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Preču zīme" },
                    { 15, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Domeins" },
                    { 14, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Uzņēmums" },
                    { 13, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Veikala produkcija" },
                    { 12, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ražošanas materiāli" },
                    { 11, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Iekārtas" },
                    { 10, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Instrumenti" },
                    { 9, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sadzīves tehnika" },
                    { 8, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Biroja tehnika" },
                    { 7, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cits transports" },
                    { 6, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ūdens transports" },
                    { 5, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Piekabes" },
                    { 4, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mototehnika" },
                    { 3, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kravas auto" },
                    { 2, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Traktortehnika" },
                    { 23, 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Telpa" },
                    { 24, 3, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Garāža" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionDetails_AuctionItemId",
                table: "AuctionDetails",
                column: "AuctionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionDetails_ConditionId",
                table: "AuctionDetails",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionDetails_FuelTypeId",
                table: "AuctionDetails",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionDetails_MeasurementTypeId",
                table: "AuctionDetails",
                column: "MeasurementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionDetails_RegionId",
                table: "AuctionDetails",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionDetails_TransmissionId",
                table: "AuctionDetails",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionItems_AuctionId",
                table: "AuctionItems",
                column: "AuctionId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionItems_AuctionItemCategoryId",
                table: "AuctionItems",
                column: "AuctionItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionItems_AuctionItemTypeId",
                table: "AuctionItems",
                column: "AuctionItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_AuctionCategoryId",
                table: "Auctions",
                column: "AuctionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_AuctionCreatorId",
                table: "Auctions",
                column: "AuctionCreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_AuctionFormatId",
                table: "Auctions",
                column: "AuctionFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_AuctionStatusId",
                table: "Auctions",
                column: "AuctionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_AuctionTypeId",
                table: "Auctions",
                column: "AuctionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_AuctionCategoryId",
                table: "Types",
                column: "AuctionCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuctionConditions");

            migrationBuilder.DropTable(
                name: "AuctionDetails");

            migrationBuilder.DropTable(
                name: "ModulesForUsers");

            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "RolesToPermissions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AuctionItems");

            migrationBuilder.DropTable(
                name: "ItemConditions");

            migrationBuilder.DropTable(
                name: "VehicleFuelTypes");

            migrationBuilder.DropTable(
                name: "PropertyMeasurementTypes");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "VehicleTransmissions");

            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "AuctionCreators");

            migrationBuilder.DropTable(
                name: "AuctionFormats");

            migrationBuilder.DropTable(
                name: "AuctionStatuses");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
