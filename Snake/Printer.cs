using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   static class Printer
    {
        //methods
        public static void PrintCoords(List <Coordinate> coords,char charToPrint,ConsoleColor color) 
        {
            for (int i = 0; i < coords.Count; i++)
            {
                PrintCoords(coords[i], charToPrint, color);
            }
        }
        public static void PrintCoords(Coordinate coord,char charToPrint, ConsoleColor color) 
        {
            Console.SetCursorPosition(coord.X, coord.Y);
            Console.ForegroundColor = color;
            Console.Write(charToPrint);
        }
        public static void DeleteCoords(List<Coordinate> coords) 
        {
            for (int i = 0; i < coords.Count; i++)
            {
                DeleteCoords(coords[i]);
            }

        }
        public static void DeleteCoords(Coordinate coord)
        {
            Console.SetCursorPosition(coord.X, coord.Y);
            Console.Write(' ');
        }

    }
}
