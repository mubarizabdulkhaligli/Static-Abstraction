using System;
namespace task1
{
	internal class Pear: Fruit, IFruit
	{
        public void Taste()
        {
            Console.WriteLine("Pear tastes sweet");
        }
    }
}

