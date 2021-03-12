using System;

namespace garyGarage {
  public class Ram : Vehicle  // Gas powered truck
  {
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
      // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram trucks along by you. Grrrr!");
    }
  }
}
