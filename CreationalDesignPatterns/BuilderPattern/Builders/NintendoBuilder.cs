using System;
using System.Collections.Generic;
using System.Text;
using BuilderPattern.Builders.Abstracts;
using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
  public class NintendoBuilder : ConsoleBuilder
  {
    public NintendoBuilder()
    {
      console = new VideogameConsole("Nintendo");
    }

    public override void AddName()
    {
      console.Name = "Switch";
    }

    public override void AddGraphicsCard()
    {
      console.GraphicsCard = "Nvidia customized Tegra processor";
    }

    public override void AddMemory()
    {
      console.Memory = "32GB flash storage";
    }

    public override void AddProcessor()
    {
      console.Processor = "Nvidia customized Tegra processor";
    }

    public override void AddRam()
    {
      console.Ram = "4GB";
    }
  }
}
