using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sinav.Core.Concretes;
using Sinav.DAL.Configurations.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.DAL.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //SeedData
            builder.ApplyConfiguration(new AppUserSeedData());
            builder.ApplyConfiguration(new TopicSeedData());
            builder.ApplyConfiguration(new ArticleSeedData());

            base.OnModelCreating(builder);
        }
    }
}
