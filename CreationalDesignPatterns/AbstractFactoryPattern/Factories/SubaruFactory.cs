using AbstractFactoryPattern.Cars;
using AbstractFactoryPattern.Cars.Abstracts;
using AbstractFactoryPattern.Factories.Abstracts;

namespace AbstractFactoryPattern.Factories
{
  public class SubaruFactory : CarAbstractFactory
  {
    public override SadanAbstract CreatSadan()
    {
      return new Legacy();
    }

    public override SuvAbstract CreatSuv()
    {
      return new Forester();
    }
  }
}
