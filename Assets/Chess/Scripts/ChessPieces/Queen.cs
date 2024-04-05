using Assets.Chess.Scripts.Interfaces;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Queen : ChessPiecesBehaviour, IClickable
    {
        public void OnMouseLeftClick()
        {
            HighLight.Queen(Position);
        }
    }
}