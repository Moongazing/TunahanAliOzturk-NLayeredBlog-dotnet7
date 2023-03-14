using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Blog.Core.Models;

namespace TAO.Blog.Core.Repositories
{
    public interface ICategoryRepository:IGenericRepository<Category> 
    {

        Task<Category> GetSingleCategoryByIdWithArticlesAsync(int categoryId);
    }
}
