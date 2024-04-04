using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Bishop : ChessPiecesBehaviour, IInteractable
    {
        protected override void HighLightMoves()
        {
            base.HighLightMoves();

            HighLight.LeftToRightDiagonal(Tile);
            HighLight.RightToLeftDiagonal(Tile);
        }

        public void OnMouseLeftClick()
        {
            HighLightMoves();
        }
    }
}