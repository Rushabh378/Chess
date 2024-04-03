using System.Collections;
using UnityEngine;
using Chess.Scripts.Core;

namespace Assets.Chess.Scripts.ChessPieces
{

    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class ChessPiecesBehaviour : MonoBehaviour
    {
        internal ChessPlayerPlacementHandler PiecePos;
        internal Tiles Tile;
        internal TilesHighLighter HighLighter = new TilesHighLighter();

        private void Start()
        {
            PiecePos = gameObject.GetComponent<ChessPlayerPlacementHandler>();
            Tile = new Tiles(PiecePos.row, PiecePos.column);
        }

        public abstract void HighLightMoves();
    }
}