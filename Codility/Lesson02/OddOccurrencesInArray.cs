using NUnit.Framework;

namespace Codility.Lesson02
{
    public static class OddOccurrencesInArray
    {
        [Test]
        public static void Test()
        {
            int[] input;
            int result;

            input = new[] { 9, 3, 9, 3, 9, 7, 9 };
            result = Run(input);
            Assert.AreEqual(7, result);
        }

        private static int Run(int[] A)
        {
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                result ^= A[i];
            }

            return result;
        }
    }
}
