using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Coordinate
    {
        //members
        public int X { get; set; }
        public int Y { get; set; }
        //ctor's
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        //members
        public void MoveCoordByDirection(ConsoleKey direction)
        {
            switch (direction)
            {
                case ConsoleKey.LeftArrow:
                    X--;
                    break;
                case ConsoleKey.UpArrow:
                    Y--;
                    break;
                case ConsoleKey.RightArrow:
                    X++;
                    break;
                case ConsoleKey.DownArrow:
                    Y++;
                    break;
                default:
                    break;
            }


        }

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
        //public override string ToString() { return ""; }
        public override bool Equals(object obj)
        {
            
            if (!(obj is Coordinate))
            {
                return false;
            }
            Coordinate coordinate= (Coordinate)obj;
            return (this.X == coordinate.X && this.Y == coordinate.Y);

        }
    }
}
