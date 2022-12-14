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

        [HttpGet("{ShowInfoId}",Name = nameof(GetShowInfo))]

        public IActionResult GetShowInfo(string Id)
        {
            var showInfo = _dataService.GetShowInfo(Id);

            if (showInfo == null)
            {
                return NotFound();
            }

            ShowInfoModel model = CreateShowInfoModel(showInfo);

            return Ok(model);
        }

        [HttpDelete("{ShowInfoId}")] 
        public IActionResult DeleteShowInfo(string Id)
        {
            var deleted = _dataService.DeleteShowInfo(Id);

            if (!deleted)
            {
                return NotFound();
            }

            return Ok();
        }

        private ShowInfoModel CreateShowInfoModel(ShowInfo showInfo)
        {
            var model = new ShowInfoModel
            {
                Url = _generator.GetUriByName(HttpContext, nameof(GetShowInfo), new { showInfo.ShowInfoId}),
                Type = showInfo.Type,
                PrimaryTitle = showInfo.PrimaryTitle,
                OriginalTitle = showInfo.OriginalTitle,
                IsAdult = showInfo.IsAdult,
                StartYear = showInfo.StartYear,
                EndYear = showInfo.EndYear,
                RunTime = showInfo.RunTime,
                Poster = showInfo.Poster
            };
            return model;
        }
    }

}