using System.Linq;
using NUnit.Framework;

namespace Codility.Lesson03
{
    public static class PermMissingElem
    {
        [Test]
        public static void Test()
        {
            int result;

            result = Run(new[] { 2, 3, 1, 5 });
            Assert.AreEqual(4, result);

            result = Run(new[] { 2, 3, 4, 5 });
            Assert.AreEqual(1, result);

            result = Run(new[] { 1, 2, 3, 4 });
            Assert.AreEqual(5, result);

            var tmp = Enumerable.Range(1, 100000).ToList();
            tmp.RemoveAt(0);
            result = Run(tmp.ToArray());
            Assert.AreEqual(1, result);

            tmp = Enumerable.Range(1, 100000).ToList();
            tmp.Remove(1001);
            result = Run(tmp.ToArray());
            Assert.AreEqual(1001, result);
        }

        private static int Run(int[] A)
        {
            long n = A.Length + 1;
            long sumOfAllElements = n * (1 + n) / 2;

            for (long i = 0; i < A.Length; i++)
            {
                sumOfAllElements -= A[i];
            }

            return (int)sumOfAllElements;
        }
    }
}