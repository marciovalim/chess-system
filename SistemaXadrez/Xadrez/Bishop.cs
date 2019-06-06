﻿using Board;
using Board.Enums;

namespace Xadrez
{
    sealed class Bishop : Piece
    {
        public Bishop(Color color, BoardClass board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "B ";
        }
    }
}
