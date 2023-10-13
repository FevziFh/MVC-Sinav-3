using AutoMapper;
using Sinav.Core.Concretes;
using Sinav.DAL.Repositories.Interfaces;
using Sinav.Service.DTOs.ArticleDTOs;
using Sinav.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository articleRepository;
        private readonly IMapper mapper;

        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            this.articleRepository = articleRepository;
            this.mapper = mapper;
        }

        public bool CreateArticle(CreateArticleDTO articleDTO)
        {
            Article article = mapper.Map<Article>(articleDTO);
            return articleRepository.Add(article);            
        }

        public bool DeleteArticle(int id)
        {
            return articleRepository.Delete(articleRepository.GetById(id));
        }

        public List<ListArticleDTO> GetAllArticles()
        {
            IList<Article> articles = articleRepository.GetAll().ToList();

            IList<ListArticleDTO> listArticleDTOs = mapper.Map<IList<Article>, IList<ListArticleDTO>>(articles);

            return listArticleDTOs.ToList();
        }

        public GetArticleDTO GetArticle(int id)
        {
            Article article = articleRepository.GetById(id);
            GetArticleDTO articleDTO = mapper.Map<GetArticleDTO>(article);

            return articleDTO;
        }

        public bool UpdateArticle(UpdateArticleDTO articleDTO)
        {
            Article article = mapper.Map<Article>(articleDTO);

            return articleRepository.Update(article);
        }
    }
}
