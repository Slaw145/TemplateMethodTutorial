using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    abstract class Worker
    {
        protected void goToWork()
        {
            Console.WriteLine("Go to work at eight a.m");
        }

        protected void work()
        {
            Console.WriteLine("Work for eight hours");
        }

        protected void returnToHome()
        {
            Console.WriteLine("Return from work at sixteen p.m");
        }

        protected abstract void getUp();
        protected abstract void eatBreakfast();
        protected abstract void relax();
        protected abstract void sleep();

        public void DailyRoutine()
        {
            goToWork();
            work();
            returnToHome();
            getUp();
            eatBreakfast();
            relax();
            sleep();
            Console.WriteLine("");
        }
    }
}
