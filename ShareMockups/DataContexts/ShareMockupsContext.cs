using ShareMockups.DomainClasses;
using System.Data.Entity;
using System.Diagnostics;

namespace ShareMockups.DataContexts
{
    public class ShareMockupsContext : DbContext
    {
        public ShareMockupsContext() : base("DefaultConnection")
        {
            Database.Log = sql => Debug.Write(sql);   // I am doing this in the constructor, so every instance of DbContext will be logging something
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("mockups");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ShareMockup> ShareMockups { get; set; } // DbSet for the most part, will be mapped to a table.
    }
}
