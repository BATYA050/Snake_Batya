using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    abstract class ItemInBoard:ItemPrintable
    {
        //members
        protected virtual Board Board { get; set; }

        protected ItemInBoard(Board board) 
        {
           Board = board;
           InitItem();
        }
        protected abstract void InitItem();

        public void RefreshItem() 
        {
            ItemCoords.Clear();
            InitItem();
            PrintItemOnScreen();

        }
        public bool IsItemInCoord(Coordinate coord) 
        {
            for (int i = 0; i < ItemCoords.Count; i++)
            {
                if (coord.Equals(ItemCoords[i]))
                    return true;
            }
            return false;


        }


    }
}
