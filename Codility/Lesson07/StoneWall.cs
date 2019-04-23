using System.Collections.Generic;
using NUnit.Framework;

namespace Codility.Lesson07
{
    public static class StoneWall
    {
        [Test]
        public static void Test()
        {
            var result = Run(new[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });
            Assert.AreEqual(7, result);
        }

        private static int Run(int[] H)
        {
            int numberOfBlocks = 0;

            var stack = new Stack<int>();

            for (int i = 0; i < H.Length; i++)
            {
                while (stack.Count != 0 && stack.Peek() > H[i])
                {
                    stack.Pop();
                }

                if (stack.Count != 0 && stack.Peek() == H[i])
                {
                    continue;
                }

                numberOfBlocks++;
                stack.Push(H[i]);
            }

            return numberOfBlocks;
        }
    }
}