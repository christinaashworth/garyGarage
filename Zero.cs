using System;

namespace garyGarage
{
  public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
  {
    public double BatteryKWh { get; set; }

    public double CurrentChargePercentage { get; set; }
    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero whispers by you. HEEEEY!");
    }

    public override void Turn(string direction)
    {
    Console.WriteLine($"The Zero tries to turn {direction}, but comes to a screeching halt when the driver sees a kitten on the sidewalk who looks hungry!");
    }
    public override void Stop()
    {
    Console.WriteLine("Don't worry, once the Zero stopped for the kitten, the driver was able to redirect it to its mother.");
    }
  }  
}
