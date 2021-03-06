﻿using Bidding.Models.ViewModels.Subscribe;
using Bidding.Repositories.Subscribe;
using Bidding.Shared.Exceptions;
using Bidding.Shared.Utility.Validation.Comparers;
using System;
using System.Collections.Generic;
using System.Net;

namespace Bidding.Services.Subscribe
{
    public class SubscribeService : ISubscribeService
    {
        private readonly ISubscribeRepository m_subscribeRepository;

        public SubscribeService(ISubscribeRepository subscribeRepository)
        {
            m_subscribeRepository = subscribeRepository ?? throw new ArgumentNullException(nameof(subscribeRepository));
        }

        public bool UsingEmail(EmailRequestModel request)
        {
            if (request.Categories.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, "Incorrect categories"); }
            if (request.Email.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, "Incorrect email"); }
            if (request.Name.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, "Incorrect name"); }

            // ValidateCategories(request.Categories);

            return m_subscribeRepository.UsingEmail(request);
        }

        public bool UsingWhatsApp(WhatsAppRequestModel request)
        {
            if (request.Categories.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, "Incorrect categories"); }
            if (request.Phone.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, "Incorrect phone"); }
            if (request.Name.IsNotSpecified()) { throw new WebApiException(HttpStatusCode.BadRequest, "Incorrect name"); }

            // ValidateCategories(request.Categories);

            return m_subscribeRepository.UsingWhatsApp(request);
        }

        private bool ValidateCategories(List<string> categories)
        {
            List<string> validCategories = new List<string>(new string[] { "vehicles", "items", "estate" });

            foreach (string category in categories)
            {
                if (!validCategories.Contains(category))
                {
                    throw new WebApiException(HttpStatusCode.BadRequest, "Something is wrong with the categories!");
                }
                else
                {
                    return true;
                }
            }

            return true;
        }
    }
}
