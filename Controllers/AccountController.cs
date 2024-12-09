using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MercadoPago_API.Model.System;
using MercadoPago_API.Model.System.DTO;
using MercadoPago_API.Persistence;
using MercadoPago_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace MercadoPago_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext appDbContext;
        private readonly AccountService accountService;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public AccountController(
            AppDbContext AppContent, AccountService AccountService, IMapper Mapper, IConfiguration Configuration)
        {
            appDbContext = AppContent;
            accountService = AccountService;
            mapper = Mapper;
            configuration = Configuration;
        }

        // GET: api/Account
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUserDTO>>> GetAllUsers()
        {
            var users = mapper.Map<IEnumerable<AppUserDTO>>(await accountService.GetAllUsers());

            foreach (var u in users)
            {
                u.Roles = (await accountService.GetUserRoles(u.UserName)).ToList();
            }

            return Ok(users);
        }

        // GET: api/Account/admin
        [HttpGet("{userName}", Name = "GetUser")]
        public async Task<ActionResult<AppUser>> GetUser(string userName)
        {
            var user = await accountService.GetUser(userName);

            if (user == null)
                return NotFound();
            
            return Ok(user);
        }

        // POST: api/Account
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<AppUser>> CreateUser([FromBody] AppUserDTO AppUserDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await accountService.AddUser(mapper.Map<AppUser>(AppUserDTO), AppUserDTO.Password);
    
            if (!result.Succeeded)
                return BadRequest(result);

            var user = await accountService.GetUser(AppUserDTO.UserName);             

            return CreatedAtAction(nameof(GetUser), new { userName = user.UserName }, user);
        }

        // PUT: api/Account/admin
        [HttpPut("{userName}")]
        public async Task<ActionResult<AppUser>> UpdateUser(string userName, [FromBody] AppUserDTO AppUserDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (userName.ToUpper() != AppUserDTO.UserName.ToUpper())
                return BadRequest();

            var userToUpdate = await accountService.GetUser(userName);

            await accountService.UpdateUser(mapper.Map<AppUserDTO, AppUser>(AppUserDTO, userToUpdate));

            return Ok(AppUserDTO);
        }

        // DELETE: api/account/abc
        [HttpDelete("{userName}")]
        public async Task<IActionResult> DeleteUser(string UserName)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await accountService.GetUser(UserName);

            if (user == null)
                return NotFound();

            var result = await accountService.RemoveUser(user);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok();
        }

        // GET: api/Account/role
        [HttpGet("role")]
        public async Task<ActionResult<IEnumerable<IdentityRoleDTO>>> GetAllRoles()
        {
            return Ok(mapper.Map<IEnumerable<IdentityRoleDTO>>(await accountService.GetAllRoles()));
        }

        // GET: api/Account/role/administrador
        [HttpGet("role/{roleName}", Name = "GetRole")]
        public async Task<ActionResult<IdentityRoleDTO>> GetRole(string RoleName)
        {
            return Ok(mapper.Map<IdentityRoleDTO>(await accountService.GetRole(RoleName)));
        }

        // POST: api/Account/role
        [HttpPost("role")]
        public async Task<ActionResult<IdentityRoleDTO>> CreateRole([FromBody] string Role)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var role = new IdentityRole() { Name = Role };
            var result = await accountService.AddRole(role);

            if (!result.Succeeded)
                return BadRequest(result);

            return CreatedAtAction(nameof(GetRole), new { RoleName = role.Name }, mapper.Map<IdentityRoleDTO>(role));
        }

        // GET: api/Account/admin/role
        [HttpGet("{userName}/role", Name = "GetUserRoles")]
        public async Task<ActionResult<IEnumerable<string>>> GetUserRoles(string userName)
        {
            var userRoles = await accountService.GetUserRoles(userName);

            if (userRoles == null)
                return NotFound();

            return Ok(userRoles);
        }
        
        // PUT: api/Account/admin/roles
        [HttpPut("{userName}/roles")]
        public async Task<IActionResult> AddRolesToUser(string userName, [FromBody] string[] roles)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await accountService.AddRolesToUser(userName, roles);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok();
        }

        // POST: api/account/login
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UserToken>> Login([FromBody]LoginDTO loginDTO)
        {
            var result = await accountService.Login(loginDTO.UserName, loginDTO.Password);

            if (result.Succeeded)
                return BuildToken(
                    await accountService.GetUser(loginDTO.UserName),
                    await accountService.GetUserRoles(loginDTO.UserName),
                    loginDTO.RememberMe);

            return BadRequest(result);
        }

        private UserToken BuildToken(AppUser appUser, IEnumerable<string> userRoles, bool rememberMe)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, appUser.UserName),
                new Claim("fullName", appUser.FullName),
            };

            if (appUser.DynamicsId != null)
                claims.Add(new Claim("dynamicsId", appUser.DynamicsId));

            foreach (var role in userRoles)
            {
                //claims.Add(new Claim(ClaimTypes.Role, role));
                claims.Add(new Claim("roles", role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiration = rememberMe ? DateTime.UtcNow.AddMonths(3) : DateTime.UtcNow.AddHours(24);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: creds
            );

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }
    }
}
