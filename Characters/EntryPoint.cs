
using System;

class EntryPoint
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        char theCharX = 'x';
        System.Console.WriteLine(theCharX);

        char thePlusSign = '\u00F6';
        System.Console.WriteLine(thePlusSign);

        System.Console.ReadKey();
    }
}

