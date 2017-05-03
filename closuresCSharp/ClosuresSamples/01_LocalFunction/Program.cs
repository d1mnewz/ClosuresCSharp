using System;
using System.Threading;
using static System.Console;

namespace _01_LocalFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            UInt32.TryParse(ReadLine(), out uint parseResult); // if not parsed, it is default(uint) => 0
            WriteLine(IterateRandomlyToNum(parseResult));
            
        }

        private static int IterateRandomlyToNum(uint end)
        {
            Random rnd = new Random();
            int result = 0;

            void RandomlyIncrement() // <- closure
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    result++; // local function refers to variable that is defined in containing function
                }
            }

            for (int i = 0; i < end; i++)
            {
                RandomlyIncrement();
                Thread.Sleep(millisecondsTimeout: rnd.Next(0, 2000));
            }

            return result;
        }

    }
}