using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAO.Blog.Core.Models
{
    public class Article:BaseEntity
    {
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Title { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
        public int NumberOfLetters { get; set; }

    }
}
