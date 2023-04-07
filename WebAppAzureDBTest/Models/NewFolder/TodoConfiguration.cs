using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebAppAzureDBTest.Models.NewFolder
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x. Description);
        }
    }
}
