using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class Postman : Worker
    {
        protected override void getUp()
        {
            Console.WriteLine("Get up at six a.m");
        }

        protected override void eatBreakfast()
        {
            Console.WriteLine("Eat breakfast at seven a.m");
        }

        protected override void relax()
        {
            Console.WriteLine("Take a break at half past sixteen p.m");
        }

        protected override void sleep()
        {
            Console.WriteLine("Go sleep at eleven p.m");
        }
    }
}
