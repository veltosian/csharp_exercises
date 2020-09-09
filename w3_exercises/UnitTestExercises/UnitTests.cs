using Microsoft.VisualStudio.TestTools.UnitTesting;
using w3_exercises;

namespace UnitTestExercises
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void testExercises()
        {
            int result = Exercises.addNums(2, 4);
            Assert.AreEqual(6, result);

            result = Exercises.divideNums(2, 4);
            Assert.AreEqual(0, result);
        }

        public void testSwapNumbers()
        {
            Exercises.swapNumbers(new FakeUserInput());
        }
    }
}
