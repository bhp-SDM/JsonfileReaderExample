namespace JsonfileReaderExample.Core.Interfaces
{
    public interface IRepository<T>
    {
        public T[] Items { get;}
        T[] GetAllItems();
    }
}
