using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abstractions;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public ArticleController(IArticleService articleService,ICategoryService categoryService,IMapper mapper)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories});
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {

            await articleService.CreateArticleAsync(articleAddDto);
            RedirectToAction("Index", "Article", new { Area = "Admin" });

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var article = await articleService.GetArticleWithCategoryNonDeletedAsync(articleId);
            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdateDto = mapper.Map<ArticleUpdateDto>(article);
            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {

            await articleService.UpdateArticleAysnc(articleUpdateDto);




            var categories = await categoryService.GetAllCategoriesNonDeleted();

            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
        }
    }
}
