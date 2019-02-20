using FactoryMethodPattern.Animals;
using FactoryMethodPattern.Animals.Abstracts;
using FactoryMethodPattern.Spawners.Abstracts;

namespace FactoryMethodPattern.Spawners
{
  public class CrowSpawner : BirdSpawner
  {
    public override Bird SpawnBird()
    {
      return new Crow();
    }
  }
}
