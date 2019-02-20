using FactoryMethodPattern.Animals;
using FactoryMethodPattern.Animals.Abstracts;
using FactoryMethodPattern.Spawners.Abstracts;

namespace FactoryMethodPattern.Spawners
{
  public class GeeseSpawner : BirdSpawner
  {
    public override Bird SpawnBird()
    {
      return new Geese();
    }
  }
}
