using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodSchema
{
    class ConcreteClassB : AbstractClass
    {
        public override void StepOne()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }
        public override void StepTwo()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}
