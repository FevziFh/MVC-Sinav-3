using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Sinav.Core.Concretes;
using Sinav.Service.DTOs.AppUserDTOs;
using Sinav.Service.Services.Interfaces;
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
        private readonly IHttpContextAccessor httpContextAccessor;

        public AppUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> GetCurrentUserId()
        {
            AppUser user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);

            return user.Id;
        }

        public async Task<SignInResult> Login(LoginDTO loginDTO)
        {
            AppUser user = await userManager.FindByEmailAsync(loginDTO.Email);
            SignInResult result = await signInManager.PasswordSignInAsync(user.UserName, loginDTO.Password, false, false);

            return result;
        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Register(RegisterDTO registerDTO)
        {
            AppUser user = new AppUser();

            user = mapper.Map<AppUser>(registerDTO);
            registerDTO.Email = "fevzi.Hamdemir@mail.com";
            string FirstName = registerDTO.Email.Split('.').First();
            string LastName = registerDTO.Email.Split(".", '@')[1];
            user.FirstName = FirstName;
            user.LastName = LastName;
            IdentityResult result = await userManager.CreateAsync(user);

            return result;
        }

        public async Task<IdentityResult> UpdateAppUser(UpdateAppUserDTO updateAppUserDTO)
        {
            AppUser user = mapper.Map<AppUser>(updateAppUserDTO);
            IdentityResult result = await userManager.UpdateAsync(user);

            return result;
        }
    }
}
