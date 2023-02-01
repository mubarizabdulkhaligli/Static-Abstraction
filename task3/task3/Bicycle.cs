using System;
namespace task3
{
	internal class Bicycle:Vehicle
	{
        public override void Drive(double km)
        {
            Mileage += km;
        }
    }
}

