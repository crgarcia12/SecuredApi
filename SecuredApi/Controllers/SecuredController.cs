using System.Collections.Generic;
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
            return new string[] { "SecuredApi", "v2" };
        }
    }
}