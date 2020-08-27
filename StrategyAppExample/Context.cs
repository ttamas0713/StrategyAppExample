using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAppExample
{
    class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void doBusinessLogic()
        {
            strategy.doSomething();
        }
    }
}
