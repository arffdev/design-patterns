using System;
using System.Collections.Generic;
using System.Text;
using BuilderPattern.Builders.Abstracts;
using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
  public class MicrosoftBuilder : ConsoleBuilder
  {
    public MicrosoftBuilder()
    {
      console = new VideogameConsole("Microsoft");
    }

    public override void AddName()
    {
      console.Name = "xBox One X";
    }

    public override void AddGraphicsCard()
    {
      console.GraphicsCard = "1.172GHz AMD Custom GPU";
    }

    public override void AddMemory()
    {
      console.Memory = "1TB HDD";
    }

    public override void AddProcessor()
    {
      console.Processor = "2.3GHz 8-core AMD Custom CPU";
    }

    public override void AddRam()
    {
      console.Ram = "12GB GDDR5";
    }
  }
}
