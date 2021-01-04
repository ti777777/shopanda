using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helpers;

namespace Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

        [HttpGet]
        public ActionResult Index()
        {
            return new JsonResult("Hello");
        }

        [Authorize(AuthenticationSchemes = "OAuth")]
        [HttpGet("~/api/Member/Secret")]
        public ActionResult Secret()
        {
            return new JsonResult(User.Identity.Name);
        }
    }
}
