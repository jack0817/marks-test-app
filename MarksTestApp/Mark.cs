using System;

namespace MarksTestApp
{
    public static class Mark
    {
        public static void Test()
        {
            var chessboard = new ChessBoard();
            var whatDidYouSay = chessboard.asdfasdfasdfsd(123);
            Console.Write(whatDidYouSay);

            var square = chessboard.GetSquare(7, 6);
            Console.WriteLine("Square ID:    {0}", square.GetId());
            Console.WriteLine("Square State: {0}", square.State);
            Console.ReadLine();
        }
    }
}
