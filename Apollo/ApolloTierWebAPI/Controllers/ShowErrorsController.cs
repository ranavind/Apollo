using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Exceptional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloTierWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowErrorsController : ControllerBase
    {
        [HttpGet]
        public async Task Exceptions()
        {
            await ExceptionalMiddleware.HandleRequestAsync(HttpContext).ConfigureAwait(false);
        }
    }
}
