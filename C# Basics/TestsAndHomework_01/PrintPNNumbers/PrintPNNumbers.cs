using System;

class PrintPNNumbers
{
    static void Main()
    {
        //all odds are negative
        int printNums;
        for (printNums = 1; printNums <= 10; printNums++)
            {
                if (printNums % 2 == 0)
                {
                    Console.WriteLine(printNums);
                }
                else
                {
                    Console.WriteLine(printNums*(-1));
                }
            }
        Console.WriteLine(" ");
        //now all evens are negative
        for (printNums = 1; printNums<=10; printNums++)
        {
            if (printNums % 2 == 0)
            {
                Console.WriteLine(printNums*(-1));
            }
            else
            {
                Console.WriteLine(printNums);
            }
        }

    }
}

