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
    public class TopicRepository : BaseRepository<Topic> , ITopicRepository
    {
        public TopicRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
