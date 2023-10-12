using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTheoryLibrary
{
    public static class ConsoleHelper
    {
        public static void PrintMessage(string message)
        {
            PrintMessageWithAllOptions(message, null, 1);
        }

        public static void PrintMessage(string message, string label)
        {
            PrintMessageWithAllOptions(message, label, 1);
        }

        public static void PrintMessage(string message, int count)
        {
            PrintMessageWithAllOptions(message, null, count);
        }

        private static void PrintMessageWithAllOptions(string message, string label, int count)
        {
            if (!string.IsNullOrEmpty(label))
            {
                Console.Write($"{label}:");
            }
            
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
