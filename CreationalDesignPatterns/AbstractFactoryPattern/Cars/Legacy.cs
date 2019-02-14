using AbstractFactoryPattern.Cars.Abstracts;
using System;

namespace AbstractFactoryPattern.Cars
{
  public class Legacy : SadanAbstract
  {
    public override void Create()
    {
      Console.WriteLine("Created: " + this.GetType().Name);
    }
  }
}
