using System.Collections;
using UnityEngine;
using Chess.Scripts.Core;

namespace Assets.Chess.Scripts.ChessPieces
{

    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class ChessPiecesBehaviour : MonoBehaviour
    {
        private ChessPlayerPlacementHandler _piecePos;
        protected Tiles Position;
        protected ChessPiecesHighLighter HighLight = new ChessPiecesHighLighter();

        private void Start()
        {
            _piecePos = gameObject.GetComponent<ChessPlayerPlacementHandler>();
            Position = new Tiles(_piecePos.row, _piecePos.column);
        }
    }
}