using System; 

namespace garyGarage 
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("Vrooom!");
    }
    public virtual void Turn(string direction)
    {
      Console.WriteLine($"The car turns {direction}");
    }
    public virtual void Stop()
    {
      Console.WriteLine($"The car comes to a stop.");
    }
  }
}
