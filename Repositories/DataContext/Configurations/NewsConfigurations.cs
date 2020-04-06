using Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Repositories.DataContext.Configurations
{
    public class NewsConfigurations : EntityTypeConfiguration<News>
    {
        public NewsConfigurations()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.Title)
               .IsRequired()
               .HasMaxLength(250)
               .IsConcurrencyToken();

            this.Property(s => s.Thumbnail)
               .IsRequired()
               .HasMaxLength(150)
               .IsConcurrencyToken();

            this.Property(s => s.Author)
               .IsRequired()
               .HasMaxLength(250)
               .IsConcurrencyToken();

            this.Property(s => s.Author)
               .IsRequired()
               .HasMaxLength(100)
               .IsConcurrencyToken();

            this.Property(s => s.HtmlContent)
               .IsRequired()
               .HasColumnType("text");
        }
    }
}
