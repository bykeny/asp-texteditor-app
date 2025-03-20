using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TextEditor.Models;

namespace TextEditor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Doc> Docs { get; set; }

        //public override int SaveChanges()
        //{
        //    var entries = ChangeTracker.Entries<Doc>();

        //    foreach (var entry in entries)
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.Entity.CreatedAt = DateTime.UtcNow;
        //                entry.Entity.UpdatedAt = DateTime.UtcNow;
        //                break;

        //            case EntityState.Modified:
        //                // Only update UpdatedAt
        //                entry.Entity.UpdatedAt = DateTime.UtcNow;

        //                // Mark CreatedAt as not modified to prevent updates
        //                entry.Property(p => p.CreatedAt).CurrentValue = entry.Property(p => p.CreatedAt).OriginalValue;
        //                entry.Property(p => p.CreatedAt).IsModified = false;
        //                break;
        //        }
        //    }

        //    return base.SaveChanges();
        //}
    }
}
