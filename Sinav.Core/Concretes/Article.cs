using Sinav.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Core.Concretes
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
