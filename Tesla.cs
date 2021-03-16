using System;

namespace garyGarage
{
  public class Tesla : Vehicle, IElectricVehicle
  {
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }


    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla hums by you. Shhhh!");
    }
  }
}
