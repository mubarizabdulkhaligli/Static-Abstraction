using System;
namespace task1
{
	internal class Pomegranate : Fruit, IFruit
    {
        public void Taste()
        {
            Console.WriteLine("Pomegranate tastes sour");
        }
    }
}

