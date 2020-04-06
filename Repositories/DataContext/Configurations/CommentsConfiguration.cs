using Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Repositories.DataContext.Configurations
{
    public class CommentsConfiguration : EntityTypeConfiguration<Comments>
    {
        public CommentsConfiguration()
        {
            this.HasKey(s => s.Id);
            this.Property(s => s.Comment)
               .IsRequired()
               .HasColumnType("varchar(MAX)");
        }
    }
}
