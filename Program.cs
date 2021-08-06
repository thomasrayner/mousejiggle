using System;
using WindowsInput;
using System.Threading;

namespace mousejiggle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new();
            InputSimulator inpSim = new();

            while (true)
            {
                int x = r.Next(-2, 2);
                int y = r.Next(-2, 2);
                Console.WriteLine($"Move x: {x}, y: {y}");
                inpSim.Mouse.MoveMouseBy(x, y);
                Thread.Sleep(3000);
            }
        }
    }
}
