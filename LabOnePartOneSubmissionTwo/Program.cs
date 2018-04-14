﻿using System;

namespace LabOnePartOne
{
    class Program
    {


        static void Main(string[] args)
        {
            //Ask for user to input three digit numbers.
            Console.WriteLine("Enter a three digit number.");
            string FirstNumber = Console.ReadLine();
            Console.WriteLine("Enter another three digit number.");
            string SecondNumber = Console.ReadLine();


            //Validate the inputes are numbers using TryParse.
            int FirstNumberParse;
            int SecondNumberParse;

            bool FirstNumberBool = int.TryParse(FirstNumber, out FirstNumberParse);
            bool SecondNumberBool = int.TryParse(SecondNumber, out SecondNumberParse);


            //Establish a constant integer determining that the proper length of the inputs is 3 digits.
            const int ProperLengthNumber = 3;


            //Verify that both numbers are integers and exactly three digits long, if so, continue at the "Task" method.
            if (FirstNumberBool && SecondNumberBool)
            if ((FirstNumber.Length > ProperLengthNumber) && (SecondNumber.Length > ProperLengthNumber))
                Console.WriteLine("Both of your numbers have more than three digits.");
            else
            {
                if (FirstNumber.Length > ProperLengthNumber)
                    Console.WriteLine("Your first number had more than three digits.");
                else
                {
                     if ((FirstNumber.Length < ProperLengthNumber) && (SecondNumber.Length < ProperLengthNumber))
                         Console.WriteLine("Both of your numbers have less than three digits.");
                     else
                     {
                          if (FirstNumber.Length < ProperLengthNumber)
                              Console.WriteLine("Your first number had less than three digits.");
                          else
                          {
                               if (SecondNumber.Length > ProperLengthNumber)
                                   Console.WriteLine("Your second number had more than three digits.");
                               else
                               {
                                    if (SecondNumber.Length < ProperLengthNumber)
                                        Console.WriteLine("Your second number had less than three digits.");
                                    else
                                    {
                                        Task(FirstNumber, SecondNumber);
                                    }
                                }
                            }
                        }

                     }
                }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
        static void Task(string FirstNumber, string SecondNumber)
        {
            //Identify the Ones, Tens, & Hundreds place of each three digit number.
            int FirstNumberHundreds = FirstNumber[0];
            int FirstNumberTens = FirstNumber[1];
            int FirstNumberOnes = FirstNumber[2];

            int SecondNumberHundreds = SecondNumber[0];
            int SecondNumberTens = SecondNumber[1];
            int SecondNumberOnes = SecondNumber[2];


            //Add the two numbers in the hundreds place, the two numbers in the tens place, & the two numbers in the ones place.  Assign a varriable to each of the sums.
            int OnesSum = (FirstNumberOnes + SecondNumberOnes);             int TensSum = (FirstNumberTens + SecondNumberTens);             int HundredsSum = (FirstNumberHundreds + SecondNumberHundreds);


            //Verify that the sum of the numbers in the ones place is equal to the sum of the numbers in the tens place and that the sum of the numbers in the tens place is equal to the sum of the numbers in the hundreds place.
            //If yes then true, if no then false.
            if (OnesSum == TensSum && TensSum == HundredsSum)
                Console.WriteLine(true);
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}