using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class King : ChessPiecesBehaviour, IClickable
    {
        public void OnMouseLeftClick()
        {
            HighLight.King(Position);
        }
    }
}