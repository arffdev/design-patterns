using System;
using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Factories.Abstracts;

namespace AbstractFactoryPattern
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Abstract Factory Pattern");
      Console.WriteLine("\nSubaru Factory");
      CarAbstractFactory subaruFactory = new SubaruFactory();
      subaruFactory.CreatSadan().Create();
      subaruFactory.CreatSuv().Create();

      Console.WriteLine("\nToyota Factory");
      CarAbstractFactory ToyotaFactory = new ToyotaFactory();
      ToyotaFactory.CreatSadan().Create();
      ToyotaFactory.CreatSuv().Create();

      Console.WriteLine("\nPress any key to exit...");
      Console.ReadKey(true);
    }
  }
}
