using System.Collections.Generic;

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
        public ChessBoardColumn ParentColumn { get; }
        public string Identifier { get; set; }
        public SquareState State { get; }

        public ChessBoardSquare(ChessBoardColumn parentColumn)
        {
            this.ParentColumn = parentColumn;
        }

        public string GetId()
        {
            return string.Format("{0}{1}", this.ParentColumn.Identifier, this.Identifier);
        }
    }

    public class ChessBoardColumn
    {
        public string Identifier { get; set; }
        public List<ChessBoardSquare> Squares { get; }
  
        public ChessBoardColumn(int numSquares)
        {
            this.Squares = new List<ChessBoardSquare>();
            for (int i = 0; i < numSquares; i++)
            {
                var square = new ChessBoardSquare(this);
                square.Identifier = (i + 1).ToString();
                this.Squares.Add(square);
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

        public ChessBoardSquare GetSquare(int col, int row)
        {
            if (col >= this.Columns.Count || row >= this.Columns[col].Squares.Count)
                return null;

            return this.Columns[col].Squares[row];
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
                var column = new ChessBoardColumn(NUM_ROWS);
                column.Identifier = this.TranslateColumnIndex(i);
                this.Columns.Add(column);
            }
        }

        private string TranslateColumnIndex(int index)
        {
            const int asciiOffset = 65;
            var character = (char)(index + asciiOffset);
            return character.ToString();
        }
    }
}
