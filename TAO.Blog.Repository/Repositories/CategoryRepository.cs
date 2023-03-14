using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Blog.Core.Models;
using TAO.Blog.Core.Repositories;

namespace TAO.Blog.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context):base(context)
        {
            
        }

        public async Task<Category> GetSingleCategoryByIdWithArticlesAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Articles).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
