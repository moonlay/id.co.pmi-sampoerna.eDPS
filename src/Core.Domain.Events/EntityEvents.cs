namespace Core.Domain.Events
{
    public class OnEntityCreated<T> : IDomainEvent
    {
        public OnEntityCreated(T entity)
        {
            Entity = entity;
        }

        public T Entity { get; private set; }
    }

    public class OnEntityUpdated<T> : IDomainEvent
    {
        public OnEntityUpdated(T entity)
        {
            Entity = entity;
        }

        public T Entity { get; private set; }
    }

    public class OnEntityDeleted<T> : IDomainEvent
    {
        public OnEntityDeleted(T entity)
        {
            Entity = entity;
        }

        public T Entity { get; private set; }
    }
}