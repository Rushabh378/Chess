using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Rook : ChessPiecesBehaviour, IInteractable
    {
        public override void HighLightMoves()
        {
            HighLighter.HorizontalHighLight(Tile);
            HighLighter.VerticalHighLight(Tile);
        }

        public void OnMouseLeftClick()
        {
            HighLightMoves();
        }
    }
}