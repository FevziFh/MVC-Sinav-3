using Sinav.Core.Concretes;
using Sinav.DAL.Context;
using Sinav.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.DAL.Repositories.Concretes
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
