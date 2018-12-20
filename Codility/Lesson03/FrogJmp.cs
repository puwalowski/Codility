using System;
using NUnit.Framework;

namespace Codility.Lesson03
{
    public static class FrogJmp
    {
        [Test]
        public static void Test()
        {
            int result = Run(10, 85, 30);
            Assert.AreEqual(3, result);
        }

        private static int Run(int X, int Y, int D)
        {
            double x = (Y - X) / (double)D;
            return (int)Math.Ceiling(x);
        }
    }
}