﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int myage = 36;
            float mypercentage = 5.2f;
            double mysalary = 100.00;
            char firstinitial = 'm';
            string name = "mark";
            name.Length;
            bool isofage;
            isofage = true;
            int dannyage = 38;
            bool ismarkolder = myage > dannyage;
            bool whiteness = true;
            int totalage = myage += 10;
            int[] ages = { 21,1,5,5,2,3,4,5,43};

            Console.WriteLine(totalage);


            if (ismarkolder && whiteness)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            switch (dannyage)
            {
                case 40:
                    Console.WriteLine("Danny is 38");
                    break;
                default :
                    Console.WriteLine("DANNY IS UNKNOWN");
                    break;

            }

            for (int x = ages.Length - 1; x >= 0; x--)
            {
                int ageValue = ages[x];
                Console.WriteLine(ageValue);
            }

            //bool keepgoing = true;
            //int current = 0;
            //while (keepgoing)
            //{
            //    current += 1;
            //    if (current == 100001)
            //    {
            //        keepgoing = false;
            //        Console.WriteLine("WOOT");
            //    }
            //    else
            //    {
            //        Console.WriteLine(current);
            //    }

            //}



            //Console.WriteLine("{0}", isvalid);

            Person Mark = new Person();
            Mark.Age = 12;
            Mark.BirthDate = DateTime.Now;

            Person Danny = new Person();
            Danny.Age = 13;
            Danny.BirthDate = DateTime.Now;

            int NewAge = Mark.Age + Danny.Age;

            Console.WriteLine(NewAge);


            Console.Read();


            
        }
    }
}