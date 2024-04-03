using System.Collections;
using UnityEngine;
using Chess.Scripts.Core;

namespace Assets.Chess.Scripts.ChessPieces
{
    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class ChessPiecesBehaviour : MonoBehaviour
    {
        internal ChessPlayerPlacementHandler PiecePos;

        private void Start()
        {
            PiecePos = gameObject.GetComponent<ChessPlayerPlacementHandler>();
        }
    }
}