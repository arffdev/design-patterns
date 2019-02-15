using BuilderPattern.Products;

namespace BuilderPattern.Builders.Abstracts
{
  public abstract class ConsoleBuilder
  {
    protected VideogameConsole console;

    public VideogameConsole VideogameConsole
    {
      get { return console; }
    }

    public abstract void AddName();
    public abstract void AddGraphicsCard();
    public abstract void AddProcessor();
    public abstract void AddMemory();
    public abstract void AddRam();
  }
}
