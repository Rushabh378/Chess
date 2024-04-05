using Assets.Chess.Scripts.Interfaces;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Knight : ChessPiecesBehaviour, IClickable
    {
        public void OnMouseLeftClick()
        {
            HighLight.Knight(Position);
        }
    }
}