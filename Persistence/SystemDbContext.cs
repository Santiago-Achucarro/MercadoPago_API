using MercadoPago_API.Model.System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MercadoPago_API.Persistence
{
    public class SystemDbContext : IdentityDbContext<AppUser>
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
               .ApplyConfigurationsFromAssembly(
                    Assembly.GetExecutingAssembly(), x => x.Namespace == "MercadoPago_API.Model.System.Configurations");

            // Override default AspNet Identity table names
            modelBuilder.Entity<AppUser>(entity => { entity.ToTable(name: "AL_Users"); });
            modelBuilder.Entity<IdentityRole>(entity => { entity.ToTable(name: "AL_Roles"); });
            modelBuilder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("AL_UserRoles"); });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("AL_UserClaims"); });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("AL_UserLogins"); });
            modelBuilder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("AL_UserTokens"); });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("AL_RoleClaims"); });
        }
    }
}
