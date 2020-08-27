using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAppExample
{
    class ConcreteStrategyB : IStrategy
    {
        public void doSomething()
        {
            Console.WriteLine("Strategy B:");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
