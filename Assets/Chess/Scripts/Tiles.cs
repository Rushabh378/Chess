using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts
{
    public class Tiles
    {
        public const int MAX = 8;
        public int Row, Column;

        private static bool[,] _tiles = new bool[MAX, MAX];

        public Tiles(int row, int column)
        {
            Row = row;
            Column = column;
            Occupie(Row, Column);
        }

        public static bool isValid(int row, int column)
        {
            return (row < MAX && row >= 0 && column < MAX && column >= 0);
        }

        public static bool IsOccupied(int row, int column)
        {
            if (!isValid(row, column))
                return true;

            return (_tiles[row, column]);
        }

        public static void Occupie(int row, int column)
        {
            _tiles[row, column] = true;
        }
        public static void Occupie(Tiles tile)
        {
            _tiles[tile.Row, tile.Column] = true;
        }
        public static void UnOccupie(int row, int column)
        {
            _tiles[row, column] = false;
        }
        public static void UnOccupie(Tiles tile)
        {
            _tiles[tile.Row, tile.Column] = false;
        }
    }
}