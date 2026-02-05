using System;
using System.Collections.Generic;


//Lists <>
int[] numbers = new int[3]
{
    1, 2, 3
};

List<int> listNumbers = new List<int>();

//listNumbers.Add(1);

for (int i = 0; i < 3; i++)
{
    Console.Write("Enter a number: ");
    listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.ReadLine();
