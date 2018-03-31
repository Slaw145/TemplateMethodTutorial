using System;

namespace DocumentGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HTML Document\n");

            HTMLDocGenerator htmldocgenerator = new HTMLDocGenerator();

            htmldocgenerator.generateDocument();

            Console.WriteLine("\nXML Document\n");

            XMLDocGenerator xmldocgenerator = new XMLDocGenerator();

            xmldocgenerator.generateDocument();

            Console.ReadKey();
        }
    }
}
