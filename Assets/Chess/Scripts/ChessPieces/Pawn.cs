using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Pawn : ChessPiecesBehaviour, IInteractable
    {
        
        protected override void HighLightMoves()
        {
            base.HighLightMoves();

            HighLight.Pawn(Tile);
        }

        public void OnMouseLeftClick()
        {
            HighLightMoves();
        }
    }
}