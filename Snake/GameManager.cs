using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class GameManager
    {
        private readonly int MAX_NUM_OF_TRYINGS = 7;
        private readonly ConsoleKey DEFAULT_DIRECTION = ConsoleKey.RightArrow;
        private readonly int TIME_TO_SLEEP = 200;
        private Board board;
        private ConsoleKey currentDirction;
        private int currentTrying;
        private Coordinate currentCoord;
        public GameManager()
        {
            board = new Board();
            MAX_NUM_OF_TRYINGS = 3;
            this.currentTrying = 1;
            currentCoord = board.SnakeHeadCoord();
            currentDirction = DEFAULT_DIRECTION;
        }
        private void HandleUserMistake()
        {
            currentTrying++;
            if (currentTrying > MAX_NUM_OF_TRYINGS)
                return;
            StartBeaforeGame();
            board.RefreshBoard();
            currentCoord = board.SnakeHeadCoord();
            currentDirction = DEFAULT_DIRECTION;
        }
        private void HandleUserMove(bool isToSleep)
        {
            if (isToSleep)
                Sleep();

            currentCoord.MoveCoordByDirection(currentDirction);
            if (board.CoordInBoardStatus(currentCoord) == CoordStatus.INVALID)
                HandleUserMistake();
            else
                board.HandleMoveOnBoard(currentCoord);

        }
        private void Sleep()
        {
            Thread.Sleep(TIME_TO_SLEEP);

        }
        public void StartGame()
        {
            StartBeaforeGame();
            board.PrintBoard();

            while (currentTrying <= MAX_NUM_OF_TRYINGS)
            {
                if (Console.KeyAvailable)
                {
                    currentDirction = Console.ReadKey().Key;
                    //עם FALSE לא נח לשחק
                    HandleUserMove(true);
                }
                else
                    HandleUserMove(true);
            }
            Console.Clear();
            Console.WriteLine("game over!!!");
            Console.ReadKey();
        }

        private static void StartBeaforeGame()
        {
            Console.Clear();
            for (int i = 10; i > 0; i--)
            {
                Console.SetCursorPosition(10, 5);
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("!!!!!!!!!  " + i + "  !!!!!!!!!");
                Thread.Sleep(750);
                Console.Clear();
            }
            Console.SetCursorPosition(10, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("start!!!");
            Thread.Sleep(750);
            Console.Clear();
            ConsoleKey x;
            while (Console.KeyAvailable)
            {
                x = Console.ReadKey().Key;

            }
        }
    }
}

