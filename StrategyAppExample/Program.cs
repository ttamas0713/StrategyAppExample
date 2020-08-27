using System;

namespace StrategyAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStrategyA());
            context.doBusinessLogic();

            Console.WriteLine();

            context = new Context(new ConcreteStrategyB());
            context.doBusinessLogic();

            Console.ReadKey();
        }
    }
}
