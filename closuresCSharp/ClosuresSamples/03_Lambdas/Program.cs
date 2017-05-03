using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace _03_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            Action lambdaAction = () => { WriteLine(i); }; // That's closure 'cuz it takes variable from parent-function scope
            lambdaAction();


            // however, that's not closure:
            Action<string> lambda2Action = (string word) =>
            {
                WriteLine($"Totally not closure! with {word}");
            };
            lambda2Action("Fourty Two");
        }
    }
}