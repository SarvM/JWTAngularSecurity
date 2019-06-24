using System;

namespace WebApi.Model
{
    public class AppUserClaim 
    {
        public string ClaimId { get; set;}
        public string UserId { get; set;}
        public string ClaimType { get; set;}
        public string ClaimValue {get;set;}

        public AppUserClaim(string userId, string claimId, string claimType, string claimValue)
        {
            ClaimId = claimId;
            UserId = userId;
            ClaimType = claimType;
            ClaimValue = claimValue;
        }
    }
}