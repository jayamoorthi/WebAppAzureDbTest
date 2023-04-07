using Microsoft.EntityFrameworkCore;
using WebAppAzureDBTest.Models;
using WebAppAzureDBTest.Models.NewFolder;

namespace WebAppAzureDBTest.Data
{
    public class MySqlTestDbContext : DbContext
    {
        public MySqlTestDbContext(DbContextOptions<MySqlTestDbContext> optionsBuilder):base(optionsBuilder)
           
        {
        }

        public DbSet<Todo> Todo { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Todo>(new TodoConfiguration());
        }

        
    }
}
