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
    public class TopicSeedData : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasData(
                new Topic()
                {
                    Id = 1,
                    TopicName = "Java",
                },
                new Topic()
                {
                    Id = 2,
                    TopicName = "C#",
                },
                 new Topic()
                 {
                     Id = 3,
                     TopicName = "MVC",
                 }
                );
        }
    }
}
