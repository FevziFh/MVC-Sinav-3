using AutoMapper;
using Sinav.Service.DTOs.AppUserDTOs;
using Sinav.UI.Models.VMs.AppUserVMs;

namespace Sinav.UI.Mapper
{
    public class VMMapper :Profile
    {
        public VMMapper()
        {
            //AppUser Mapper
            CreateMap<RegisterVM, RegisterDTO>().ReverseMap();
            CreateMap<LoginVM, LoginDTO>().ReverseMap();
        }
    }
}
