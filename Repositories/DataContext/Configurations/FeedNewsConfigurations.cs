using Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Repositories.DataContext.Configurations
{
    public class FeedNewsConfigurations : EntityTypeConfiguration<FeedNews>
    {
        public FeedNewsConfigurations()
        {
            this.HasKey(s => s.Id);
            this.Property(s => s.Name)
               .IsRequired()
               .HasMaxLength(50);
        }
    }
}
