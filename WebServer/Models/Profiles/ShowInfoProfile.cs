using System;
using AutoMapper;
using DataLayer;
using DataLayer.Model;
namespace WebServer.Models.Profiles
{
    public class ShowInfoProfile : Profile 
    {
        public ShowInfoProfile()
        {
            CreateMap<ShowInfo, ShowInfoModel>();
            CreateMap<ShowInfoCreateModel, ShowInfo>();
        }
    }
}

