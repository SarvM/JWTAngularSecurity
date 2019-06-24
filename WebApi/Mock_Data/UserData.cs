using System;
using WebApi.Model;
using System.Collections.Generic;

namespace WebApi.Mock_Data
{
    public class UserData
    {
        public static List<AppUser> FetchUser()
        {
            List<AppUser> users = new List<AppUser>()
            {
                new AppUser("1764e65d-dbdc-4d0b-8cae-b49b436a923421","John","test"),
                new AppUser("1764e65d-derc-4d0b-8cae-b49b436a923443","Lisa","test"),
                new AppUser("1764e65d-dbas-4d0b-8cae-b49b436a923465","Ann","test")
            };

            return users;
        }

        public static List<AppUserClaim> FetchUserClaim()
        {
            List<AppUserClaim> userClaims = new List<AppUserClaim>()
            {
                //John 
                new AppUserClaim("1764e65d-dbdc-4d0b-8cae-b49b436a923421","1764e65d-dbdc-4d0b-8cae-b49b436a92342123","CanAccessPremimum","true"),
                new AppUserClaim("1764e65d-dbdc-4d0b-8cae-b49b436a923421","1764e65d-dbdc-4d0b-8cae-b49b436a923421sd","CanAccessStandard","true"),
                new AppUserClaim("1764e65d-dbdc-4d0b-8cae-b49b436a923421","1764e65d-dbdc-4d0b-8cae-b49b436a923421er","CanEnrollPremimum","false"),
                new AppUserClaim("1764e65d-dbdc-4d0b-8cae-b49b436a923421","1764e65d-dbdc-4d0b-8cae-b49b436a923421re","CanEnrollStandard","false"),
                //Lisa
                new AppUserClaim("1764e65d-derc-4d0b-8cae-b49b436a923443","1764e65fd-dbdc-4d0b-8cae-b49b436a92342123","CanAccessPremimum","true"),
                new AppUserClaim("1764e65d-derc-4d0b-8cae-b49b436a923443","1764e65fdd-dbdc-4d0b-8cae-b49b436a923421sd","CanAccessStandard","true"),
                new AppUserClaim("1764e65d-derc-4d0b-8cae-b49b436a923443","1764e65ed-dbdc-4d0b-8cae-b49b436a923421er","CanEnrollPremimum","true"),
                new AppUserClaim("1764e65d-derc-4d0b-8cae-b49b436a923443","1764e6d5d-dbdc-4d0b-8cae-b49b436a923421re","CanEnrollStandard","false"),
                //Ann
                new AppUserClaim("1764e65d-dbas-4d0b-8cae-b49b436a923465","1764e6e5d-dbdc-4d0b-8cae-b49b436a92342123","CanAccessPremimum","false"),
                new AppUserClaim("1764e65d-dbas-4d0b-8cae-b49b436a923465","1764e6sd5d-dbdc-4d0b-8cae-b49b436a923421sd","CanAccessStandard","true"),
                new AppUserClaim("1764e65d-dbas-4d0b-8cae-b49b436a923465","1764e6ds5d-dbdc-4d0b-8cae-b49b436a923421er","CanEnrollPremimum","false"),
                new AppUserClaim("1764e65d-dbas-4d0b-8cae-b49b436a923465","1764e6sd5d-dbdc-4d0b-8cae-b49b436a923421re","CanEnrollStandard","true"),
            };

            return userClaims;
        }
    }
}