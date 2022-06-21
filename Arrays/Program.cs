
using System;

class Program
{
    static void Main()
    {
        int[] number = new int[6];

        
        number[2] = 100;
        number[3] = 10;
        number[4] = 0;
        number[5] = 1;
        number[0] = 3;
        number[1] = 4;
        Console.WriteLine(number[3]);
        number[3] = 11;
        Console.WriteLine(number[3]);

        string[] fruits = new string[4];
        fruits[0] = "banana";
        fruits[1] = "kiwi";
        fruits[2] = "mango";
        fruits[3] = "orange";

        Console.WriteLine(fruits[3][1]);
        Console.WriteLine(fruits[2]);
        fruits[2] = "grapes";
        Console.WriteLine(fruits[2]);

        System.Console.ReadKey();

    }
}

