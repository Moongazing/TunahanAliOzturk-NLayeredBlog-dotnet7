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
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(AppDbContext context):base(context)
        {
            
        }

        public async Task<List<Article>> GetArticlesWithCategoryAsync()
        {
            return await _context.Articles.Include(a => a.Category).ToListAsync();
        }
    }
}
