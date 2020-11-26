using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IGP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
            [HttpGet]
           public ActionResult GetAuth()
            {
            return Ok(DateTime.Now);
            }
    }
}