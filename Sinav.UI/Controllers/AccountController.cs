using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sinav.Service.DTOs.AppUserDTOs;
using Sinav.Service.Services.Interfaces;
using Sinav.UI.Models.VMs.AppUserVMs;

namespace Sinav.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAppUserService appUserService;
        private readonly IMapper mapper;

        public AccountController(IAppUserService appUserService, IMapper mapper)
        {
            this.appUserService = appUserService;
            this.mapper = mapper;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                LoginDTO loginDTO = mapper.Map<LoginDTO>(loginVM);
                Microsoft.AspNetCore.Identity.SignInResult signInResult = await appUserService.Login(loginDTO);
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await appUserService.Logout();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                RegisterDTO registerDTO = mapper.Map<RegisterDTO>(registerVM);
                appUserService.Register(registerDTO);
                return RedirectToAction("Index", "Home");
            }
            else
                return View(registerVM);
        }
    }
}
