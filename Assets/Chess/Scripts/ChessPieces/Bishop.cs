using System.Collections;
using UnityEngine;

namespace Assets.Chess.Scripts.ChessPieces
{
    public class Bishop : ChessPiecesBehaviour, IClickable
    {
        public void OnMouseLeftClick()
        {
            HighLight.Bishop(Position);
        }
    }
}