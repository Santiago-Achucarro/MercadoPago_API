using AutoMapper;
using MercadoPago_API.Model.System.DTO;
using Microsoft.AspNetCore.Identity;

namespace MercadoPago_API.Model.System.Mapping
{
    public class SystemAutoMapping : Profile
    {
        public SystemAutoMapping()
        {
            CreateMap<AppUser, PreferenciaMpDTO>()
                .ReverseMap();

            CreateMap<IdentityRole, IdentityRoleDTO>()
                .ReverseMap();
        }
    }
}
