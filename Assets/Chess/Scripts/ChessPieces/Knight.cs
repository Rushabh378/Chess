using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Knight : ChessPiecesBehaviour, IInteractable
    {
        protected override void HighLightMoves()
        {
            base.HighLightMoves();

            HighLight.Knight(Tile);
        }

        public void OnMouseLeftClick()
        {
            HighLightMoves();
        }
    }
}