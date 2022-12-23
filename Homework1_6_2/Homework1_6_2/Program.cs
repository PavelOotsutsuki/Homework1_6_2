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
            Renderer rendererPlayer = new Renderer();

            rendererPlayer.DrawPosition(player);
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
        public void DrawPosition(Player player)
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.Write(player.SymbolPlayer);
        }
    }
}
