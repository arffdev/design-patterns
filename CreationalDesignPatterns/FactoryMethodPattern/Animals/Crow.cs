using FactoryMethodPattern.Animals.Abstracts;
using System;

namespace FactoryMethodPattern.Animals
{
  public class Crow : Bird
  {
    public override void Attack()
    {
      Console.WriteLine(Constants.CROW_ATTACK);
    }

    public override void MakeNoise()
    {
      Console.WriteLine(Constants.CROW_NOISE);
    }
  }
}
