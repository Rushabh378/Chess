using Assets.Chess.Scripts.Interfaces;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Rook : ChessPiecesBehaviour, IClickable
    {
        public void OnMouseLeftClick()
        {
            HighLight.Rook(Position);
        }
    }
}