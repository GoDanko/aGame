using System;
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

                char [,] content = BuildFrame();
                WholeDisplay frame = new WholeDisplay(content);
            }
        }
        static char[,] BuildFrame() {
            char[,] result = new char[WholeDisplay.DisplayX, WholeDisplay.DisplayY];
            for (int y = 0; y < WholeDisplay.DisplayY; y++) {
                for (int x = 0; x < WholeDisplay.DisplayX; x++) {
                    result[x,y] = '.';
                }
            }
            return result;
        }
    }
}