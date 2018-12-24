using NUnit.Framework;

namespace Codility.Lesson04
{
    public static class PermCheck
    {
        [Test]
        public static void Test()
        {
            var result = Run(new[] { 2, 1, 3, 4 });
            Assert.AreEqual(1, result);

            result = Run(new[] { 4, 1, 3 });
            Assert.AreEqual(0, result);

            result = Run(new[] { 1, 1, 4 });
            Assert.AreEqual(0, result);
        }

        private static int Run(int[] A)
        {
            int[] counter = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 1 || A[i] > A.Length)
                {
                    return 0;
                }
                if (counter[A[i] - 1] == 1)
                {
                    return 0;
                }
                counter[A[i] - 1] = 1;
            }

            return 1;
        }
    }
}
