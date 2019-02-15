using System;

namespace BuilderPattern.Products
{
  public class VideogameConsole
  {
    private string _brand;

    public VideogameConsole(string brand)
    {
      _brand = brand;
    }

    public string Name { get; set; }
    public string GraphicsCard { get; set; }
    public string Processor { get; set; }
    public string Memory { get; set; }
    public string Ram { get; set; }

    public void DisplaySpecs()
    {
      Console.WriteLine($"\nBrand: {_brand}");
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"GPU: {GraphicsCard}");
      Console.WriteLine($"CPU: {Processor}");
      Console.WriteLine($"Storage: {Memory}");
      Console.WriteLine($"RAM: {Ram}");
    }
  }
}
