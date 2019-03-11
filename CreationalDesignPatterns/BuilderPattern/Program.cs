using System;
using BuilderPattern.Builders;
using BuilderPattern.Builders.Abstracts;
using BuilderPattern.Directors;

namespace BuilderPattern
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ConsoleBuilder builder;

      // Director
      ConsoleDirector director = new ConsoleDirector();

      // Builders
      builder = new NintendoBuilder();
      director.Construct(builder);
      builder.VideogameConsole.DisplaySpecs();

      builder = new MicrosoftBuilder();
      director.Construct(builder);
      builder.VideogameConsole.DisplaySpecs();

      builder = new SonyBuilder();
      director.Construct(builder);
      builder.VideogameConsole.DisplaySpecs();

      Console.ReadKey();
    }
  }
}
