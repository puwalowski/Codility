using NUnit.Framework;
using System;

namespace Codility.Lesson06
{
    public static class MaxProductOfThree
    {
        [Test]
        public static void Test()
        {
            var result = Run(new[] { -3, 1, 2, -2, 5, 6 });
            Assert.AreEqual(60, result);

            result = Run(new[] { 4, 5, 1, 0 });
            Assert.AreEqual(20, result);

            result = Run(new[] { -10, -2, -4 });
            Assert.AreEqual(-80, result);

            result = Run(new[] { -4, -6, 3, 4, 5 });
            Assert.AreEqual(120, result);

            result = Run(new[] { -5, -6, -4, -7, -10 });
            Assert.AreEqual(-120, result);

            result = Run(new[] { 4, 7, 3, 2, 1, -3, -5 });
            Assert.AreEqual(105, result);
        }

        private static int Run(int[] A)
        {
            Array.Sort(A);
            return Math.Max(A[0] * A[1] * A[A.Length - 1], A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3]);
        }
    }
}