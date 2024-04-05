

using System;

namespace Assets.Chess.Scripts
{
    public class ChessPiecesHighLighter
    {
        public void Clear()
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();
        }

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
        public void HighlightTiles(Tiles position, int[,] directions, bool singleStep = false)
        {
            int row, col;
            for (int i = 0; i < directions.GetLength(0); i++)
            {
                row = position.Row + directions[i, 0];
                col = position.Column + directions[i, 1];

                ChessBoardPlacementHandler.Instance.Highlight(row, col);
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

            Rook(position);
            Bishop(position);
        }

        internal void Pawn(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            int forword = position.Row == 1 ? 2 : 1;
            HighlightTiles(position, new int[,]
            {
                {forword, 0}
            }, true);
        }

        internal void King(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            HighlightTiles(position, new int[,]
            {
                {-1,-1}, {-1, 0}, {0, -1}, {1, 1},
                {1, 0}, {0, 1},
            }, true);
        }

        internal void Knight(Tiles position)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            int i = position.Row;
            int j = position.Column;

            //HighLight Upperword T
            if (Tiles.IsOccupied(i + 2, j - 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i + 2, j - 1);
            if (Tiles.IsOccupied(i + 2, j + 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i + 2, j + 1);

            //HighLight Downward T
            if (Tiles.IsOccupied(i - 2, j - 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i - 2, j - 1);
            if (Tiles.IsOccupied(i - 2, j + 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i - 2, j + 1);

            //HighLight Leftward T
            if (Tiles.IsOccupied(i + 1, j - 2) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i + 1, j - 2);
            if (Tiles.IsOccupied(i - 1, j - 2) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i - 1, j - 2);

            //HighLight Rightward T
            if (Tiles.IsOccupied(i - 1, j + 2) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i - 1, j + 2);
            if (Tiles.IsOccupied(i + 1, j + 2) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i + 1, j + 2);

        }
    }
}