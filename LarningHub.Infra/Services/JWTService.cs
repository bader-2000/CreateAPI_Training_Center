using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using LarningHub.Core.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Services
{
    public class JWTService : IJWTService
    {
        private IJWTRepository _jwtRepository;
        public JWTService(IJWTRepository jwtRepository) 
        {
            jwtRepository = _jwtRepository;
        }
        public string AuthLogin(Login login)
        {
            var result = _jwtRepository.AuthLogin(login);
            if (result == null)
            {
                return null;

            }
            else
            {
                var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKeyBader@345"));
                var signcredintals = new SigningCredentials(secretkey, SecurityAlgorithms.Aes128CbcHmacSha256);

                var claims = new List<Claim>
                {
                    new Claim  (ClaimTypes.Name, result.Username),
                    new Claim  (ClaimTypes.Role, result.Roleid.ToString())
                };

                var tokenOption = new JwtSecurityToken(
                claims: claims, expires: DateTime.Now.AddDays(1), signingCredentials: signcredintals
                );
                var tokenAsString =  new JwtSecurityTokenHandler().WriteToken(tokenOption); 

                return tokenAsString;
            }
            
        }
    }
}
