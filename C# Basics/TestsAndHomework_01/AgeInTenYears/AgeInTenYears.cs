using System;

class AgeInTenYears
{
    static void Main()
    {
        Console.WriteLine("Write down your date of birth: dd.MM.yyyy");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());            //create object by datetime.parse(console.readline())
        DateTime today = DateTime.Today;                                    //create object by datetime.today
        int birthDay = today.DayOfYear - birthDate.DayOfYear;               //DEFINE ALL VARIABLES!
        int currentAge;

        if (birthDay == 0)                                                  //create cycle to calculate weather it is or it isn't one's birthday
        {
            currentAge = today.Year - birthDate.Year;
            Console.WriteLine(" ");
            Console.WriteLine("HAPPY BIRTHDAY!!!");
        }
        else if (birthDay < 0)
        {
            currentAge = (today.Year - birthDate.Year) - 1;
        }
        else
        {
            currentAge = today.Year - birthDate.Year;
        }

        Console.WriteLine(" ");                                                          //print results
        Console.WriteLine("You are {0} years old now.", currentAge);
        Console.WriteLine("In ten years you will be {0} years old.", currentAge + 10);
    }
}

