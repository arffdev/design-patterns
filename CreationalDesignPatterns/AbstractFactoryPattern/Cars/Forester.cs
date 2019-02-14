using AbstractFactoryPattern.Cars.Abstracts;
using System;

namespace AbstractFactoryPattern.Cars
{
  public class Forester : SuvAbstract
  {
    public override void Create()
    {
      Console.WriteLine("Created: " + this.GetType().Name);
    }
  }
}
