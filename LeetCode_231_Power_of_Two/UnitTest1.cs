using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LeetCode_231_Power_of_Two
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void n_is_less_or_equal_0_should_return_false()
        {
            IsNotPowerOfTwo(0);
        }

        [TestMethod]
        public void n_is_1_should_return_true()
        {
            IsPowerOfTwo(1);
        }

        [TestMethod]
        public void n_is_2_should_return_true()
        {
            IsPowerOfTwo(2);
        }

        [TestMethod]
        public void n_is_6_should_be_false()
        {
            IsNotPowerOfTwo(6);
        }

        [TestMethod]
        public void n_is_12_should_be_false()
        {
            IsNotPowerOfTwo(12);
        }

        [TestMethod]
        public void n_is_1024_should_be_true()
        {
            IsPowerOfTwo(1024);
        }

        private static void IsPowerOfTwo(int n)
        {
            Assert.IsTrue(new Solution().IsPowerOfTwo(n));
        }

        private static void IsNotPowerOfTwo(int n)
        {
            Assert.IsFalse(new Solution().IsPowerOfTwo(n));
        }
    }

    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;

            var charArray = Convert.ToString(n, 2).ToCharArray();
            return charArray.Count(x => x == '1') == 1;
        }
    }
}