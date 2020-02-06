using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operatio()");
        }
        void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB.AddedBehavior");
        }
    }
}
