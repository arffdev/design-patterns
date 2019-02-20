using FactoryMethodPattern.Animals;
using FactoryMethodPattern.Animals.Abstracts;
using FactoryMethodPattern.Spawners.Abstracts;

namespace FactoryMethodPattern.Spawners
{
  public class ChickenSpawner : BirdSpawner
  {
    public override Bird SpawnBird()
    {
      return new Chicken();
    }
  }
}
