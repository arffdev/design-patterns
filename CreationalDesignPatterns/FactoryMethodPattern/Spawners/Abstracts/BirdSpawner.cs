using FactoryMethodPattern.Animals.Abstracts;

namespace FactoryMethodPattern.Spawners.Abstracts
{
  /// <summary>
  /// This is the factory abstract method... spawner is a funnier name
  /// </summary>
  public abstract class BirdSpawner
  {
    public abstract Bird SpawnBird();
  }
}
