﻿using Bidding.Models.DatabaseModels.Auctions;
using Bidding.Models.ViewModels.Auctions.Add;
using Bidding.Models.ViewModels.Auctions.Delete;
using Bidding.Models.ViewModels.Auctions.Details;
using Bidding.Models.ViewModels.Auctions.Edit;
using Bidding.Models.ViewModels.Auctions.List;
using Bidding.Models.ViewModels.Auctions.Shared;
using Bidding.Models.ViewModels.Filters;
using Bidding.Repositories.Auctions;
using Bidding.Services.Shared;
using Bidding.Services.Shared.Permissions;
using Bidding.Shared.Constants;
using Bidding.Shared.ErrorHandling.Errors;
using Bidding.Shared.ErrorHandling.Validators;
using Bidding.Shared.Exceptions;
using Bidding.Shared.Pagination;
using Bidding.Shared.Utility.Validation.Comparers;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Bidding.Services.Auctions
{
    public class AuctionsService
    {
        private readonly PermissionService m_permissionService;
        private readonly AuctionsRepository m_auctionsRepository;

        public AuctionsService(AuctionsRepository auctionRepository, PermissionService permissionService)
        {
            m_permissionService = permissionService ?? throw new ArgumentNullException(nameof(permissionService));
            m_auctionsRepository = auctionRepository ?? throw new ArgumentNullException(nameof(auctionRepository));
        }

        public AuctionListResponseModel GetActiveAuctions(AuctionListRequestModel request)
        {
            ValidateAuctionList(request);

            // note: kke: if the user is not logged in, cant use search functionality!
            if (m_permissionService.GetUserId().IsNotSpecified()) request.SearchValue = null;

            (int startFrom, int endAt) = Pagination.GetOffsetAndSize(request);

            // Note: kke: load only active auctions.
            DateTime fromDate = DateTime.UtcNow;

            AuctionListResponseModel auctionsResponse = new AuctionListResponseModel()
            {
                Auctions = m_auctionsRepository.GetActiveAuctions(request, startFrom, endAt, fromDate).ToList(),
                ItemCount = m_auctionsRepository.ActiveAuctionCount().Count()
            };

            Pagination.PaginateResponse(ref auctionsResponse, TableItem.DefaultSize, request.CurrentPage);

            return auctionsResponse;
        }

        public AuctionListResponseModel GetAllAuctions(AuctionListRequestModel request)
        {
            ValidateAuctionList(request);

            // TODO: kke: validate request.SearchValue to be valid value!

            (int startFrom, int endAt) = Pagination.GetOffsetAndSize(request);

            // Note: kke: load all possible auctions.
            DateTime fromDate = new DateTime(1900, 1, 1);

            AuctionListResponseModel auctionsResponse = new AuctionListResponseModel()
            {
                Auctions = m_auctionsRepository.GetActiveAuctions(request, startFrom, endAt, fromDate).ToList(),
                ItemCount = m_auctionsRepository.AllAuctionCount().Count()
            };

            Pagination.PaginateResponse(ref auctionsResponse, TableItem.DefaultSize, request.CurrentPage);

            return auctionsResponse;
        }

        /// <summary>
        /// Loads all filters, top category filter and sub-category filter
        /// </summary>
        /// <returns></returns>
        public AuctionFilterModel Filters()
        {
            return new AuctionFilterModel()
            {
                TopCategories = m_auctionsRepository.LoadActiveTopCategoriesWithCount().ToList(),
                SubCategories = m_auctionsRepository.LoadActiveSubCategoriesWithCount().ToList()
            };
        }

        public CategoriesWithTypesModel CategoriesWithTypes()
        {
            return new CategoriesWithTypesModel()
            {
                TopCategories = m_auctionsRepository.LoadTopCategories().ToList(),
                SubCategories = m_auctionsRepository.LoadSubCategories().ToList()
            };
        }

        public AuctionFormatModel Formats()
        {
            return new AuctionFormatModel()
            {
                Formats = m_auctionsRepository.Formats().ToList()
            };
        }

        public AuctionStatusModel Statuses()
        {
            return new AuctionStatusModel()
            {
                Statuses = m_auctionsRepository.Statuses().ToList()
            };
        }

        public async Task<AuctionDetailsResponseModel> DetailsAsync(AuctionDetailsRequestModel request)
        {
            if (request.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.AuctionId.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.IncorrectAuction); }

            return await m_auctionsRepository.DetailsAsync(request).ConfigureAwait(true);
        }

        public AuctionEditDetailsResponseModel EditDetails(int auctionId)
        {
            if (auctionId.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }

            return m_auctionsRepository.EditDetails(auctionId);
        }

        public bool UpdateAuctionDetails(AuctionEditRequestModel request)
        {
            ValidateAuctionUpdate(request);

            int loggedInUserId = m_permissionService.GetAndValidateUserId();

            return m_auctionsRepository.UpdateAuctionDetails(request, loggedInUserId);
        }

        public async Task<bool> DeleteAsync(AuctionDeleteRequestModel request)
        {
            ValidateAuctionDelete(request);

            int loggedInUserId = m_permissionService.GetAndValidateUserId();

            return await m_auctionsRepository.DeleteAsync(request, loggedInUserId).ConfigureAwait(true);
        }

        public int Create(AddAuctionRequestModel request)
        {
            if (request.IsNotSpecified()) throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation);
            if (request.AboutAuction.IsNotSpecified()) throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation);
            if (request.AboutAuction.AuctionTopCategoryId.IsNotSpecified()) throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation);

            if (request.AboutAuction.AuctionTopCategoryId == AuctionCategories.Item) return CreateItemAuction(request);
            if (request.AboutAuction.AuctionTopCategoryId == AuctionCategories.Vehicle) return CreateVehicleAuction(request);
            if (request.AboutAuction.AuctionTopCategoryId == AuctionCategories.Property) return CreatePropertyAuction(request);

            throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation);
        }

        /// <summary>
        /// Validate auction list permissions and input values
        /// </summary>
        /// <param name="request"></param>
        private void ValidateAuctionList(AuctionListRequestModel request)
        {
            if (request.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.SortingDirection.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.OffsetStart < 0) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.OffsetEnd.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.CurrentPage < 0) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.SortingDirection != "asc" && request.SortingDirection != "desc") { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }

            // todo: kke: validate sort by columns list!
            // todo: kke: validate if smth else is not missing here!
            if (request.SortByColumn.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            List<string> allowedSortByColumns = new List<string> { "AuctionName", "AuctionStartingPrice", "AuctionStartDate", "AuctionEndDate" };
            if (allowedSortByColumns.Contains(request.SortByColumn) == false) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
        }

        private int CreateItemAuction(AddAuctionRequestModel request)
        {
            // ValidateAuctionItemCreate(request);

            int loggedInUserId = m_permissionService.GetAndValidateUserId();

            return m_auctionsRepository.CreateAuction(request, loggedInUserId);
        }

        private int CreatePropertyAuction(AddAuctionRequestModel request)
        {
            // ValidateAuctionItemCreate(request);

            int loggedInUserId = m_permissionService.GetAndValidateUserId();

            return m_auctionsRepository.CreateAuction(request, loggedInUserId);
        }

        private int CreateVehicleAuction(AddAuctionRequestModel request)
        {
            // ValidateAuctionItemCreate(request);

            int loggedInUserId = m_permissionService.GetAndValidateUserId();

            return m_auctionsRepository.CreateAuction(request, loggedInUserId);
        }

        private void ValidateAuctionItemCreate(string request)
        {
            // if (request.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            // if (request.AuctionName.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionTopCategoryIds.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionSubCategoryIds.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionStartingPrice.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionStartDate.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionApplyTillDate.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionEndDate.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionCreatorId.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            //if (request.AuctionFormatId.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }

            // todo: kke: save all dates to be UTC Format
            // todo: kke: validate all required fields to be specified + max lenghts / min leghts and regular expressions

            // setup auction object for the validation
            //Auction auction = new Auction()
            //{
            //    Name = request.AuctionName,
            //    StartingPrice = request.AuctionStartingPrice,
            //    StartDate = request.AuctionStartDate
            //};

            //ValidateAuction(auction);
        }

        private void ValidateAuction(Auction auction)
        {
            AuctionValidator validator = new AuctionValidator();
            ValidationResult results = validator.Validate(auction);

            bool success = results.IsValid;
            IList<ValidationFailure> failures = results.Errors;

            validator.ValidateAndThrow(auction);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    throw new WebApiException(HttpStatusCode.BadRequest, failure.ErrorMessage);
                }
            }
        }

        /// <summary>
        /// Validate auction update permissions
        /// </summary>
        /// <param name="request"></param>
        private void ValidateAuctionUpdate(AuctionEditRequestModel request)
        {
            if (request.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.AuctionId.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }

            // todo: kke: add missing validation checks!
        }

        private void ValidateAuctionDelete(AuctionDeleteRequestModel request)
        {
            if (request.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation); }
            if (request.AuctionIds.IsNotSpecified()) throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation);
            if (request.AuctionIds.Any(s => s.IsNotSpecified())) throw new WebApiException(HttpStatusCode.BadRequest, AuctionErrorMessages.MissingAuctionsInformation);
        }
    }
}
