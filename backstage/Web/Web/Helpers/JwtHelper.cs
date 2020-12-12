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
            var issuer = Configuration.GetValue<string>("JwtSettings:Issuer");
            var signKey = Configuration.GetValue<string>("JwtSettings:SignKey");

            var claims = new List<Claim>();

            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, userName)); 
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())); // JWT ID

            claims.Add(new Claim("roles", "Admin"));
            claims.Add(new Claim("roles", "Users"));

            var userClaimsIdentity = new ClaimsIdentity(claims);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signKey));

            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = issuer,
                Subject = userClaimsIdentity,
                Expires = DateTime.Now.AddMinutes(expireMinutes),
                SigningCredentials = signingCredentials,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var serializeToken = tokenHandler.WriteToken(securityToken);

            return serializeToken;
        }
    }
}
