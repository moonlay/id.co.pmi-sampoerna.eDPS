using System.Data.Entity;

namespace Core.Data.EntityFramework
{
    public class StorageDbContext : DbContext
    {
        public StorageDbContext(IOptions<StorageOptions> options)
            : base(options.Value.NameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}