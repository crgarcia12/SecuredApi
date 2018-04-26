using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecuredApi.Controllers
{
    [Route("api/[controller]")]
    public class SecuredController : Controller
    {
        // GET api/values
       [HttpGet]
       public IEnumerable<string> Get()
        {
            return new string[] { "SecuredApi>Public", "v3" };
        }

        [HttpGet("{id}")]
        [Authorize]
        public IEnumerable<string> GetDetails(string id)
        {
            return new string[] { "SecuredApi>Private", "v3" };
        }
    }
}