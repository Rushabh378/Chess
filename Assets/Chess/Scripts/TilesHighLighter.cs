

namespace Assets.Chess.Scripts
{
    public class TilesHighLighter
    {
        public void VerticalHighLight(Tiles position)
        {
            //checking up
            for(int i = position.Row+1; i < Tiles.MAX; i++)
            {
                if(Tiles.IsOccupied(i, position.Column))
                {
                    break;
                }
                else
                {
                    ChessBoardPlacementHandler.Instance.Highlight(i, position.Column);
                }
            }

            //checking down
            for(int i = position.Row-1; i >= 0; i--)
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

        public void HorizontalHighLight(Tiles position)
        {
            //checking right
            for(int i = position.Column+1; i < Tiles.MAX; i++)
            {
                if(Tiles.IsOccupied(position.Row, i))
                {
                    break;
                }
                else
                {
                    ChessBoardPlacementHandler.Instance.Highlight(position.Row, i);
                }
            }

            //checking left
            for (int i = position.Column-1; i >= 0; i--)
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
    }
}