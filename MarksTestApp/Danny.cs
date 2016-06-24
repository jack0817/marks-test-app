using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksTestApp
{
    public static class Danny
    {
        public static void Test()
        {
            while (true)
            {
                Console.WriteLine("Type x to Exit");
                var input = Console.ReadLine();
                if (input == "x")
                {
                    break;
                }
            }

            //List<int> columns = new List<int>(8);
            //List<int> rows = new List<int>(8);
            var checkerboard = new List<List<int>>(64);
            int maxColumns = 8;
            int maxRows = 8;

            for (int c = 0; c < maxColumns; c++)
            {
                checkerboard.Add(new List<int>());
                for (int r = 0; r < maxRows; r++)
                {
                    checkerboard[c].Add(r);
                }
            }

            for (int c = 0; c < maxColumns; c++)
            {
                for (int r = 0; r < maxRows; r++)
                {
                    Console.WriteLine("{0}", checkerboard[c][r]);
                }
            }

            //foreach (int c in columns)
            //{
            //    foreach (var r in rows)
            //    {
            //        Console.WriteLine("this fucking number {0}{1}", c,r);
            //    }
            //}



        }
    }
}
