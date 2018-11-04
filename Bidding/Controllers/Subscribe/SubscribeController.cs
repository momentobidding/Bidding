﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bidding.Models.ViewModels.Bidding.Subscribe;
using BiddingAPI.Services.Subscribe;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bidding.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscribeController : Controller
    {
        public readonly ISubscribeService m_subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            m_subscribeService = subscribeService ?? throw new ArgumentNullException(nameof(subscribeService));
        }

        [HttpPut]
        public IActionResult UsingEmail([FromBody] EmailRequestModel request)
        {
            return Ok(m_subscribeService.UsingEmail(request));
        }

        [HttpPut]
        public IActionResult UsingWhatsApp([FromBody] WhatsAppRequestModel request)
        {
            return Ok(m_subscribeService.UsingWhatsApp(request));
        }

        [HttpPut]
        public IActionResult UsingSurvey([FromBody] SurveyRequestModel request)
        {
            return Ok(m_subscribeService.UsingSurvey(request));
        }
    }
}
