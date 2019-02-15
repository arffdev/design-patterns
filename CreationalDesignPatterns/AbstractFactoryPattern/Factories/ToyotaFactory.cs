using AbstractFactoryPattern.Cars;
using AbstractFactoryPattern.Cars.Abstracts;
using AbstractFactoryPattern.Factories.Abstracts;

namespace AbstractFactoryPattern.Factories
{
  public class ToyotaFactory : CarAbstractFactory
  {
    public override SedanAbstract CreatSedan()
    {
      return new Camry();
    }

    public override SuvAbstract CreatSuv()
    {
      return new Highlander();
    }
  }
}
