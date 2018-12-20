using NUnit.Framework;

namespace Codility.Lesson02
{
    public static class CyclicRotation
    {
        [Test]
        public static void Test()
        {
            int[] A;
            int[] result;

            A = new int[0];
            result = Run(A, 1);
            Assert.AreEqual(new int[0], result);

            A = new[] { 1, 2, 3, 4 };
            result = Run(A, 1);
            Assert.AreEqual(new[] { 4, 1, 2, 3 }, result);
        }

        private static int[] Run(int[] A, int K)
        {
            if (K == 0 || A.Length == 0)
            {
                return A;
            }

            int[] result = new int[A.Length];

            var shift = K % A.Length;

            for (int i = 0; i < A.Length; i++)
            {
                var position = (i + shift) % A.Length;
                result[position] = A[i];
            }

            return result;
        }
    }
}