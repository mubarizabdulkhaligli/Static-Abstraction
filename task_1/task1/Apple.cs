using System;
namespace task1
{
    internal class Apple : Fruit, IFruit
    {
        public void Taste()
        {
            Console.WriteLine("Apple tastes sweet");
        }
    }
}

