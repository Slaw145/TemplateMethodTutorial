using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class FireFighter:Worker
    {
        protected override void getUp()
        {
            Console.WriteLine("Get up at five a.m");
        }

        protected override void eatBreakfast()
        {
            Console.WriteLine("Eat breakfast at six a.m");
        }

        protected override void relax()
        {
            Console.WriteLine("Take a break at eight p.m");
        }

        protected override void sleep()
        {
            Console.WriteLine("Go sleep at twelve p.m");
        }
    }
}
