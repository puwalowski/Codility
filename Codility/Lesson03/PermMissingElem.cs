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
        }

        private static int Run(int[] A)
        {
            int n = A.Length + 1;
            int sumOfAllElements = (n * (1 + n)) / 2;
            int missingElement = sumOfAllElements - A.Sum();
            return missingElement;
        }
    }
}