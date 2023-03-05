using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum CoordStatus { VALID, DOLLAR_TOUCHED, INVALID }
    class Board
    {
        private Snake snake;
        private Dollar dollar;
        private Frame frame;
        private List<ItemInBoard> itemInBoard = new List<ItemInBoard>();
        public Board()
        {
            snake = new Snake(this);
            dollar = new Dollar(this);
            frame = new Frame(this);
            itemInBoard.Add(snake);
            itemInBoard.Add(dollar);
            itemInBoard.Add(frame);
        }
        public void RefreshBoard()
        {
            foreach (var item in itemInBoard)
            {
                item.RefreshItem();
            }
        }
        public void PrintBoard()
        {
            foreach (var item in itemInBoard)
            {
                item.PrintItemOnScreen();
            }

        }
        public CoordStatus CoordInBoardStatus(Coordinate coord)
        {

            {
                if (snake != null && snake.IsItemInCoord(coord) || frame != null && frame.IsItemInCoord(coord))
                    return CoordStatus.INVALID;
                return (dollar != null && dollar.IsItemInCoord(coord)) ? CoordStatus.DOLLAR_TOUCHED : CoordStatus.VALID;
            }
        }
        public void HandleMoveOnBoard(Coordinate currentCoord)
        {
            CoordStatus coordStatus = CoordInBoardStatus(currentCoord);
            if (coordStatus == CoordStatus.DOLLAR_TOUCHED)
            {
                Console.Beep();
                snake.Grow(currentCoord);
                dollar.RefreshItem();
            }
            else
               if (coordStatus == CoordStatus.VALID)
            {
                snake.MoveSnake(currentCoord);
            }
        }
        public Coordinate SnakeHeadCoord()
        {
            return snake.SnakeHeadCoords;
        }


    }
}
