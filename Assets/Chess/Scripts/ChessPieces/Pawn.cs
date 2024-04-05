using Assets.Chess.Scripts.Interfaces;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Pawn : ChessPiecesBehaviour, IClickable
    {
        public void OnMouseLeftClick()
        {
            HighLight.Pawn(Position);
        }
    }
}