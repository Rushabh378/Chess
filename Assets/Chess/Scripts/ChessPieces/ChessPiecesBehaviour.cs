﻿using System.Collections;
using UnityEngine;
using Chess.Scripts.Core;

namespace Assets.Chess.Scripts.ChessPieces
{

    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class ChessPiecesBehaviour : MonoBehaviour
    {
        private ChessPlayerPlacementHandler _piecePos;
        internal Tiles Tile;
        internal ChessPiecesHighLighter HighLight = new ChessPiecesHighLighter();

        private void Start()
        {
            _piecePos = gameObject.GetComponent<ChessPlayerPlacementHandler>();
            Tile = new Tiles(_piecePos.row, _piecePos.column);
        }

        protected virtual void HighLightMoves()
        {
            HighLight.Clear(); //clearing past HighLights if any before HighLightning;
        }
    }
}