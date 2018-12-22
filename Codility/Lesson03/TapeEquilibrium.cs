using System;
using NUnit.Framework;

namespace Codility.Lesson03
{
    public static class TapeEquilibrium
    {
        [Test]
        public static void Test()
        {
            var result = Run(new[] { 3, 1, 2, 4, 3 });
            Assert.AreEqual(1, result);

            result = Run(new[] { 3, 2, 5 });
            Assert.AreEqual(0, result);

            result = Run(new[] { -3, -2, -2 });
            Assert.AreEqual(1, result);
        }

        private static int Run(int[] A)
        {
            long sumA = 0;
            for (long i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }

            long minDifference = long.MaxValue;
            long leftSum = 0;

            for (long i = 1; i < A.Length; i++)
            {
                leftSum += A[i - 1];
                long rightSum = sumA - leftSum;

                long difference = Math.Abs(leftSum - rightSum);
                if (minDifference > difference)
                {
                    minDifference = difference;
                }

                if (minDifference == 0)
                {
                    return 0;
                }
            }

            return (int) minDifference;
        }
    }
}
