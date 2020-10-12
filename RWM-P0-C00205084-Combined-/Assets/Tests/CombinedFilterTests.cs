using NUnit.Framework;
using System;
using System.Diagnostics;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = {1, 2, 3, 4, 5};
            // 5, 21, 24, 31, 39
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 1, 3, 6, 10, 15 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}