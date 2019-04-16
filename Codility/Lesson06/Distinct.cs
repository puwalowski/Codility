using System.Collections.Generic;
using NUnit.Framework;

namespace Codility.Lesson06
{
    public static class Distinct
    {
        [Test]
        public static void Test()
        {
            var result = Run(new[] { 2, 1, 1, 2, 3, 1 });
            Assert.AreEqual(3, result);
        }

        private static int Run(int[] A)
        {
            var hashSet = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!hashSet.Contains(A[i]))
                {
                    hashSet.Add(A[i]);
                }
            }

            return hashSet.Count;
        }
    }
}