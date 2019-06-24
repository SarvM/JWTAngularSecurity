
namespace WebApi.Auth
{
    public class JWTBasicPayload 
    {
        public string Key { get; set;}
        public string Issuer { get; set;}
        public string Audience { get; set;}
        public string MinutesToExpiration { get; set;}

    }
}