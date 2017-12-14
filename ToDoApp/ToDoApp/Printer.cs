using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class Printer
    {
        public void PrintInfo()
        {
            string path = @"c:\greenfox\zslazar-todoApp\info.txt";
            {
                string[] content = File.ReadAllLines(path);
                foreach (string line in content)
                Console.WriteLine(line);
            }
        }

        public void PrintTask()
        {
            string path = @"c:\greenfox\zslazar-todoApp\data.txt";
            {
                string[] content = File.ReadAllLines(path);
                if (content.Length == 0)
                {
                    Console.WriteLine("No todos for today! :)");
                }
                foreach (string line in content)
                Console.WriteLine(line);
            }
        }

        public void AddLine(string line)
        {
            string path = @"c:\greenfox\zslazar-todoApp\data.txt";
            StreamWriter input = new StreamWriter(path, true);
                      
            input.WriteLine(line);
            input.Close();
        }

    }
}
