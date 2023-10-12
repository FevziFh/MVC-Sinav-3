using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Sinav.Core.Concretes;
using Sinav.Service.DTOs.AppUserDTOs;
using Sinav.Service.Services.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.Services.Concretes
{
    public class AppUserService : IAppUserService
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;

        public AppUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        public async Task<SignInResult> Login(LoginDTO loginDTO)
        {
            SignInResult signInResult = await signInManager.PasswordSignInAsync(loginDTO.UserName, loginDTO.Password, false, false);

            return signInResult;
        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Register(RegisterDTO registerDTO)
        {
            AppUser appUser = mapper.Map<AppUser>(registerDTO);

            IdentityResult result = await userManager.CreateAsync(appUser, registerDTO.Password);

            return result;
        }
    }
}
