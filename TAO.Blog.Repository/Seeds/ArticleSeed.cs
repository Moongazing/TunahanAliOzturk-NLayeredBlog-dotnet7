using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TAO.Blog.Core.Models;

namespace TAO.Blog.Repository.Seeds
{
    public class ArticleSeed : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "DDR4 RAM",
                    Subject = "About New Tech Ram",
                    Content = "This is a test article",
                    CreateDate = DateTime.Now,
                    NumberOfLetters = 13
                },

                 new Article
                 {
                     Id = 2,
                     CategoryId = 2,
                     Title = "Developers",
                     Subject = "About New Junior Developers",
                     Content = "This is a test article for developers",
                     CreateDate = DateTime.Now,
                     NumberOfLetters = 20
                 }
                );
        }
    }
}
