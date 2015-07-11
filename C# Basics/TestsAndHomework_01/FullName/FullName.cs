using System;

class FullName
{
    static void Main()
    {
        //common way
        Console.WriteLine("My first name is Stiliyan.");
        Console.WriteLine("My last name is Kostadinov.");
        Console.WriteLine("My full name is Stiliyan Kostadinov.");

        //using placeholders and variables
        string firstName = "Stiliyan";
        string lastName = "Kostadinov";

        Console.WriteLine("{0}\n{1}\n{0} {1}", firstName, lastName);
    }
}

