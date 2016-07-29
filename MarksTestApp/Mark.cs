using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksTestApp
{
    public static class Mark
    {
        public static void Test()
        {
            var chessboard = new ChessBoard();
            
            var State = chessboard.GetState(0, 5);
            Console.WriteLine("{0}", State);
            Console.ReadLine();
        }
    }

}
