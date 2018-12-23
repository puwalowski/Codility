using NUnit.Framework;

namespace Codility.Lesson04
{
    public static class FrogRiverOne
    {
        [Test]
        public static void Test()
        {
            var result = Run(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 });
            Assert.AreEqual(6, result);

            result = Run(5, new[] { 1, 3, 1, 4 });
            Assert.AreEqual(-1, result);
        }

        private static int Run(int X, int[] A)
        {
            int[] count = new int[X + 1];
            count[0] = 1;

            int leftZeros = X;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > X)
                {
                    continue;
                }

                if (count[A[i]] == 0)
                {
                    leftZeros--;
                }

                if (leftZeros == 0)
                {
                    return i;
                }

                count[A[i]]++;
            }

            return -1;
        }

    }
}
