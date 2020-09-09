using System;
using System.Collections.Generic;
using System.Text;

namespace w3_exercises
{
    class UserInteract : IUserInput
    {
        public int GetInt()
        {
            int usrInt = 0;
            bool tryAgain = true;

            while (tryAgain == true)
            {
                tryAgain = false;
                Console.WriteLine("Please enter an integer");
                try
                {
                    usrInt = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    tryAgain = true;
                }
            }

            return usrInt;
        }
    }
}
