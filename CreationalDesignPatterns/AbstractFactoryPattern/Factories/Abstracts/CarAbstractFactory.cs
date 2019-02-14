using AbstractFactoryPattern.Cars.Abstracts;

namespace AbstractFactoryPattern.Factories.Abstracts
{
  public abstract class CarAbstractFactory
  {
    public abstract SadanAbstract CreatSadan();
    public abstract SuvAbstract CreatSuv();
  }
}
