using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinav.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.DAL.Configurations.SeedData
{
    public class AppUserSeedData : IEntityTypeConfiguration<AppUser>
    {
        //internal static Guid memberid = Guid.NewGuid();
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            builder.HasData(
                new AppUser()
                {
                    Id = IdGenerate.idGenerate.ToString(),
                    FirstName = "fevzi",
                    LastName = "hamdemir",
                    Email = "fevzi.hamdemir@mail.com",
                    PhoneNumber = "05300355564",
                    PasswordHash = passwordHasher.HashPassword(null, "123")
                }
                );
        }
    }
}
