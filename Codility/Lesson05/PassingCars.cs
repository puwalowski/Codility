using NUnit.Framework;

namespace Codility.Lesson05
{
    public static class PassingCars
    {
        [Test]
        public static void Test()
        {
            var result = Run(new[] { 0, 1, 0, 1, 1 });
            Assert.AreEqual(5, result);
        }

        private static int Run(int[] A)
        {
            long count = 0;
            int incrementVal = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    incrementVal++;
                }
                else if (A[i] == 1)
                {
                    count = count + incrementVal;
                }
                if (count > 1000000000)
                {
                    return -1;
                }
            }

            return (int)count;
        }
    }
}