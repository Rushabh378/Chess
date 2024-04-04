using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Rook : ChessPiecesBehaviour, IInteractable
    {
        protected override void HighLightMoves()
        {
            base.HighLightMoves();

            HighLight.Horizontal(Tile);
            HighLight.Vertical(Tile);
        }

        public void OnMouseLeftClick()
        {
            HighLightMoves();
        }
    }
}