using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Blog.Core.Dtos;
using TAO.Blog.Core.Models;

namespace TAO.Blog.Core.Services
{
    public interface IArticleService:IService<Article>
    {
        Task<CustomResponseDto<CategoryWithArticlesDto>> GetArticlesWithCategoryAsync();
    }
}
