using System;
namespace task3
{
	internal class Car:Vehicle
	{
		public double CurrentFuel;
		public double FuelFor1Km;

        public override void Drive(double km)
        {
            CurrentFuel -= FuelFor1Km * km;
            Mileage += km;
        }
    }
}

