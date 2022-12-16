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

        [HttpGet(Name = nameof(GetUsers))]
        public IActionResult GetUsers()
        {
            var users = _dataService.GetUsers().Select(x => CreateUserModel(x));

            return Ok(users);
        }

        
        [HttpGet("{Username}", Name = nameof(GetUser))]

        public IActionResult GetUser(string Username)
        {
            var user = _dataService.GetUser(Username);

            if (user == null)
            {
                return NotFound();
            }

            UserModel model = CreateUserModel(user);

            return Ok(model);
        }

        
        [HttpDelete("{Username}")]
        public IActionResult DeleteUser(string Username)
        {
            var deleted = _dataService.DeleteUser(Username);

            if (!deleted)
            {
                return NotFound();
            }

            return Ok();
        } 

        [HttpPost]
        public IActionResult CreateUser(UserCreateModel model)
        {
            var user = _mapper.Map<User>(model);

            _dataService.CreateUser(user);

            return CreatedAtRoute(null, CreateUserModel(user));
        }


        private UserModel CreateUserModel(User user)
        {
            var model = _mapper.Map<UserModel>(user);
            model.Url = _generator.GetUriByName(HttpContext, nameof(GetUser), new { user.Username });
            return model;
        }
    }
}


