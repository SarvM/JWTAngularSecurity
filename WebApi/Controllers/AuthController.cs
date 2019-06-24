using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Auth;
using WebApi.Model;


namespace WebApi.Controllers 
{
  [Route("api/[controller]")]
  public class AuthController : ControllerBase
  {
    private JWTBasicPayload _configuraton;
    
    public AuthController(JWTBasicPayload configuration)
    {
        _configuraton = configuration;
    }

    [HttpPost("Login")]
    public IActionResult Login([FromBody]AppUser user)
    {
        AppUserAuth auth = new AppUserAuth();
        AuthManager mgr = new AuthManager(_configuraton);
        return Ok(mgr.ValidateUser(user));
    }
  }
}