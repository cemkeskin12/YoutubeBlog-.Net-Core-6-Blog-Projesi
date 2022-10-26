using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task UpdateArticleAysnc(ArticleUpdateDto articleUpdateDto);
    }
}
