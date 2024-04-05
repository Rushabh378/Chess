using System;
using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.Utilities
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

        public static bool IsValid(int row, int column)
        {
            return (row < MAX && row >= 0 && column < MAX && column >= 0);
        }

        public static bool IsOccupied(int row, int column)
        {
            try
            {
                return (_tiles[row, column]);
            }
            catch(Exception)
            {
                Debug.LogWarning("in valid Row and column provided");
                return true;
            }
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