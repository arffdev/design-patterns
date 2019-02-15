using AbstractFactoryPattern.Cars.Abstracts;

namespace AbstractFactoryPattern.Factories.Abstracts
{
  public abstract class CarAbstractFactory
  {
    public abstract SedanAbstract CreatSedan();
    public abstract SuvAbstract CreatSuv();
  }
}
