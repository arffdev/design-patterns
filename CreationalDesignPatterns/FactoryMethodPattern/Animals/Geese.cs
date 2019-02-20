using FactoryMethodPattern.Animals.Abstracts;
using System;

namespace FactoryMethodPattern.Animals
{
  public class Geese : Bird
  {
    public override void Attack()
    {
      Console.WriteLine(Constants.GEESE_ATTACK);
    }

    public override void MakeNoise()
    {
      Console.WriteLine(Constants.GEESE_NOISE);
    }
  }
}
