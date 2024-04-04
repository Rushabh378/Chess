using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class King : ChessPiecesBehaviour, IInteractable
    {
        protected override void HighLightMoves()
        {
            base.HighLightMoves();

            HighLight.King(Tile);
        }

        public void OnMouseLeftClick()
        {
            HighLightMoves();
        }
    }
}