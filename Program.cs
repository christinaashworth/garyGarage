using System;

namespace garyGarage
{ 
  class Program
  {
    static void Main(string[] args) 
    {
      Zero fxs = new Zero()
        { MainColor = "white",
          MaximumOccupancy = "2" };
      Tesla modelS = new Tesla()
        { MainColor = "black",
          MaximumOccupancy = "5" };
      Cessna mx410 = new Cessna()
        { MainColor = "blue",
          MaximumOccupancy = "100" };
      Ram carRam = new Ram()
        { MainColor = "pink",
          MaximumOccupancy = "6" };

      fxs.Drive();
      fxs.Turn("left");
      fxs.Stop();

      modelS.Drive();
      modelS.Turn("right");
       modelS.Stop();
      
      mx410.Drive();
      mx410.Turn("left");
      mx410.Stop();

      carRam.Drive();
      carRam.Turn("right");
      carRam.Stop();
    }
  }
}
