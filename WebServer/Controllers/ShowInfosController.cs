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
        public JsonResult Get()
        {

            var showInfos = _dataService.GetShowInfos();
            return new JsonResult(showInfos);
        }
    }

}