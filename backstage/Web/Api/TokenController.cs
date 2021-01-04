using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Web.Filters;
using Web.Helpers;

namespace Web.Api
{
    [ApiController]
    [TokenAuthentication]
    public class TokenController : ControllerBase
    {
        private readonly JwtHelper jwt;

        public TokenController(JwtHelper jwt)
        {
            this.jwt = jwt;
        }

        public string UserName 
        {
            get { return User.Identity.Name; }
        }

        [HttpPost("~/parent")]
        public ActionResult parentAction()
        {
            return new JsonResult("i am pa");
        }

        [AllowAnonymous]
        [HttpPost("~/signin")]
        public ActionResult SignIn(UserModel user)
        {
            if (CheckUser(user.Uid))
            {
                return new JsonResult(jwt.GenerateToken(user.Uid));
            }
            return new JsonResult(HttpStatusCode.BadRequest);
        }

        public static bool CheckUser(string username)
        {
            return true;
        }

        public class UserModel
        {
            public string Uid { get; set; }
            public string Password { get; set; }
        }
    }
}
