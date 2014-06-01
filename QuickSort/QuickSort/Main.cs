using System;
using System.IO;

namespace quicksort
{
	static class Run
	{
		static public void Main (string[] args)
		{
			if (args.Length == 2) {
				QuickSort<int> qs = new QuickSort<int> ();
				int length = Convert.ToInt32 (args [1]);
				int[] unsorted = new int[length];

				TextReader file = new StreamReader (args [0]);

				for (int i = 0; i < length; i++)
					unsorted [i] = Convert.ToInt32 (file.ReadLine ());

				Console.WriteLine (string.Join (",", qs.quicksort (unsorted)));
			} else {
				Console.WriteLine ("Usage: ./program [list file] [list length]");
			}
		}
	}
}

