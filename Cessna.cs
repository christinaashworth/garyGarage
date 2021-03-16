using System;

namespace garyGarage
{
  public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }
     public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna flies by you. Flooooomph!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The Cessna turns the opposite of {direction}");
    }
    public override void Stop()
    {
      Console.WriteLine("The Cessna was not cleared for landing, so it ended up circling for 10 minutes before it could land.");
    }
  }
}
