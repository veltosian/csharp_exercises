using System;
using System.Collections.Generic;
using System.Text;
using w3_exercises;

namespace UnitTestExercises
{
    class FakeUserInput : IUserInput
    {
        int seed = 0;

        public int GetInt()
        {
            return seed++;
        }
    }
}
