namespace Core
{
    public interface IOptions<T>
    {
        T Value { get; }
    }

    public class Options<T> : IOptions<T>
    {
        public Options()
        {
            Value = System.Activator.CreateInstance<T>();
        }

        public T Value { get; private set; }
    }
}