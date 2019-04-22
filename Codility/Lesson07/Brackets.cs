using NUnit.Framework;
using System.Collections.Generic;

namespace Codility.Lesson07
{
    public static class Brackets
    {
        [Test]
        public static void Test()
        {
            var result = Run("{[()()]}");
            Assert.AreEqual(1, result);

            result = Run("([)()]");
            Assert.AreEqual(0, result);

            result = Run(")(");
            Assert.AreEqual(0, result);
        }

        private static int Run(string S)
        {
            var stack = new Stack<char>();

            var bracketPairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (var character in S)
            {
                if (character == '(' || character == '{' || character == '[')
                {
                    stack.Push(character);
                }
                else if (character == ')' || character == '}' || character == ']')
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    var removed = stack.Pop();
                    if (character != bracketPairs[removed])
                    {
                        return 0;
                    }

                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}