using Sinav.Service.DTOs.ArticleDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.Services.Interfaces
{
    public interface IArticleService
    {
        public bool CreateArticle(CreateArticleDTO articleDTO);
        public bool UpdateArticle(UpdateArticleDTO articleDTO);
        public bool DeleteArticle(int id);
        public GetArticleDTO GetArticle(int id);
        public List<ListArticleDTO> GetAllArticles();
    }
}
