using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ShareMockups.Models;

namespace ShareMockups.DataContexts
{
    /// <summary>
    /// Two distinct data context, but they're going to talk to the same db connection, they are just going to work with different tables.
    /// </summary>
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            :base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("identity");
            base.OnModelCreating(modelBuilder);
        }
    }
}