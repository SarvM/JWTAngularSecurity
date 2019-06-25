using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using System.Collections.Generic;
using WebApi.Mock_Data;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers 
{

  [Route("api/[controller]")]
  [Authorize]
  public class PackageController : ControllerBase
  {
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(PackageData.FetchPackage());
         
    }

    [HttpGet("{id}", Name = "Get")]
    public IActionResult Enroll(int id)
    {
        return Ok();
    }

  }

}