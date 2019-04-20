using NUnit.Framework;
using System;

namespace Codility.Lesson06
{
    public static class Triangle
    {
        [Test]
        public static void Test()
        {
            var result = Run(new[] { 10, 2, 5, 1, 8, 20 });
            Assert.AreEqual(1, result);

            result = Run(new[] { 10, 50, 5, 1 });
            Assert.AreEqual(0, result);

            result = Run(new[] { int.MaxValue - 1, int.MaxValue, int.MaxValue - 2, 3 });
            Assert.AreEqual(1, result);
        }

        private static int Run(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i++)
            {
                if ((long)A[i] + A[i + 1] > A[i + 2])
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}