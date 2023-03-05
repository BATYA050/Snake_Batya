using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  abstract  class ItemPrintable
    {
        protected virtual char ItemChar { get; set; }
        protected virtual ConsoleColor ItemColor { get; set; } = ConsoleColor.White;
        protected virtual List<Coordinate> ItemCoords { get; set; } = new List<Coordinate>();
        public void PrintItemOnScreen() 
        {
            Printer.PrintCoords(ItemCoords, ItemChar, ItemColor);
        }
        protected void PrintItemOnScreen(Coordinate coord)
        {

            Printer.PrintCoords(coord, ItemChar, ItemColor);
        }
        protected void DeleteItemFromScreen() 
        {
            Printer.DeleteCoords(ItemCoords);        
        }
        protected void DeleteItemFromScreen(Coordinate coord)
        {
            Printer.DeleteCoords(coord);

        }



    }
}
