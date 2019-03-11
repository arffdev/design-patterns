using ObjectPoolPattern.Pools;
using ObjectPoolPattern.RandomObjects;
using System;

namespace ObjectPoolPattern
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("---------------");
      Console.WriteLine("Object Pool Example:");

      Console.WriteLine("Create Object Pool");
      ObjectPool<MessageObject> pool = new ObjectPool<MessageObject>();

      MessageObject obj = pool.Get();
      Console.WriteLine("Object: " + obj.Get());

      Console.WriteLine("\nSince we have grabbed an object it was created");
      Console.WriteLine("now if we try to grab it again it will already exist and return the same one\n");

      MessageObject anotherObj = pool.Get();
      Console.WriteLine("Another Object: " + anotherObj.Get());

      Console.WriteLine("\nNow that we are done with the object we return it to the pool");
      pool.Release(obj);

      Console.ReadKey();
    }
  }
}
