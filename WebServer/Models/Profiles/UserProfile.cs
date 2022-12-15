using System;
using AutoMapper;
using DataLayer.Model;
namespace WebServer.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserListModel>();
            CreateMap<User, UserModel>();
        }
    }
}

