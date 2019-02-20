using FactoryMethodPattern.Animals.Abstracts;
using System;

namespace FactoryMethodPattern.Animals
{
  public class Chicken : Bird
  {
    public override void Attack()
    {
      Console.WriteLine(Constants.CHICKEN_ATTACK);
    }

    public override void MakeNoise()
    {
      Console.WriteLine(Constants.CHICKEN_NOISE);
    }
  }
}
