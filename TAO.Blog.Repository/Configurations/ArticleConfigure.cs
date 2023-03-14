using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Blog.Core.Models;

namespace TAO.Blog.Repository.Configurations
{
    public class ArticleConfigure : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Content).IsRequired();
            builder.ToTable("Articles");
            builder.HasOne(x => x.Category).WithMany(x=>x.Articles).HasForeignKey(x=>x.CategoryId);
        }
    }
}
