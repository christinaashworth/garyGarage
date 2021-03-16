using System;

namespace garyGarage {
  public class Ram : Vehicle, IGasVehicle  // Gas powered truck
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram trucks along by you. Grrrr!");
    }
  }
}
