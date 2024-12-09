using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MercadoPago_API.Model.System.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var admin = new AppUser
            {
                Id = Guid.Parse("8089a9fe-65aa-42ce-9845-02de53af73f3").ToString(),
                FullName = "Administrador",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "martingreco@implementacionesi.com.ar",
                NormalizedEmail = "MARTINGRECO@IMPLEMENTACIONESI.COM.AR",
                PhoneNumber = "",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.Parse("d1b0c2f3-c9a4-4772-a925-ddeb2b4f64a6").ToString(),
                ConcurrencyStamp = Guid.Parse("dd3f4804-342f-47c6-9d48-b622db5c5ef8").ToString(),
                PasswordHash = "AQAAAAEAACcQAAAAEKsqzkEB79ohyHitAHjI4wblzUgUoJKYGXmpIEfvjC2vLIKaf5vbKJ/6vqeUTB/Y7Q==" // Soporte1
            };

            //var passHash = new PasswordHasher<User>();
            //admin.PasswordHash = passHash.HashPassword(admin, "Soporte1");

            builder
                .HasData(admin);

            builder
                .Property(e => e.Id).ValueGeneratedOnAdd();

            builder.ToTable("AL_Users");
        }

    }
}
