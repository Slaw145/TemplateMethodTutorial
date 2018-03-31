using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodSchema
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            StepOne();
            StepTwo();
            Console.WriteLine("");
        }

        public abstract void StepOne();
        public abstract void StepTwo();
    }
}
