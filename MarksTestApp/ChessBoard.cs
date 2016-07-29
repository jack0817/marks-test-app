using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksTestApp
{
    public enum SquareState
    {
        Unknown,
        Empty,
        Occupied,
        Attack,
    }

    public class ChessBoardSquare
    {
        public SquareState State { get; }
    }

    public class ChessBoardColumn
    {
        public List<ChessBoardSquare> Squares { get; }
        public ChessBoardColumn(int NumSquares)
        {
            this.Squares = new List<ChessBoardSquare>();
            for (int i = 0; i < NumSquares; i++)
            {
                this.Squares.Add(new ChessBoardSquare());
            }

        }

    }

    public class ChessBoard
    {
        private const int NUM_COLUMNS = 8;
        private const int NUM_ROWS = 8;
        public List<ChessBoardColumn> Columns { get; }


        /// <summary>
        /// CTOR - Constructor 
        /// </summary>
        public ChessBoard()
        {
            this.Columns = new List<ChessBoardColumn>();
            this.buildBoard();

        }

        public SquareState GetState(int column, int row)
        {
            if (column >= this.Columns.Count || row >= this.Columns[column].Squares.Count)
                return SquareState.Unknown;
            return this.Columns[column].Squares[row].State;
        }

        /// <summary>
        /// Method 
        /// </summary>
        private void buildBoard()
        {
            for (int i = 0; i < NUM_COLUMNS; i++)
            {
                this.Columns.Add(new ChessBoardColumn(NUM_ROWS));
            }
        }
    }
}
