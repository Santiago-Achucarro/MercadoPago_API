using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MercadoPago_API.Model.System.Configurations
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "8089a9fe-65aa-42ce-9845-02de53af73f3", // admin
                    RoleId = "7654a20d-4fc7-445a-8a65-ba24e504cc6b"  // Administrador
                });
        }
    }
}
