using AbstractFactoryPattern.Cars.Abstracts;
using System;

namespace AbstractFactoryPattern.Cars
{
  public class Camry : SedanAbstract
  {
    public override void Create()
    {
      Console.WriteLine("Created: " + this.GetType().Name);
    }
  }
}
