using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Dollar : ItemInBoard
    {
        //members
        protected override char ItemChar { get; set; } = '$';
        protected override ConsoleColor ItemColor { get; set; } = ConsoleColor.Green;
        //ctor's
        public Dollar(Board board) : base(board)
        {

        }
        protected override void InitItem()
        {

            Random r = new Random();
            Coordinate coordinate = new Coordinate(0, 0);
            do
            {
                int x = r.Next(1, Frame.FRAME_WIDTH - 1);
                int y = r.Next(1, Frame.FRAME_HEIGHT - 1);
                coordinate.X = x;
                coordinate.Y = y;

            }
            while (Board.CoordInBoardStatus(coordinate) == CoordStatus.INVALID);

            ItemCoords.Add(coordinate);
        }


    }
}
