using System;
using WebApi.Model;
using System.Collections.Generic;

namespace WebApi.Mock_Data
{
    public class UserData
    {
        public static List<AppUser> FetchUser(){
            List<AppUser> users = new List<AppUser>(){
                new AppUser("1764e65d-dbdc-4d0b-8cae-b49b436a923421","John","test"),
                new AppUser("1764e65d-derc-4d0b-8cae-b49b436a923421","Lisa","test"),
                new AppUser("1764e65d-dbas-4d0b-8cae-b49b436a923421","Ann","test")
            };


            return users;
        }
    }
}