using AutoMapper;
using Sinav.Core.Concretes;
using Sinav.Service.DTOs.AppUserDTOs;
using Sinav.Service.DTOs.ArticleDTOs;
using Sinav.Service.DTOs.TopicDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.AutoMapper
{
    public class DTOMapper : Profile
    {
        public DTOMapper()
        {
            //App User Mapper
            CreateMap<AppUser, RegisterDTO>().ReverseMap();
            CreateMap<AppUser, UpdateAppUserDTO>().ReverseMap();

            //Article Mapper
            CreateMap<Article,CreateArticleDTO>().ReverseMap();
            CreateMap<Article, ListArticleDTO>().ReverseMap();
            CreateMap<Article, UpdateArticleDTO>().ReverseMap();
            CreateMap<Article, GetArticleDTO>().ReverseMap();

            //Topic Mapper
            CreateMap<Topic, UpdateTopicDTO>().ReverseMap();
            CreateMap<Topic, CreateTopicDTO>().ReverseMap();
        }
    }
}
