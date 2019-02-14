using System;
using AbstractFactoryPattern.Cars.Abstracts;

namespace AbstractFactoryPattern.Cars
{
  public class Highlander : SuvAbstract
  {
    public override void Create()
    {
      Console.WriteLine("Created: " + this.GetType().Name);
    }
  }
}
