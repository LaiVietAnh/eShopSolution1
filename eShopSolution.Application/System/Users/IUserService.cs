using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRequest = eShopSolution.ViewModels.System.Users.LoginRequest;
using RegisterRequest = eShopSolution.ViewModels.System.Users.RegisterRequest;

namespace eShopSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);
    }
}
