using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.DTOs.ArticleDTOs
{
    public class GetArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int TopicId { get; set; }
        public string AppUserId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
