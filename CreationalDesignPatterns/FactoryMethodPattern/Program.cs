using FactoryMethodPattern.Animals;
using FactoryMethodPattern.Animals.Abstracts;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
  public class Program
  {
    /// <summary>
    /// Just imagine doing something more useful here with your created objects instead of just putting text on a console
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
      List<Bird> birdList = new List<Bird>();

      // add birds to list
      for(var i = 0; i < 10; i++)
      {
        birdList.Add(new Chicken());
        birdList.Add(new Crow());
        birdList.Add(new Geese());
      }

      Console.WriteLine("--------------------------");
      Console.WriteLine("Birds are spawning everywhere!");
      Console.ReadKey();

      // birds spawn noise
      foreach (var bird in birdList)
      {
        Console.Write(bird.GetType().Name + ":");
        bird.MakeNoise();
      }

      Console.WriteLine("--------------------------");
      Console.WriteLine("Birds are attacking!");
      Console.ReadKey();

      // birds attacking
      foreach (var bird in birdList)
      {
        Console.Write(bird.GetType().Name + ":");
        bird.Attack();
      }

      Console.WriteLine("--------------------------");
      Console.WriteLine("You are dead!");
      Console.ReadKey();
    }
  }
}
