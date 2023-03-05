using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Frame:ItemInBoard
    {
        //members
        public const int FRAME_HEIGHT = 25;
        public const int FRAME_WIDTH = 50;
        protected override char ItemChar { get; set; } = '.';
        protected override ConsoleColor ItemColor { get; set ; } = ConsoleColor.Red;
        //ctor's

        public Frame(Board board):base(board) { }


        protected override void InitItem() 
        {
            
            for (int i = 0; i < FRAME_WIDTH; i++)
            {
                for (int j = 0; j < FRAME_HEIGHT; j++)
                {
                    if (i == 0 || i == FRAME_WIDTH - 1 || j == 0 || j == FRAME_HEIGHT - 1)
                        ItemCoords.Add(new Coordinate(i, j));
                }
            }
            }
        }

    }

