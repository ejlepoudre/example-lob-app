﻿using ELA.App.Security;
using ELA.Common.BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELA.App.Controllers.Frontend
{
    [Route("api/fe/orders")]
    [Authorize(Policy = Policies.InteractiveUserAccess)]
    public class OrdersController : Controller
    {
        private IInteractiveUserQueryService _userQueries;

        public OrdersController(IInteractiveUserQueryService userQueries)
        {
            _userQueries = userQueries;
        }

        [HttpGet("pending")]
        public async Task<IActionResult> GetPendingOrdersAsync()
        {
            var customers = await _userQueries.GetPendingOrdersAsync();
            return Ok(customers);
        }
    }
}
