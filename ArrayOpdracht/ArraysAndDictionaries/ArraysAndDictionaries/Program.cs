using System;

namespace ArraysAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

    }
    class Room
    {
        public void room(int width, int heigth)
        {

            Tile[][] roomtiles = new Tile[7][];
            for (int y = 0; y < roomtiles.Length; y++)
            {
                roomtiles[y] = new Tile[0];
                for (int coordI = 0; coordI < roomtiles.Length; coordI++)
                {
                    roomtiles[y][coordI] = new Tile();
                }
            }
        }
    }

    class Tile
    {


    }
}
