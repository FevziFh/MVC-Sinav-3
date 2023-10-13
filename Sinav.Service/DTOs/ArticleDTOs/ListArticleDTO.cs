using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.DTOs.ArticleDTOs
{
    public class ListArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TopicId { get; set; }
        public string AppUserId { get; set; }
    }
}
