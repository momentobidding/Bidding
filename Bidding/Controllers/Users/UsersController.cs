﻿using Bidding.Models.ViewModels.Admin.Users.List;
using Bidding.Models.ViewModels.Users.Edit;
using Bidding.Services.Users;
using FeatureAuthorize.PolicyCode;
using Microsoft.AspNetCore.Mvc;
using PermissionParts;
using System;
using System.Threading.Tasks;

namespace Bidding.Controllers.Users
{
    [Produces("application/json")]
    [Route("api/[Controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly UsersService m_userService;

        public UsersController(UsersService userService)
        {
            m_userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpGet]
        public async Task<IActionResult> Details([FromQuery] int userId)
        {
            return Ok(await m_userService.UserDetails(userId).ConfigureAwait(true));
        }

        /// <summary>
        /// Load basic user details for edit modal, for example,
        /// name, phone, email.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> EditBasicDetails([FromQuery] int userId)
        {
            return Ok(await m_userService.EditBasicDetails(userId).ConfigureAwait(true));
        }

        /// <summary>
        /// Load advanced user details for edit modal, for example,
        /// basic user details + role, subscription information and so on.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [HasPermission(Permission.ReadAllUsers)]
        public async Task<IActionResult> EditAdvancedDetails([FromQuery] int userId)
        {
            return Ok(await m_userService.EditAdvancedDetails(userId).ConfigureAwait(true));
        }

        [HttpPut]
        public async Task<IActionResult> EditBasic([FromBody] EditBasicDetailsRequestModel request)
        {
            return Ok(await m_userService.EditBasicAsync(request).ConfigureAwait(true));
        }

        [HttpPut]
        [HasPermission(Permission.ReadAllUsers)]
        public async Task<IActionResult> EditAdvanced([FromBody] EditAdvancedDetailsRequestModel request)
        {
            return Ok(await m_userService.EditAdvancedAsync(request).ConfigureAwait(true));
        }

        [HttpGet]
        [HasPermission(Permission.ReadAllUsers)]
        public async Task<IActionResult> Search([FromQuery] UserListRequestModel request)
        {
            return Ok(await m_userService.ListWithSearchAsync(request).ConfigureAwait(true));
        }
    }
}
