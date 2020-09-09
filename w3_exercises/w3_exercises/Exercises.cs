using System;
using System.Collections.Generic;
using System.Text;

namespace w3_exercises
{
    public class Exercises
    {
        static public int addNums(int num1, int num2)
        {
            return num1 + num2;
        }

        static public int divideNums(int num1, int num2)
        {
            return num1 / num2;
        }

        static public void swapNumbers(IUserInput input)
        {
            int num1 = input.GetInt();
            int num2 = input.GetInt();

            Console.WriteLine($"{num2}, {num1}");            
        }


    }
}
