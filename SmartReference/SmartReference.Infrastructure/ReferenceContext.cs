using Microsoft.EntityFrameworkCore;
using SmartReference.Domain.Models;

namespace SmartReference.Infrastructure
{
    public class ReferenceContext : DbContext
    {
        public ReferenceContext(DbContextOptions<ReferenceContext> options) : base(options)
        {
        }

        public DbSet<Reference> References { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ReferenceTag> ReferenceTags { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //     => optionsBuilder.UseNpgsql($"Data Source={DbPath}");
    }
}