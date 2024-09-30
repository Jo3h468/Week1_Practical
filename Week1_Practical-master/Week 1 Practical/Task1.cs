using System;

namespace Week1Practical
{
    class Program
    {
        static void Main(string[] args)
        {




            void Task1()
            {
                Console.WriteLine("Enter your nanem :");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter your age :");
                int userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Hello {userName}, you will be {userAge + 5} in 5 years");
            }

            void Task2()
            {
                int userAge;
                Console.WriteLine("enter your age: ");
                userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 13)
                {
                    Console.WriteLine("You are a child.");
                }
                else if (userAge >= 13 && <= 19)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are an adult.");
                }
            }
            void Task3()
            {
                int intValue;
                Console.WriteLine("enter a number: ");
                intValue = Convert.ToInt32(Console.ReadLine());
                if (intValue < 0)
                {
                    Console.WriteLine("Your number is a negative number.");
                }
                else if (intValue > 0)
                {
                    Console.WriteLine("Your number is a positive number.");
                }
                else if (intValue == 0)
                {
                    Console.WriteLine("Your number is 0.");

                }
            } 
            void Task4() 
            {
                Console.WriteLine("Enter a year");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year < 0)
                {
                    Console.WriteLine($"{year} is not a valid year. it must npt be a negative number.");
                }
                else
                {
                    if ((year % 4 ==0 year % 100 != 0)|| (year % 400 == 0))
                    {
                        Console.WriteLine($"{year} is a leap year");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is a not leap year");
                    }
                    
                }
            }
            void Task5()
            {
                Console.WriteLine("enter a number.");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number");
                }
            }
        }
    }
}
