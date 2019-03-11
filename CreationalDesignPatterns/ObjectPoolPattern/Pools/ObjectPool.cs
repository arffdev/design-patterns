using ObjectPoolPattern.Pools.Abstracts;
using System;
using System.Collections.Concurrent;

namespace ObjectPoolPattern.Pools
{
  public class ObjectPool<T> : AbstractObjectPool<T> where T : new()
  {

    /// <summary>
    /// NOTE: In a real word solution you may use an connection pool or some sort of caching 
    /// instead of a ConcurrentBag but this was the simplist was to show this kind of pattern.
    /// You would also want to make the MAX variable a configurable number instead of hard coded.
    /// </summary>
    public ObjectPool()
    {
      items = new ConcurrentBag<T>();
      counter = 0;
      MAX = 10;
    }

    /// <summary>
    /// Returns object from pool if one exists, 
    /// if none are available we create one and return it
    /// </summary>
    /// <returns></returns>
    public override T Get()
    {
      if (items.TryTake(out T item))
      {
        Console.WriteLine("ACTION: Get existing object");

        counter--;
        return item;
      }
      else
      {
        Console.WriteLine("ACTION: Create new object");

        T obj = new T();
        items.Add(obj);
        counter++;
        return obj;
      }
    }

    /// <summary>
    /// Releases objects that are no longer needed back to the object pool
    /// </summary>
    /// <param name="item"></param>
    public override void Release(T item)
    {
      if (counter < MAX)
      {
        Console.WriteLine("Releasing object");

        items.Add(item);
        counter++;
      }
    }
  }
}
