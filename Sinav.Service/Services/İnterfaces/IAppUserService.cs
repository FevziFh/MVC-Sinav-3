﻿using Microsoft.AspNetCore.Identity;
using Sinav.Service.DTOs.AppUserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.Services.İnterfaces
{
    public interface IAppUserService
    {
        Task<IdentityResult> Register(RegisterDTO registerDTO);
        Task<SignInResult> Login(LoginDTO loginDTO);
        Task Logout();
    }
}
