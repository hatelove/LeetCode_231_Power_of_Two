using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode_231_Power_of_Two
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void n_is_less_or_equal_0_should_return_false()
        {
            var n = 0;
            ShouldBeFalse(n);
        }

        [TestMethod]
        public void n_is_1_should_return_true()
        {
            var n = 1;
            ShouldBeTrue(n);
        }

        private static void ShouldBeTrue(int n)
        {
            Assert.IsTrue(new Solution().IsPowerOfTwo(n));
        }

        private static void ShouldBeFalse(int n)
        {
            Assert.IsFalse(new Solution().IsPowerOfTwo(n));
        }
    }

    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;

            if (n == 1)
            {
                return true;
            }
            
            throw new NotImplementedException();
        }
    }
}