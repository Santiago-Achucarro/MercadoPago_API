using MercadoPago_API.Model.System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoPago_API.Services
{
    public class AccountService
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager; 
        private readonly SignInManager<AppUser> signInManager;

        public AccountService(
            UserManager<AppUser> UserManager, 
            RoleManager<IdentityRole> RoleManager, 
            SignInManager<AppUser> SignInManager)
        {
            userManager = UserManager;
            roleManager = RoleManager;
            signInManager = SignInManager;
        }

        public async Task<AppUser> GetUser(string UserName)
        {
            return await userManager.FindByNameAsync(UserName);
        }

        public async Task<IEnumerable<AppUser>> GetAllUsers()
        {
            return await userManager.Users.ToListAsync();
        }

        public async Task<IdentityResult> AddUser(AppUser User, string Password)
        {
            return await userManager.CreateAsync(User, Password);
        }

        public async Task<IdentityResult> UpdateUser(AppUser User)
        {
            return await userManager.UpdateAsync(User);
        }

        public async Task<IdentityResult> RemoveUser(AppUser User)
        {
            return await userManager.DeleteAsync(User);
        }

        public async Task<SignInResult> Login(string UserName, string PassWord)
        {
            return await this.Login(UserName, PassWord, false, false);
        }

        public async Task<SignInResult> Login(string UserName, string PassWord, bool IsPersistent, bool LockoutOnFailure)
        {
            return await signInManager.PasswordSignInAsync(
                UserName, PassWord, isPersistent: IsPersistent, lockoutOnFailure: LockoutOnFailure);
        }

        public async Task<IdentityRole> GetRole(string RoleName)
        {
            return await roleManager.FindByNameAsync(RoleName);
        }

        public async Task<IEnumerable<IdentityRole>> GetAllRoles()
        {
            return await roleManager.Roles.ToListAsync();
        }

        public async Task<IEnumerable<string>> GetUserRoles(string UserName)
        {
            return await userManager.GetRolesAsync(await GetUser(UserName));
        }

        public async Task<IdentityResult> AddRole(IdentityRole Role)
        {
            return await roleManager.CreateAsync(Role);
        }

        public async Task<IdentityResult> UpdateRole(IdentityRole Role)
        {
            return await roleManager.UpdateAsync(Role);
        }

        public async Task<IdentityResult> RemoveRole(IdentityRole Role)
        {
            return await roleManager.DeleteAsync(Role);
        }

        public async Task<IdentityResult> AddRolesToUser(string UserName, string[] Roles)
        {
            var user = await GetUser(UserName);
            if (user == null)
                throw new Exception("Usuario inexistente");

            var roles = await userManager.GetRolesAsync(user);
            await this.userManager.RemoveFromRolesAsync(user, roles.ToArray());
            return await this.userManager.AddToRolesAsync(user, Roles);
        }
    }
}
