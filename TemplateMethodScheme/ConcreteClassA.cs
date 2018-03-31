using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodSchema
{
    class ConcreteClassA : AbstractClass
    {
        public override void StepOne()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }
        public override void StepTwo()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }
}
