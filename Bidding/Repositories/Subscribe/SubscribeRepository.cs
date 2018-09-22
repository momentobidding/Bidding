﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Bidding.Models.DatabaseModels.Bidding.Subscribe;
using Bidding.Models.ViewModels.Bidding.Subscribe;
using BiddingAPI.Models.DatabaseModels;
using BiddingAPI.Repositories.Subscribe;
using Microsoft.EntityFrameworkCore;

namespace BiddingAPI.Repositories.Subscribe
{
    public class SubscribeRepository : ISubscribeRepository
    {
        private readonly BiddingContext m_context;

        public SubscribeRepository(BiddingContext context)
        {
            m_context = context;
        }

        public async Task<bool> UsingEmailAsync(EmailRequestModel request)
        {
            bool categoryVehicles = (request.Categories.Contains("vehicles")) ? true : false;
            bool categoryItems = (request.Categories.Contains("items")) ? true : false;
            bool categoryCompanies = (request.Categories.Contains("companies")) ? true : false;
            bool categoryBrands = (request.Categories.Contains("brands")) ? true : false;

            Newsletter newsletter = new Newsletter()
            {
                Name = request.Name,
                Email = request.Email,
                Vehicles = categoryVehicles,
                Items = categoryItems,
                Companies = categoryCompanies,
                Brands = categoryBrands,
            };

            m_context.Add(newsletter);
            return await m_context.SaveChangesAsync() == 1;
        }

        public async Task<bool> UsingWhatsAppAsync(WhatsAppRequestModel request)
        {
            bool categoryVehicles = (request.Categories.Contains("vehicle")) ? true : false;
            bool categoryItems = (request.Categories.Contains("items")) ? true : false;
            bool categoryCompanies = (request.Categories.Contains("companies")) ? true : false;
            bool categoryBrands = (request.Categories.Contains("brands")) ? true : false;

            Newsletter newsletter = new Newsletter()
            {
                Name = request.Name,
                Phone = request.Phone,
                Vehicles = categoryVehicles,
                Items = categoryItems,
                Companies = categoryCompanies,
                Brands = categoryBrands,
            };

            m_context.Add(newsletter);
            return await m_context.SaveChangesAsync() == 1;
        }

        public async Task<bool> UsingSurveyAsync(SurveyRequestModel request)
        {
            return true;
        }
    }
}