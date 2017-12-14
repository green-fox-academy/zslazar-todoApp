using System;
using System.IO;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();

            if (args.Length == 0)
            {
                printer.PrintInfo();
            }

            if (args[0] == "-l")
            {
                printer.PrintTask();
            }

            if (args[0] == "-a")
            {
                try
                {

                printer.AddLine(args[1]);
                }
                catch (System.IndexOutOfRangeException)
                {

                    Console.WriteLine("Unable to add: no task provided");
                }
                
            }

            //foreach (var text in args)
            //{
            //Console.WriteLine(text);
            //}
        }
    }
}
