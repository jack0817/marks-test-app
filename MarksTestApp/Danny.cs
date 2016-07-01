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
            //while (true)
            //{
            //    Console.WriteLine("Type x to Exit");
            //    var input = Console.ReadLine();
            //    if (input == "x")
            //    {
            //        break;
            //    }
            //}

            //List<int> columns = new List<int>(8);
            //List<int> rows = new List<int>(8);



            //var checkerboard = new List<List<int>>(64);
            //int maxColumns = 8;
            //int maxRows = 8;

            //for (int c = 0; c < maxColumns; c++)
            //{
            //    checkerboard.Add(new List<int>());
            //    for (int r = 0; r < maxRows; r++)
            //    {
            //        checkerboard[c].Add(r);
            //    }
            //}

            //for (int c = 0; c < maxColumns; c++)
            //{
            //    for (int r = 0; r < maxRows; r++)
            //    {
            //        Console.WriteLine("{0}", checkerboard[c][r]);
            //    }
            //}




            //foreach (int c in columns)
            //{
            //    foreach (var r in rows)
            //    {
            //        Console.WriteLine("this fucking number {0}{1}", c,r);
            //    }
            //}

            var dannyplane = new List<List<bool>>();
            int planeColumns = 4;
            int planeRows = 10;

            for (int c = 0; c < planeColumns; c++)
            {
                var column = new List<bool>();
                dannyplane.Add(column);
                for (int row = 0; row < planeRows; row++)
                {
                    column.Add(false);
                    //dannyplane[c].Add(row);
                }
            }

            //for (int rows = 0; rows < planeRows; rows++)
            //{
            //    for (int c = 0; c < planeColumns; c++)
            //    {
            //        Console.Write("[{0}] ", dannyplane[c][rows]);
            //    }
            //    Console.WriteLine();
            //}

            while (true)
            {
                for (int rows = 0; rows < planeRows; rows++)
                {
                    for (int c = 0; c < planeColumns; c++)
                    {
                        Console.Write("[{0}] ", dannyplane[c][rows]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Do you want a Seat? Press Y for yes, or X to exit the application");
                var input = Console.ReadLine();
                if (input == "x" || input == "X")
                {
                    break;
                }
                else if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    bool isfound = false;
                    for (int rows = 0; rows < planeRows && !isfound; rows++)
                    {
                        for (int c = 0; c < planeColumns; c++)
                        {
                            if (dannyplane[c][rows] == false)
                            {
                                isfound = true;
                                dannyplane[c][rows] = true;
                                Console.WriteLine("Seat Found at column [{0}] row [{1}]!", c, rows);
                                break;
                            }

                        }

                        //    if (isfound)
                        //    {
                        //        break;
                        //    }
                    }

                    if (isfound == false)
                    {
                        Console.WriteLine("TAKEOFF!!!!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Entry!!!!");
                }
            }

        }
    }
}
