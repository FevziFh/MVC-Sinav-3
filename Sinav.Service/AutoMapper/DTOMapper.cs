using AutoMapper;
using Sinav.Core.Concretes;
using Sinav.Service.DTOs.AppUserDTOs;
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
        }
    }
}
