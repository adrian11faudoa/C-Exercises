using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercises
{
    internal class FirstCode
    {
        static void Main(string[] args)
        {
            //Numeric Formatting
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0} {1}", value, 1000)); //Result: (value) 1000

            Console.WriteLine(string.Format("{0:0.00}", value)); //Result: (value) ; with the format 0.00
            Console.WriteLine(string.Format("{0:0.00}", value)); //Result: (value) ; with the format 0.00




            Console.ReadLine();
        }
    }
}
