using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using WebApi.Mock_Data;
using WebApi.Model;
using System.Collections.Generic;
using System.Security.Claims;

namespace WebApi.Auth
{
    public class AuthManager
    {
        private JWTBasicPayload _configuraton;
        public AuthManager(JWTBasicPayload configuration)
        {
            _configuraton = configuration;
        }

        public AppUserAuth ValidateUser(AppUser user)
        {
            AppUserAuth ret = new AppUserAuth();

            AppUser usr = UserData.FetchUser().Find(t => t.UserName == user.UserName);
            if(usr != null) ret = BuildUserAuthObject(usr);
            return ret;

        }

        protected AppUserAuth BuildUserAuthObject(AppUser authUser)
        {
            AppUserAuth ret = new AppUserAuth();
            //List<AppUserClaim> claims = new List<AppUserClaim>();

            // Set User Properties
            ret.UserName = authUser.UserName;
            ret.IsAuthenticated = true;
            ret.BearerToken = new Guid().ToString();

            // Get all claims for this user
            //ret.Claims = GetUserClaims(authUser);

            // Set JWT bearer token
            ret.BearerToken = BuildJwtToken(ret);

            return ret;
        }

        protected string BuildJwtToken(AppUserAuth authUser)
        {
            SymmetricSecurityKey key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuraton.Key));

            // Create standard JWT claims
            List<Claim> jwtClaims = new List<Claim>();
            jwtClaims.Add(new Claim(JwtRegisteredClaimNames.Sub, authUser.UserName));
            jwtClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

            // Add custom claims
            //foreach (var claim in authUser.Claims)
            //{
            //    jwtClaims.Add(new Claim(claim.ClaimType, claim.ClaimValue));
            //}

            // Create the JwtSecurityToken object
            var token = new JwtSecurityToken(
                issuer: _configuraton.Issuer,
                audience: _configuraton.Audience,
                claims: null,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(
                    double.Parse(_configuraton.MinutesToExpiration)),
                signingCredentials: new SigningCredentials(key,
                            SecurityAlgorithms.HmacSha256)
            );

            // Create a string representation of the Jwt token
            return new JwtSecurityTokenHandler().WriteToken(token); 
        }

    }
}