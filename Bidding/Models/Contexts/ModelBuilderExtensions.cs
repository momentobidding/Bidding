﻿using Bidding.Models.DatabaseModels.Auctions;
using Bidding.Models.DatabaseModels.Categories;
using Bidding.Models.DatabaseModels.Item;
using Bidding.Models.DatabaseModels.Property;
using Bidding.Models.DatabaseModels.Shared;
using Bidding.Models.DatabaseModels.Vehicle;
using Bidding.Shared.Constants;
using DataLayer.ExtraAuthClasses;
using Microsoft.EntityFrameworkCore;
using PermissionParts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bidding.Models.Contexts
{
    public static class ModelBuilderExtensions
    {
        private static DateTime CreatedAtDateTime = DateTime.Parse("01/01/2019");
        private static int CreatedByBiddingAdmin = 1;

        public static void Seed(this ModelBuilder modelBuilder)
        {
            PopulateRoles(modelBuilder);
            PopulateAuctionStatuses(modelBuilder);
            PopulateVehicleTransmissions(modelBuilder);
            PopulateVehicleFuelTypes(modelBuilder);
            PopulateVehicleDimensionTypes(modelBuilder);
            PopulateItemConditions(modelBuilder);
            PopulateItemCompanyTypes(modelBuilder);
            PopulatePropertyMeasurementTypes(modelBuilder);
            PopulateRegions(modelBuilder);
            PopulateCategories(modelBuilder);
            PopulateTypes(modelBuilder);
            PopulateAuctionFormats(modelBuilder);
            PopulateAuctionConditions(modelBuilder);
        }

        private static void PopulateRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole { Id = 100, Name = ApplicationUserRoles.BasicUser, NormalizedName = ApplicationUserRoles.BasicUser.ToUpper() });
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole { Id = 200, Name = ApplicationUserRoles.AuctionCreator, NormalizedName = ApplicationUserRoles.AuctionCreator.ToUpper() });
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole { Id = 300, Name = ApplicationUserRoles.PageAdministrator, NormalizedName = ApplicationUserRoles.PageAdministrator.ToUpper() });
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole { Id = 400, Name = ApplicationUserRoles.SuperAdministrator, NormalizedName = ApplicationUserRoles.SuperAdministrator.ToUpper() });

            modelBuilder.Entity<RoleToPermissions>().HasData(
                new RoleToPermissions(
                    ApplicationUserRoles.BasicUser,
                    "Basic user",
                    new List<Permission> { Permission.BasicUser }
                )
            );

            modelBuilder.Entity<RoleToPermissions>().HasData(
                new RoleToPermissions(
                    ApplicationUserRoles.AuctionCreator,
                    "Can add, edit or delete own auctions",
                    new List<Permission> { Permission.AccessAdminPanel, Permission.CreateAuction, Permission.ChangeOwnAuction, Permission.RemoveOwnAuction }
                )
            );

            modelBuilder.Entity<RoleToPermissions>().HasData(
                new RoleToPermissions(
                    ApplicationUserRoles.PageAdministrator,
                    "Can add, edit or delete auctions and users",
                    new List<Permission> { Permission.AccessAdminPanel, Permission.CreateAuction, Permission.ChangeAuction, Permission.RemoveAuction, Permission.ReadAllUsers }
                )
            );

            modelBuilder.Entity<RoleToPermissions>().HasData(
                new RoleToPermissions(
                    ApplicationUserRoles.SuperAdministrator,
                    "Can do all possible actions",
                    new List<Permission> { Permission.AccessAll }
                )
            );
        }

        private static void PopulateAuctionStatuses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionStatus>().HasData(
                new AuctionStatus
                {
                    AuctionStatusId = 1,
                    Name = "Aktīva",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionStatus
                {
                    AuctionStatusId = 2,
                    Name = "Pārtraukta",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionStatus
                {
                    AuctionStatusId = 3,
                    Name = "Beigusies",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateVehicleTransmissions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleTransmission>().HasData(
                new VehicleTransmission
                {
                    VehicleTransmissionId = 1,
                    Name = "Automatiskā",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new VehicleTransmission
                {
                    VehicleTransmissionId = 2,
                    Name = "Mehāniskā",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateVehicleFuelTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFuelType>().HasData(
                new VehicleFuelType
                {
                    VehicleFuelTypeId = 1,
                    Name = "Benzīns",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new VehicleFuelType
                {
                    VehicleFuelTypeId = 2,
                    Name = "Dīzelis",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new VehicleFuelType
                {
                    VehicleFuelTypeId = 3,
                    Name = "Benzīns/Naftas gāze",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new VehicleFuelType
                {
                    VehicleFuelTypeId = 4,
                    Name = "Elektroniskais",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new VehicleFuelType
                {
                    VehicleFuelTypeId = 5,
                    Name = "Hibrīds",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateVehicleDimensionTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleDimensionType>().HasData(
                new VehicleDimensionType
                {
                    VehicleDimensionTypeId = 1,
                    Name = "Garums",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new VehicleDimensionType
                {
                    VehicleDimensionTypeId = 2,
                    Name = "Platums",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new VehicleDimensionType
                {
                    VehicleDimensionTypeId = 3,
                    Name = "Augstums",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateItemConditions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemCondition>().HasData(
                new ItemCondition
                {
                    ItemConditionId = 1,
                    Name = "Jauns",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new ItemCondition
                {
                    ItemConditionId = 2,
                    Name = "Lietots",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateItemCompanyTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemCompanyType>().HasData(
                new ItemCompanyType
                {
                    ItemCompanyTypeId = 1,
                    Name = "SIA",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new ItemCompanyType
                {
                    ItemCompanyTypeId = 2,
                    Name = "A/S",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulatePropertyMeasurementTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyMeasurementType>().HasData(
                new PropertyMeasurementType
                {
                    PropertyMeasurementTypeId = 1,
                    Name = "m2",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new PropertyMeasurementType
                {
                    PropertyMeasurementTypeId = 2,
                    Name = "a",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new PropertyMeasurementType
                {
                    PropertyMeasurementTypeId = 3,
                    Name = "ha",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionCategory>().HasData(
                new AuctionCategory
                {
                    CategoryId = 1,
                    Name = "Transports",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionCategory
                {
                    CategoryId = 2,
                    Name = "Manta",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionCategory
                {
                    CategoryId = 3,
                    Name = "Nekustamais īpašums",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionType>().HasData(
                new AuctionType
                {
                    TypeId = 1,
                    Name = "Vieglais transports līdz 3,5t",
                    AuctionCategoryId = 1,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 2,
                    Name = "Traktortehnika",
                    AuctionCategoryId = 1,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 3,
                    Name = "Kravas auto",
                    AuctionCategoryId = 1,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 4,
                    Name = "Mototehnika",
                    AuctionCategoryId = 1,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 5,
                    Name = "Piekabes",
                    AuctionCategoryId = 1,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 6,
                    Name = "Ūdens transports",
                    AuctionCategoryId = 1,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 7,
                    Name = "Cits transports",
                    AuctionCategoryId = 1,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 8,
                    Name = "Biroja tehnika",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 9,
                    Name = "Sadzīves tehnika",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 10,
                    Name = "Instrumenti",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 11,
                    Name = "Iekārtas",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 12,
                    Name = "Ražošanas materiāli",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 13,
                    Name = "Veikala produkcija",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 14,
                    Name = "Uzņēmums",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 15,
                    Name = "Domeins",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 16,
                    Name = "Preču zīme",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 17,
                    Name = "Sadzīves mēbeles",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 18,
                    Name = "Biroja mēbeles",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 19,
                    Name = "Cita manta",
                    AuctionCategoryId = 2,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 20,
                    Name = "Dzīvoklis",
                    AuctionCategoryId = 3,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 21,
                    Name = "Māja",
                    AuctionCategoryId = 3,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 22,
                    Name = "Zeme",
                    AuctionCategoryId = 3,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 23,
                    Name = "Telpa",
                    AuctionCategoryId = 3,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionType
                {
                    TypeId = 24,
                    Name = "Garāža",
                    AuctionCategoryId = 3,
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateAuctionFormats(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionFormat>().HasData(
                new AuctionFormat
                {
                    AuctionFormatId = 1,
                    Name = "Cenu aptauja",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionFormat
                {
                    AuctionFormatId = 2,
                    Name = "Izsole elektroniski",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionFormat
                {
                    AuctionFormatId = 3,
                    Name = "Izsole klātienē",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateAuctionConditions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionCondition>().HasData(
                new AuctionCondition
                {
                    AuctionConditionId = 1,
                    Name = "Lietota",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionCondition
                {
                    AuctionConditionId = 2,
                    Name = "Jauna",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionCondition
                {
                    AuctionConditionId = 3,
                    Name = "Apdzīvots",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionCondition
                {
                    AuctionConditionId = 4,
                    Name = "Neapdzīvots",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                },
                new AuctionCondition
                {
                    AuctionConditionId = 5,
                    Name = "Nepieciešams remonts",
                    CreatedAt = CreatedAtDateTime,
                    // CreatedBy = CreatedByBiddingAdmin,
                    LastUpdatedAt = CreatedAtDateTime,
                    LastUpdatedBy = CreatedByBiddingAdmin
                }
            );
        }

        private static void PopulateRegions(ModelBuilder modelBuilder)
        {
            List<Region> regions = new List<Region>();

            for (int i = 0; i < Regions.Names.Count; i++)
            {
                regions.Add(
                    new Region
                    {
                        RegionId = Regions.Names.Keys.ElementAt(i),
                        Name = Regions.Names[Regions.Names.Keys.ElementAt(i)],
                        CreatedAt = CreatedAtDateTime,
                        // CreatedBy = CreatedByBiddingAdmin,
                        LastUpdatedAt = CreatedAtDateTime,
                        LastUpdatedBy = CreatedByBiddingAdmin
                    }
                );
            }

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
