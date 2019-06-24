using System;

namespace WebApi.Model
{
    public class AppUser 
    {
        public string UserId { get; set;}
        public string UserName { get; set;}
        public string UserPassword {get;set;}
        public AppUser(string userId, string userName, string userPassword){
            UserId = userId;
            UserName = userName;
            UserPassword = userPassword;
        }
    }
}