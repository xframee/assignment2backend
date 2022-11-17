using System;
using Microsoft.AspNetCore.Mvc;
using DataLayer;
namespace WebServer.Controllers
{
    [Route("api/showInfos")]
    public class ShowInfosController : ControllerBase
    {

        private IDataService _dataService = new DataService();

        [HttpGet]
        public IActionResult Get()
        {
            var showInfos = _dataService.GetShowInfos();
            return Ok(showInfos);
        }

        [HttpGet("{tconst}")]
        public IActionResult GetShowInfo(string tconst)
        {
            var showInfo = _dataService.GetShowInfo(tconst);

            if (showInfo == null)
            {
                return NotFound();
            }

            return Ok(showInfo);
        }
    }

}