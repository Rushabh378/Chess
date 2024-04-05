using System;

namespace Assets.Chess.Scripts.Utilities
{
    public class ChessPiecesHighLighter
    {
        public void HighlightTiles(Tiles position, int[,] directions)
        {
            for(int i = 0; i < directions.GetLength(0); i++)
            {
                int row = position.Row + directions[i, 0];
                int col = position.Column + directions[i, 1];

                while (Tiles.IsValid(row, col) && !Tiles.IsOccupied(row, col))
                {
                    ChessBoardPlacementHandler.Instance.Highlight(row, col);
                    row += directions[i, 0];
                    col += directions[i, 1];
                }
            }
        }
        public void SingleStepHighlightTiles(Tiles position, int[,] directions)
        {
            int row, col;
            for (int i = 0; i < directions.GetLength(0); i++)
            {
                row = position.Row + directions[i, 0];
                col = position.Column + directions[i, 1];

                if(Tiles.IsValid(row, col) && !Tiles.IsOccupied(row,col))
                {
                    ChessBoardPlacementHandler.Instance.Highlight(row, col);
                }
            }
        }

        internal void Rook(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            HighlightTiles(position, new int[,]
            {
                {1, 0}, {-1, 0},
                {0, 1}, {0, -1}
            });
        }

        internal void Bishop(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            HighlightTiles(position, new int[,]
            {
                {-1,-1}, {1, 1},
                {1, -1}, {-1, 1}
            });
        }

        internal void Queen(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            HighlightTiles(position, new int[,]
            {
                {1, 0}, {-1, 0},
                {0, 1}, {0, -1},
                {-1,-1}, {1, 1},
                {1, -1}, {-1, 1}
            });
        }

        internal void Pawn(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            if(position.Row == 1)
            {
                SingleStepHighlightTiles(position, new int[,] { { 1, 0 }, { 2, 0 } });
            }
            else
            {
                SingleStepHighlightTiles(position, new int[,] { { 1, 0 } });
            }
        }

        internal void King(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            SingleStepHighlightTiles(position, new int[,]
            {
                {-1,-1}, {-1, 0}, {0, -1}, {1, 1},
                {1, 0}, {0, 1}, {1, -1}, {-1, 1}
            });
        }

        internal void Knight(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            SingleStepHighlightTiles(position, new int[,]
            {
                {2, -1}, {2, 1}, {-2, -1}, {-2, -1},
                {-1, 2}, {1, 2}, {-1, -2}, {1, -2}
            });
        }
    }
}