using NUnit.Framework;
using System.Collections.Generic;

namespace Codility.Lesson07
{
    public static class Nesting
    {
        [Test]
        public static void Test()
        {
            var result = Run("(()(())())");
            Assert.AreEqual(1, result);

            result = Run("())");
            Assert.AreEqual(0, result);
        }

        private static int Run(string S)
        {
            var stack = new Stack<char>();

            foreach (var character in S)
            {
                if (character == '(')
                {
                    stack.Push(character);
                }
                else if (character == ')')
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    stack.Pop();
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}