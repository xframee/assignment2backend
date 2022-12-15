using System;
using AutoMapper;
using DataLayer;
using DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/users")]
    [ApiController]

    public class UsersController : ControllerBase
    {

        private IDataService _dataService;
        private readonly LinkGenerator _generator;
        private readonly IMapper _mapper;

        public UsersController(IDataService dataService, LinkGenerator generator, IMapper mapper)
        {

            _dataService = dataService;
            _generator = generator;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _dataService.GetUsers().Select(x => CreateUserModel(x));

            return Ok(users);
        }

        
        [HttpGet("{userId}", Name = nameof(GetUser))]

        public IActionResult GetUser(string UserId)
        {
            var user = _dataService.GetUser(UserId);

            if (user == null)
            {
                return NotFound();
            }

            UserListModel model = CreateUserModel(user);

            return Ok(model);
        }

        /*
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
        public IActionResult Crea(UserCreateModel model)
        {
            var user = _mapper.Map<User>(model);

            _dataService.CreateShowInfo(user);

            return CreatedAtRoute(null, CreateUserModel(user));
        } */


        private UserListModel CreateUserModel(User user)
        {
            var model = _mapper.Map<UserListModel>(user);
            model.Url = _generator.GetUriByName(HttpContext, nameof(GetUser), new { user.Username });
            return model;
        }
    }
}


