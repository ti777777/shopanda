using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Web.Helpers
{

    public class JwtHelper
    {
        private readonly IConfiguration Configuration;
        public JwtHelper(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public string GenerateToken(string userName, int expireMinutes = 30)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userName)
            };

            var secretBytes = Encoding.UTF8.GetBytes(Constants.Secret);
            var key = new SymmetricSecurityKey(secretBytes);
            var algorithm = SecurityAlgorithms.HmacSha256;

            var signingCredentials = new SigningCredentials(key, algorithm);

            var token = new JwtSecurityToken(
                Constants.Issuer,
                Constants.Audiance,
                claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(1),
                signingCredentials);

            var tokenJson = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenJson;
        }
    }
}
