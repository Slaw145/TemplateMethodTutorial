using System;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FireFighter");
            Worker firefighter = new FireFighter();
            firefighter.DailyRoutine();

            Console.WriteLine("Lumberjack");
            Worker lumberjack = new Lumberjack();
            lumberjack.DailyRoutine();

            Console.WriteLine("Manager");
            Worker manager = new Manager();
            manager.DailyRoutine();

            Console.WriteLine("Postman");
            Worker postman = new Postman();
            postman.DailyRoutine();

            Console.ReadKey();
        }
    }
}
