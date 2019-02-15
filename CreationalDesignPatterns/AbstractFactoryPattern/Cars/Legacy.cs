using AbstractFactoryPattern.Cars.Abstracts;
using System;

namespace AbstractFactoryPattern.Cars
{
  public class Legacy : SedanAbstract
  {
    public override void Create()
    {
      Console.WriteLine("Created: " + this.GetType().Name);
    }
  }
}
