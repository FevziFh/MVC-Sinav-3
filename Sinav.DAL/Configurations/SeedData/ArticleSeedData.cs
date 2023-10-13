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
    public class ArticleSeedData : IEntityTypeConfiguration<Article>
    {
        AppUserSeedData appUserId = new AppUserSeedData();
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article()
                {
                    Id = 1,
                    Title = "c#-1",
                    Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                    AppUserId = IdGenerate.idGenerate.ToString(),
                    TopicId = 2,
                },
                new Article()
                {
                    Id = 2,
                    Title = "Lorem Ipsum",
                    Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                    AppUserId = IdGenerate.idGenerate.ToString(),
                    TopicId = 1,
                },
                new Article()
                {
                    Id = 3,
                    Title = "Lorem Ipsum",
                    Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                    AppUserId = IdGenerate.idGenerate.ToString(),
                    TopicId = 1,
                },
                 new Article()
                 {
                     Id = 4,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 5,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 2,
                 },
                 new Article()
                 {
                     Id = 6,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 7,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 8,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 2,
                 },
                 new Article()
                 {
                     Id = 9,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 10,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 1,
                 },
                     new Article()
                     {
                         Id = 11,
                         Title = "c#-1",
                         Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                         AppUserId = IdGenerate.idGenerate.ToString(),
                         TopicId = 2,
                     },
                new Article()
                {
                    Id = 12,
                    Title = "Lorem Ipsum",
                    Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                    AppUserId = IdGenerate.idGenerate.ToString(),
                    TopicId = 1,
                },
                new Article()
                {
                    Id = 13,
                    Title = "Lorem Ipsum",
                    Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                    AppUserId = IdGenerate.idGenerate.ToString(),
                    TopicId = 1,
                },
                 new Article()
                 {
                     Id = 14,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 15,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 2,
                 },
                 new Article()
                 {
                     Id = 16,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 17,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 18,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 2,
                 },
                 new Article()
                 {
                     Id = 19,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 3,
                 },
                 new Article()
                 {
                     Id = 20,
                     Title = "Lorem Ipsum",
                     Body = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –",
                     AppUserId = IdGenerate.idGenerate.ToString(),
                     TopicId = 1,
                 }
                );
        }
    }
}
