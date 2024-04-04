

using System;

namespace Assets.Chess.Scripts
{
    public class ChessPiecesHighLighter
    {
        public void Clear()
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();
        }
        public void Vertical(Tiles position)
        {
            //checking up
            for (int i = position.Row + 1; i < Tiles.MAX; i++)
            {
                if (Tiles.IsOccupied(i, position.Column))
                {
                    break;
                }
                else
                {
                    ChessBoardPlacementHandler.Instance.Highlight(i, position.Column);
                }
            }

            //checking down
            for (int i = position.Row - 1; i >= 0; i--)
            {
                if (Tiles.IsOccupied(i, position.Column))
                {
                    break;
                }
                else
                {
                    ChessBoardPlacementHandler.Instance.Highlight(i, position.Column);
                }
            }
        }

        public void Horizontal(Tiles position)
        {
            //checking right
            for (int i = position.Column + 1; i < Tiles.MAX; i++)
            {
                if (Tiles.IsOccupied(position.Row, i))
                {
                    break;
                }
                else
                {
                    ChessBoardPlacementHandler.Instance.Highlight(position.Row, i);
                }
            }

            //checking left
            for (int i = position.Column - 1; i >= 0; i--)
            {
                if (Tiles.IsOccupied(position.Row, i))
                {
                    break;
                }
                else
                {
                    ChessBoardPlacementHandler.Instance.Highlight(position.Row, i);
                }
            }
        }

        public void LeftToRightDiagonal(Tiles position)
        {
            //checking up
            int i = position.Row + 1;
            int j = position.Column + 1;

            while (i < Tiles.MAX && j < Tiles.MAX)
            {
                if (Tiles.IsOccupied(i, j))
                {
                    break;
                }

                ChessBoardPlacementHandler.Instance.Highlight(i, j);
                i++; j++;
            }

            //checking down
            i = position.Row - 1;
            j = position.Column - 1;

            while (i >= 0 && j >= 0)
            {
                if (Tiles.IsOccupied(i, j))
                {
                    break;
                }

                ChessBoardPlacementHandler.Instance.Highlight(i, j);
                i--; j--;
            }
        }

        public void RightToLeftDiagonal(Tiles position)
        {
            //checking up
            int i = position.Row + 1;
            int j = position.Column - 1;

            while (i < Tiles.MAX && j >= 0)
            {
                if (Tiles.IsOccupied(i, j))
                {
                    break;
                }

                ChessBoardPlacementHandler.Instance.Highlight(i, j);
                i++; j--;
            }

            //checking down
            i = position.Row - 1;
            j = position.Column + 1;

            while (i >= 0 && j <= Tiles.MAX)
            {
                if (Tiles.IsOccupied(i, j))
                {
                    break;
                }

                ChessBoardPlacementHandler.Instance.Highlight(i, j);
                i--; j++;
            }
        }

        internal void Pawn(Tiles tile)
        {
            int i = tile.Row;
            int j = tile.Column;

            if (Tiles.isValid(i + 1, j))
            {
                ChessBoardPlacementHandler.Instance.Highlight(i + 1, j);
            }
            if (i == 1 && Tiles.isValid(i + 2, j)) //if pawn is at starting stage
            {
                ChessBoardPlacementHandler.Instance.Highlight(i + 2, j);
            }
        }

        internal void King(Tiles tile)
        {
            int i = tile.Row;
            int j = tile.Column;
            //yet to impliment
        }
    }
}