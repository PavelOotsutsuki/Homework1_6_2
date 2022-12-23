using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPlayer drawPlayer = new DrawPlayer(2, 10,'$');

            drawPlayer.DrawPosition();
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player (int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        public void ShowPosition ()
        {
            Console.WriteLine("(" + PositionX + "," + PositionY + ")");
        }
    }

    class DrawPlayer : Player
    {
        private char _symbolPlayer;

        public DrawPlayer(int positionX, int positionY, char symbolPlayer='&') : base(positionX, positionY)
        {
            _symbolPlayer = symbolPlayer;
        }

        public void DrawPosition()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(_symbolPlayer);
        }
    }
}
