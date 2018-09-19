using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Polymorphism
{
    class Chessboard
    {
        public ChessPiece[] WhitePieces { get; set; }
        public ChessPiece[] BlackPieces { get; set; }

        public Chessboard()
        {
            WhitePieces = new ChessPiece[16];
            BlackPieces = new ChessPiece[16];

            for (int i = 0; i < 8; i++)
            {
                WhitePieces[i] = new Pawn();
                BlackPieces[i] = new Pawn();
            }
            for (int i = 8; i < 10; i++)
            {
                WhitePieces[i] = new Rook();
                BlackPieces[i] = new Rook();
            }
            for (int i = 10; i < 12; i++)
            {
                WhitePieces[i] = new Bishop();
                BlackPieces[i] = new Bishop();
            }
            for (int i = 12; i < 14; i++)
            {
                WhitePieces[i] = new Knight();
                BlackPieces[i] = new Knight();
            }
            WhitePieces[14] = new Queen();
            BlackPieces[14] = new King();

            WhitePieces[15] = new Queen();
            BlackPieces[15] = new King();
        }
    }
}
