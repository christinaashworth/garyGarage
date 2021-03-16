using System;

namespace garyGarage
{
  public interface IElectricVehicle
  {
    double BatteryKWh { get; set; }

    double CurrentChargePercentage { get; set; }
    void ChargeBattery();
  }
}
