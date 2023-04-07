using System;
/*
 Đề bài : Create a console application in chapter 03 named Exercise 04 that ask the user for
two numbers in the range 0-255 and then divides the first number by the second:

and write exception handlers to catch any thrown errors, as shown in the following output
 */

public class Task1
{
    public static void InputValue(ref int num1, ref int num2)
    {
        try
        {
            Console.Write("Input the first numbers : ");
            num1 = System.Convert.ToInt32(Console.ReadLine());

            Console.Write("\nnput the second numbers : ");
            num2 = System.Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.WriteLine("Value Error : " + e);
        }

    }

    public static void HandleValue(ref int num1, ref int num2)
    {

        try
        {
            Console.WriteLine("\n {0} divided by {1} is {2} ", num1, num2, System.Convert.ToSingle(num1) / System.Convert.ToSingle(num2));
        }
        catch (Exception e)
        {
            Console.WriteLine("Value Error : " + e);
        }


    }
    public static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        InputValue(ref num1, ref num2);
        HandleValue(ref num1, ref num2);
    }
}