

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

        internal void Pawn(Tiles position)
        {
            int i = position.Row;
            int j = position.Column;

            if (Tiles.IsOccupied(i + 1, j) != true)
            {
                ChessBoardPlacementHandler.Instance.Highlight(i + 1, j);
            }
            if (i == 1 && Tiles.IsOccupied(i + 2, j) != true) //if pawn is at starting stage
            {
                ChessBoardPlacementHandler.Instance.Highlight(i + 2, j);
            }
        }

        internal void King(Tiles position)
        {
            int i = position.Row;
            int j = position.Column;

            // HighLight in plus (+)
            if (Tiles.IsOccupied(i + 1, j) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i + 1, j);
            if (Tiles.IsOccupied(i, j + 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i, j + 1);
            if (Tiles.IsOccupied(i - 1, j) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i - 1, j);
            if (Tiles.IsOccupied(i, j - 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i, j - 1);

            // HighLigh in axe (x)
            if (Tiles.IsOccupied(i + 1, j + 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i + 1, j + 1);
            if (Tiles.IsOccupied(i - 1, j - 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i - 1, j - 1);
            if (Tiles.IsOccupied(i + 1, j - 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i + 1, j - 1);
            if (Tiles.IsOccupied(i - 1, j + 1) != true)
                ChessBoardPlacementHandler.Instance.Highlight(i - 1, j + 1);
        }

        internal void Knight(Tiles position)
        {
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