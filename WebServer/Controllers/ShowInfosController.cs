using System;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DataLayer;
using WebServer.Models;
using DataLayer.Model;

namespace WebServer.Controllers
{
    [Route("api/showInfos")]
    [ApiController]

    public class ShowInfosController : ControllerBase
    {

        private IDataService _dataService;
        private readonly LinkGenerator _generator;
        private readonly IMapper _mapper;

        public ShowInfosController(IDataService dataService, LinkGenerator generator, IMapper mapper)
        {

            _dataService = dataService;
            _generator = generator;
            _mapper = mapper;
        }
        /*
        [HttpGet]
        public IActionResult GetShowInfos(int page = 0, int pageSize = 10)
        {
            var showInfos = _dataService.GetShowInfos(page, pageSize).Select(x => CreateShowInfoModel(x));

            return Ok(showInfos);
        }
        */
        
        [HttpGet]
        public IActionResult GetShowInfos(string? search = null, int page = 0, int pageSize = 10)
        {

            if (string.IsNullOrEmpty(search))
            {
                var showInfos = _dataService.GetShowInfos(page, pageSize).Select(x => CreateShowInfoModel(x));

                return Ok(showInfos);
            }
            var data = _dataService.GetShowInfoByName(search, page, pageSize);
            return Ok(data);
        }

        [HttpGet("{ShowInfoId}", Name = nameof(GetShowInfo))]

        public IActionResult GetShowInfo(string ShowinfoId)
        {
            var showInfo = _dataService.GetShowInfo(ShowinfoId);

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

        [HttpPost]
        public IActionResult CreateShowInfo(ShowInfoCreateModel model)
        {
            var showInfo = _mapper.Map<ShowInfo>(model);
              
            _dataService.CreateShowInfo(showInfo);

            return CreatedAtRoute(null, CreateShowInfoModel(showInfo));
        }


        private ShowInfoModel CreateShowInfoModel(ShowInfo showInfo)
        {
            var model = _mapper.Map< ShowInfoModel > (showInfo);
            model.Url = _generator.GetUriByName(HttpContext, nameof(GetShowInfo), new { showInfo.ShowInfoId });
            return model;
        }

    }

}