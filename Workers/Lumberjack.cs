using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class Lumberjack : Worker
    {
        protected override void getUp()
        {
            Console.WriteLine("Get up at half past seven a.m. Flax...");
        }

        protected override void eatBreakfast()
        {
            Console.WriteLine("Eat during work...");
        }

        protected override void relax()
        {
            Console.WriteLine("Take a break at sixteen p.m. Not very ambitious...");
        }

        protected override void sleep()
        {
            Console.WriteLine("Go sleep at eight p.m");
        }
    }
}
