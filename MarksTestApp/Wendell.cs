using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksTestApp
{
    public class AirplaneSeat
    {
        public AirplaneColumn parentColumn { get; }
        public int seatIndex { get; }
        public bool isFirstClass;
        public bool isOccupied;

        public string seatId
        {
            get { return string.Format("{0}{1}", this.parentColumn.name, this.seatIndex); }
        }

        public AirplaneSeat(AirplaneColumn column, int index)
        {
            this.parentColumn = column;
            this.seatIndex = index;
        }
    }

    public class AirplaneColumn
    {
        public string name { get; set; }
        public int numberOfSeats { get; set; }
        public List<AirplaneSeat> seats = new List<AirplaneSeat>();

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="numRows"></param>
        public AirplaneColumn(int numRows)
        {
            this.numberOfSeats = numRows;
            this.buildSeats();
        }

        public AirplaneSeat GetNextSeat()
        {
            foreach (var seat in this.seats)
            {
                if (!seat.isOccupied)
                {
                    return seat;
                }
            }

            return null;
        }

        private void buildSeats()
        {
            for (int i = 0; i < this.numberOfSeats; i++)
            {
                this.seats.Add(new AirplaneSeat(this, i));
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Airplane
    {
        private int _numberOfColumns;
        private int _seatsPerColumn;

        public int numberOfColumns
        {
            get { return this._numberOfColumns; }
        }

        public int seatsPerColumn
        {
            get { return this._seatsPerColumn; }
        }

        public List<AirplaneColumn> columns = new List<AirplaneColumn>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numColumns"></param>
        /// <param name="numSeats"></param>
        public Airplane(int numColumns, int numSeats)
        {
            this._numberOfColumns = numColumns;
            this._seatsPerColumn = numSeats;
            this.buildColumns();
        }

        public AirplaneSeat GetNextAvailableSeat()
        {
            AirplaneSeat seat = null;
            foreach (var column in this.columns)
            {
                seat = column.GetNextSeat();
                if (seat != null)
                {
                    return seat;
                }
            }

            return seat;
        }

        /// <summary>
        /// Method
        /// </summary>
        private void buildColumns()
        {
            for (int i = 0; i < this.numberOfColumns; i++)
            {
                var column = new AirplaneColumn(this.seatsPerColumn);
                this.SetColumnName(column, i);
                this.columns.Add(column);
            }
        }

        private void SetColumnName(AirplaneColumn column, int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    column.name = "A";
                    break;
                case 1:
                    column.name = "B";
                    break;
                case 2:
                    column.name = "C";
                    break;
                case 3:
                    column.name = "D";
                    break;
            }
        }
    }

    public static class Wendell
    {
        public static void Test()
        {
            var airplane = new Airplane(4, 20);
            var seat = airplane.GetNextAvailableSeat();

            while (seat != null)
            {
                Console.WriteLine("Seat at {0} is being occupied.", seat.seatId);
                seat.isOccupied = true;
                seat = airplane.GetNextAvailableSeat();
            }
        }
    }
}
