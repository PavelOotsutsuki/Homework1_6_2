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
            Player player = new Player(2, 10, '$');
            Renderer rendererPlayer = new Renderer(player.PositionX, player.PositionY, player.SymbolPlayer);

            rendererPlayer.DrawPosition();
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char SymbolPlayer { get; private set; }

        public Player (int positionX, int positionY, char symbolPlayer = '&')
        {
            PositionX = positionX;
            PositionY = positionY;
            SymbolPlayer = symbolPlayer;
        }

        public void ShowPosition ()
        {
            Console.WriteLine("(" + PositionX + "," + PositionY + ")");
        }
    }

    class Renderer
    {
        private int PositionX;
        private int PositionY;
        private char _symbolRender;

        public Renderer (int positionX, int positionY, char symbolRender)
        {
            PositionX = positionX;
            PositionY = positionY;
            _symbolRender = symbolRender;
        }

        public void DrawPosition()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(_symbolRender);
        }
    }
}
