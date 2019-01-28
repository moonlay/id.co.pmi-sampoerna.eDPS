using System.Data.Entity.Infrastructure;

namespace Core.Data.EntityFramework
{
    public class StorageOptions
    {
        public DbCompiledModel NameOrConnectionString { get; set; }
    }
}