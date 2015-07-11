using System;

class PrintSquareRoot

{
    static void Main()
    {
        //with code-pointed number
        int number = 12345;
        Console.WriteLine(Math.Sqrt(number));
        Console.WriteLine();

        //with keyboard input
        Console.WriteLine("Write the number you want to see the square root of:");
        Console.WriteLine();

        int firstNum;
        firstNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number you entered is {0} and its square root is {1}", firstNum, Math.Sqrt(firstNum));
        //first define the integer, then convert to INT32! and then readLINE from keyboard
    }
}

