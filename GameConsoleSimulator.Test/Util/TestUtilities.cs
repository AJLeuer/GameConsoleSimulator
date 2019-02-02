﻿using System.Collections.Generic;
using NUnit.Framework;

namespace GameConsoleSimulator.Test.Util
{
    public class AdditionalCollectionAssertions : CollectionAssert
    {
        /// <summary>
        /// Assert that all expected items are contained in the collection
        /// </summary>
        /// <param name="actual">The collection under test</param>
        /// <param name="expectedItems">The expected contents of the collection</param>
        /// <typeparam name="T">The type of item in the collection</typeparam>
        public static void AssertContains<T>(ICollection<T> actual, params T[] expectedItems)
        {
            AreEquivalent(expected: expectedItems, actual: actual);
        }
    }
}