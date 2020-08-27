using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAppExample
{
    class ConcreteStrategyA : IStrategy
    {
        public void doSomething()
        {
            Console.WriteLine("Strategy A:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }
        }
    }
}
