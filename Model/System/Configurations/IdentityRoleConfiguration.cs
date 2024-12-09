using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MercadoPago_API.Model.System.Configurations
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Id = Guid.Parse("7654a20d-4fc7-445a-8a65-ba24e504cc6b").ToString(),
                        Name = "Administrador",
                        NormalizedName = "ADMINISTRADOR",
                        ConcurrencyStamp = Guid.Parse("67434c58-fbdd-44d1-a38a-c4c98c9a2033").ToString()
                    },
                    new IdentityRole
                    {
                        Id = Guid.Parse("faad2796-0f8a-4e19-ba20-f9103798a0db").ToString(),
                        Name = "Usuario",
                        NormalizedName = "USUARIO",
                        ConcurrencyStamp = Guid.Parse("26e3c217-5f97-43ec-bd02-65a1a9734dcf").ToString()
                    },
                    new IdentityRole
                    {
                        Id = Guid.Parse("f212f557-c8a5-4424-81a8-5eb3b31fa3b3").ToString(),
                        Name = "Vendedor",
                        NormalizedName = "VENDEDOR",
                        ConcurrencyStamp = Guid.Parse("66e98899-1124-43ec-994c-d985dd1145a2").ToString()
                    },
                    new IdentityRole
                    {
                        Id = Guid.Parse("76f5cfbb-b91e-43b7-8c86-855d3d0ecfbb").ToString(),
                        Name = "Proveedor",
                        NormalizedName = "PROVEEDOR",
                        ConcurrencyStamp = Guid.Parse("a38f2014-d2f1-462d-8f26-19d672affe40").ToString()
                    },
                    new IdentityRole
                    {
                        Id = Guid.Parse("a8f151ec-25fc-4eb8-ad50-ae0e9861c2e4").ToString(),
                        Name = "Cliente",
                        NormalizedName = "CLIENTE",
                        ConcurrencyStamp = Guid.Parse("b9a80d99-e2bf-4348-85f5-770fb624451b").ToString()
                    }
                );
        }
    }
}
