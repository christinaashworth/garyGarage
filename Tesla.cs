using System;

namespace garyGarage
{
  public class Tesla : Vehicle
  {
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
      // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla hums by you. Shhhh!");
    }
  }
}
