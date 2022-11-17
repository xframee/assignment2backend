using System;
using Microsoft.AspNetCore.Mvc;
namespace WebServer.Controllers
{
    [Route("api/showInfos")]
    public class ShowInfosController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from controller";
        }
    }
}

