﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.IsFalse(new Solution().IsPowerOfTwo(n));
        }
    }

    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            throw new NotImplementedException();
        }
    }
}