using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class Manager : Worker
    {
        protected override void getUp()
        {
            Console.WriteLine("Get up at four a.m. Ambitious :)");
        }

        protected override void eatBreakfast()
        {
            Console.WriteLine("Eat breakfast at six a.m");
        }

        protected override void relax()
        {
            Console.WriteLine("Take a break at ten p.m. Busy bee :)");
        }

        protected override void sleep()
        {
            Console.WriteLine("Go sleep at midnight");
        }
    }
}
