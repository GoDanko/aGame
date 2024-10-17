using System;
using System.Drawing;
using Main;

namespace Display
{
    internal class WholeDisplay
    {
        public char[,] DisplayContent {get; set;}
        public static int DisplayX {get;} = 64;
        public static int DisplayY {get;} = 32;
        public static TimeSpan drawTime {get;} = TimeSpan.FromMilliseconds(83.34); // 1000 : targetFramesPerSecond = millisecondsPerFrame (83.34)
        
        public WholeDisplay(char[,] content) {
            Console.SetCursorPosition(0, 0);
            DisplayFrame(content);
        }

        void DisplayFrame(char[,] content) {
            for (int y = 0; y < DisplayY; y++) {
                for (int x = 0; x < DisplayX; x++) {
                    Console.Write(content[x,y]);
                }
                Console.Write(" \n");
            }
        }

        public static char[,] BuildFrame() {
            char[,] result = new char[DisplayX, DisplayY];
            for (int y = 0; y < DisplayY; y++) {
                for (int x = 0; x < DisplayX; x++) {
                    result[x,y] = '.';
                }
            }
            return result;
        }
    }
}