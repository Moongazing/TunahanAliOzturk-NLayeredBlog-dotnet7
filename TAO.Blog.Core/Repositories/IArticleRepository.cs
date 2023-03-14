using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Blog.Core.Models;

namespace TAO.Blog.Core.Repositories
{
    public interface IArticleRepository:IGenericRepository<Article>
    {
        Task<List<Article>> GetArticlesWithCategoryAsync();
    }
}
