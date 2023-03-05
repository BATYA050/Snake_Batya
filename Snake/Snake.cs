using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : ItemInBoard
    {
        private const int SNAKE_BASE_LENGTH = 5;
        protected override char ItemChar { get; set; } = (char)1;
        protected override ConsoleColor ItemColor { get; set; } = ConsoleColor.DarkRed;
       
        private Coordinate snakeCoords;
        public Coordinate SnakeHeadCoords { get { return new Coordinate(snakeCoords.X, snakeCoords.Y); } set { snakeCoords  = new Coordinate(value.X, value.Y); } }
        
        //ctor's
        public Snake(Board board) : base(board)
        {
            
        }

        //methods
        protected override void InitItem()
        {
          
            for (int i = 1; i <= SNAKE_BASE_LENGTH; i++)
            {
                Coordinate c = new Coordinate( i, 1);
                ItemCoords.Add(c);
            }
            SnakeHeadCoords  = ItemCoords[SNAKE_BASE_LENGTH-1];

        }

        public void MoveSnake(Coordinate newCoord)
        {

            DeleteItemFromScreen(ItemCoords[0]);
            ItemCoords.RemoveAt(0);
            Grow(newCoord);
        }
        public void Grow(Coordinate newCoord) 
        {
            this.ItemCoords.Add(new Coordinate(newCoord.X, newCoord.Y));
            
            this.PrintItemOnScreen(newCoord);
        }


    }
}
