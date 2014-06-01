using NUnit.Framework;
using System;

namespace quicksort
{
	[TestFixture ()]
	public class Test
	{
		private QuickSort<int> qs;

		[SetUp]
		public void SetUp()
		{
			qs = new QuickSort<int> ();
		}

		[Test ()]
		public void TestQuickSort ()
		{
			int[] unsorted = new int[] { 1, 21, 4, 8, 7, 15, 3 };
			int[] expected = new int[] { 1, 3, 4, 7, 8, 15, 21 };
			CollectionAssert.AreEqual (expected, qs.quicksort (unsorted));
		}
	}
}

