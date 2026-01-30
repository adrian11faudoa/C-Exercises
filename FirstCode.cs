using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace FirstExercises
{
    internal class FirstCode
    {
        static void Main(string[] args)
        {
            //Array Sorting
            int[] numbers = new int[]
            {
                9, 2, 3, 1, 5, 0, 7, 8, 9
            };

            Array.Sort(numbers); //Return void (nothing) but changes the array order

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            } 
                


            Console.ReadLine();

        }
    }
}
