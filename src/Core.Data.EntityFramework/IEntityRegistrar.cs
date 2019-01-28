using System.Data.Entity;

namespace Core.Data
{
    public interface IEntityRegistrar
    {
        void Builder(DbModelBuilder modelBuilder);
    }
}