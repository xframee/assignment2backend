using System;
using Microsoft.AspNetCore.Mvc;
using DataLayer;
using WebServer.Models;
using DataLayer.Model;

namespace WebServer.Controllers
{
    [Route("api/showInfos")]
    public class ShowInfosController : ControllerBase
    {

        private IDataService _dataService;
        private readonly LinkGenerator _generator;

        public ShowInfosController(IDataService dataService, LinkGenerator generator)
        {
            _dataService = dataService;
            _generator = generator; 
        }

        [HttpGet]
        public IActionResult GetShowInfos()
        {
            var showInfos = _dataService.GetShowInfos();
            return Ok(showInfos);
        }

        [HttpGet("{tconst}",Name = nameof(GetShowInfo))]

        public IActionResult GetShowInfo(string tconst)
        {
            var showInfo = _dataService.GetShowInfo(tconst);

            if (showInfo == null)
            {
                return NotFound();
            }

            ShowInfoModel model = CreateShowInfoModel(showInfo);

            return Ok(model);
        }

        private ShowInfoModel CreateShowInfoModel(ShowInfo showInfo)
        {
            var model = new ShowInfoModel
            {
                Url = _generator.GetUriByName(HttpContext, nameof(GetShowInfo), new { showInfo.TConst }),
                Type = showInfo.Type,
                PrimaryTitle = showInfo.PrimaryTitle,
                OriginalTitle = showInfo.OriginalTitle,
                IsAdult = showInfo.IsAdult,
                StartYear = showInfo.StartYear,
                EndYear = showInfo.EndYear,
                RunTime = showInfo.RunTime
            };
            return model;
        }
    }

}