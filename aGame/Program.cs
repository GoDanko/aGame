using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

using Display;
using Input;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();

            while(true) {
                DateTime startTime = DateTime.Now;

                bool anyKeyPressed = false;
                if(anyKeyPressed) {}

                DateTime endProcessTime = DateTime.Now;
                TimeSpan processTime = endProcessTime - startTime;

                char [,] content = WholeDisplay.BuildFrame();
                new WholeDisplay(content);

                TimeSpan pauseForTime = WholeDisplay.drawTime - processTime;

                Thread.Sleep((int)pauseForTime.TotalMilliseconds);
            }
        }
    }
}