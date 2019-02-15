using BuilderPattern.Builders.Abstracts;
using BuilderPattern.Products;
using System;

namespace BuilderPattern.Builders
{
  public class SonyBuilder : ConsoleBuilder
  {
    public SonyBuilder()
    {
      console = new VideogameConsole("Sony");
    }
    
    public override void AddName()
    {
      console.Name = "PS4 Pro";
    }

    public override void AddGraphicsCard()
    {
      console.GraphicsCard = " 4.2 TFLOP AMD Radeon (36CU, 911MHz)";
    }

    public override void AddMemory()
    {
      console.Memory = "1TB HDD";
    }

    public override void AddProcessor()
    {
      console.Processor = "2.1GHz 8-core AMD Jaguar";
    }

    public override void AddRam()
    {
      console.Ram = "8GB GDDR5 + 1GB RAM";
    }
  }
}
