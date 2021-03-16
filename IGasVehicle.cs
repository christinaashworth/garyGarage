using System;

namespace garyGarage
{
  public interface IGasVehicle
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }


    public void RefuelTank()
    {
      // method definition omitted
    }
  }
}
