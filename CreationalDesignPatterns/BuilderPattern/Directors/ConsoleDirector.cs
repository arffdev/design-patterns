using BuilderPattern.Builders.Abstracts;

namespace BuilderPattern.Directors
{
  public class ConsoleDirector
  {
    public void Construct(ConsoleBuilder consoleBuilder)
    {
      consoleBuilder.AddName();
      consoleBuilder.AddGraphicsCard();
      consoleBuilder.AddProcessor();
      consoleBuilder.AddMemory();
      consoleBuilder.AddRam();
    }
  }
}
