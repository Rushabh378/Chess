using Assets.Chess.Scripts.Interfaces;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Bishop : ChessPiecesBehaviour, IClickable
    {
        public void OnMouseLeftClick()
        {
            HighLight.Bishop(Position);
        }
    }
}