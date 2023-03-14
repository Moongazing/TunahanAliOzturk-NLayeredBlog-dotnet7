using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAO.Blog.Core.Dtos
{
    public class ArticleDto:BaseDto
    {
        public int CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Subject { get; set; }
        public int NumberOfLetters { get; set; }
    }
}
