using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SmartReference.Infrastructure
{
    public class ReferenceContextFactory : IDesignTimeDbContextFactory<ReferenceContext>
    {
        public ReferenceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ReferenceContext>();
            optionsBuilder.UseNpgsql("Data Source=blog.db");

            return new ReferenceContext(optionsBuilder.Options);
        }
    }
}