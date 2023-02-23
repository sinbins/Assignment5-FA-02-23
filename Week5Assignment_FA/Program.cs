using System;
using System.Reflection.Metadata;

//Assignment 5
//Fabian Acosta
//02-23-2023
namespace Week5Assignment_FA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Functions
            ProblemTwo();
            ProblemThree();
            ProblemFive();
        }



        static void ProblemTwo()
        {
            //Variables
            int total = 0;
            //Prompt user
            Console.WriteLine("Enter a number or \"ok\" to quit. ");
            string userInput = Console.ReadLine();
            
            //Loops while user keeps entering a number
          while(userInput != "ok")
            {
                //Converts userInput to add to total
                total += Convert.ToInt32(userInput);
                Console.WriteLine("Enter a number or \"ok\" to quit. ");
                userInput = Console.ReadLine();

            }
            Console.WriteLine("Your total: " + total + "\n");
        }
        static void ProblemThree()
        {
            //Prompt user
            Console.WriteLine("Enter a number to compute it's factorial: ");
            //Variables
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int total = userNumber; //Total set to userNumber to get the number of where we start
            //Loops through the userNumbers factorial decreasing the number and multiplying it by the previous number
            for (int i = userNumber; i > 1; i--)
            {
                total *= (i - 1); 
            }
            //Output
            Console.WriteLine("Factorial results: " + userNumber + "! = " + total + "\n");

        }
        static void ProblemFive()
        {
            //Prompt user
            Console.WriteLine("Enter a series of numbers separated by a comma: ");
            //Input
            string numbers = Console.ReadLine();
            //Split each number into an array index
            string[] numbersArr = numbers.Split(',');
            //make intNumbers the same length as numbersArr for index out of range
            int[] intNumbers = new int[numbersArr.Length];
            //Max variable set to first element of intNumbers to later compare
            int max = intNumbers[0];
                //Assign each numbersArr element to intNumbers 
                for(int i = 1; i < numbersArr.Length; i++)
                {
                    intNumbers[i] = Convert.ToInt32(numbersArr[i]);
                    //Compare numbers to max
                    if(max < intNumbers[i])
                    {
                        max = intNumbers[i];
                    }
               
                }
                Console.WriteLine("The max number you entered was " + max + "\n");
        }
    }
    


}