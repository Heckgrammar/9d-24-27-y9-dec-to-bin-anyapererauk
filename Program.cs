using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN CHALLENGE: WRITE A PROGRAM TO CONVERT ANY INTEGER TO ITS EQUIVALENT BINARY NUMBER
            //WRITE A CALL TO YOUR NUMBER CONVERSION FUNCTION HERE
            
            //Task 1
            int num = 15;
            string string1 = Convert.ToString(num);
            Console.WriteLine(string1);

            //Task 2
            string string2 = "HELLO";
            string string3 = string1.Insert(0, string2);
            Console.WriteLine(string3);

            //Task 3 - remainder challenge
            Console.WriteLine("Enter a number you would like to turn into binary");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int[] binaryNum= { };
            if (userNum % 2 == 0)
            {
                new int[0] = binaryNum[0]; //The number 0 must be added to the end of the array.
            }                              // still need to figure that out. :(
            else if (userNum % 2 == 1)
            {
                new int[1] = binaryNum[0]; //The number 1 must be aded to the end of that array.
            }
            Array.Reverse(binaryNum);
            Console.WriteLine(binaryNum);
























        }








        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        //static string numberConversion(int number, int numberbase)
        //{
        //    //CODE GOES HERE

        //    //return result; //REMOVE THE RED LINE!
        //}
    }
}
