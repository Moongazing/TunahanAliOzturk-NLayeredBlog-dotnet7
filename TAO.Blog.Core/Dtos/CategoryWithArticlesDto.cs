using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAO.Blog.Core.Dtos
{
    public class CategoryWithArticlesDto:CategoryDto
    {
        public List<ArticleDto> Articles { get; set; }
    }
}
