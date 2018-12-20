using NUnit.Framework;

namespace Codility.Lesson01
{
    public static class BinaryGap
    {
        [Test]
        public static void Test()
        {
            int result;

            result = Run2(9);
            Assert.AreEqual(2, result);

            result = Run2(529);
            Assert.AreEqual(4, result);

            result = Run2(20);
            Assert.AreEqual(1, result);

            result = Run2(15);
            Assert.AreEqual(0, result);

            result = Run2(1041);
            Assert.AreEqual(5, result);

            result = Run2(32);
            Assert.AreEqual(0, result);
        }

        private static int Run2(int N)
        {
            int maxGap = 0;
            int currentGap = -1;

            do
            {
                if (N % 2 == 0)
                {
                    if (currentGap > -1)
                    {
                        currentGap++;
                    }
                }
                else
                {
                    if (maxGap < currentGap)
                    {
                        maxGap = currentGap;
                    }

                    currentGap = 0;
                }
            } while ((N = N >> 1) > 0);

            return maxGap;
        }
    }
}