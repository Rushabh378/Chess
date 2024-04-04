using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Queen : ChessPiecesBehaviour, IInteractable
    {
        protected override void HighLightMoves()
        {
            base.HighLightMoves();

            HighLight.Vertical(Tile);
            HighLight.Horizontal(Tile);
            HighLight.RightToLeftDiagonal(Tile);
            HighLight.LeftToRightDiagonal(Tile);
        }

        public void OnMouseLeftClick()
        {
            HighLightMoves();
        }
    }
}