using System;

namespace Homework4Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region YearSwitch
            Console.WriteLine("Input a year:");
            string year = Console.ReadLine();
            int intYear = int.Parse(year);

            Console.WriteLine("Input number of a month: ");
            string monthNumber = Console.ReadLine();
            int intMonthNumber = int.Parse(monthNumber);

            switch (intMonthNumber)
            {
                case 1:
                    Console.WriteLine("Day number in January: 31");
                    break;
                case 2:
                    if (intYear % 4 != 0)
                    {
                        Console.WriteLine("Day number in February: 29");
                    }
                    else
                    {
                        Console.WriteLine("Day number in February: 28");
                    }
                    break;
                case 3:
                    Console.WriteLine("Day number in March: 31");
                    break;
                case 4:
                    Console.WriteLine("Day number in April: 30");
                    break;
                case 5:
                    Console.WriteLine("Day number in May: 31");
                    break;
                case 6:
                    Console.WriteLine("Day number in June: 30");
                    break;
                case 7:
                    Console.WriteLine("Day number in July: 31");
                    break;
                case 8:
                    Console.WriteLine("Day number in August: 31");
                    break;
                case 9:
                    Console.WriteLine("Day number in September: 30");
                    break;
                case 10:
                    Console.WriteLine("Day number in October: 31");
                    break;
                case 11:
                    Console.WriteLine("Day number in November: 30");
                    break;
                case 12:
                    Console.WriteLine("Day number in December: 31");
                    break;
                default:
                    Console.WriteLine("Wrong month number");
                    break;
            }
            Console.ReadLine();
            #endregion

            #region Calculator

            Console.WriteLine("Enter the first Integer: ");
            string firstInteger = Console.ReadLine();
            int intFirstInteger = int.Parse(firstInteger);
            decimal decFirstInteger = Convert.ToDecimal(intFirstInteger);

            Console.WriteLine("Enter the second Integer: ");
            string secondInteger = Console.ReadLine();
            int intSecondInteger = int.Parse(secondInteger);
            decimal decSecondInteger = Convert.ToDecimal(intSecondInteger);

            Console.WriteLine();

            Console.WriteLine(@"Here are the options :
            1 - Addition.
            2 - Subtraction.
            3 - Multiplication.
            4 - Division.
            5 - Exit.");

            Console.WriteLine();

            Console.WriteLine("Enter option number: ");
            string optionNumber = Console.ReadLine();
            int intOptionNumber = int.Parse(optionNumber);

            switch (intOptionNumber)
            {
                case 1:
                    int intAddition = intFirstInteger + intSecondInteger;
                    Console.WriteLine($"Addition: {intFirstInteger} + {intSecondInteger} = {intAddition}");
                    break;
                case 2:
                    int intSubtraction = intFirstInteger - intSecondInteger;
                    Console.WriteLine($"Substraction: {intFirstInteger} - {intSecondInteger} = {intSubtraction}");
                    break;
                case 3:
                    int intMultiplication = intFirstInteger * intSecondInteger;
                    Console.WriteLine($"Multiplication: {intFirstInteger} * {intSecondInteger} = {intMultiplication}");
                    break;
                case 4:
                    decimal decDivision = decFirstInteger / decSecondInteger;
                    if (intSecondInteger == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                    }
                    else
                    {
                    Console.WriteLine($"Division: {intFirstInteger} / {intSecondInteger} = {decDivision}");
                    }
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Incorrect input.");
                    break;
                    
            }
            Console.ReadLine();
                     


            #endregion
        }
    }
}
