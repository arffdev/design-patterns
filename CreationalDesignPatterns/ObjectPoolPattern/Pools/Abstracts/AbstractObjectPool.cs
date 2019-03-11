using System.Collections.Concurrent;

namespace ObjectPoolPattern.Pools.Abstracts
{
  public abstract class AbstractObjectPool<T>
  {
    public ConcurrentBag<T> items;
    public int counter;
    public int MAX;

    public abstract void Release(T item);
    public abstract T Get();
  }
}
