using System;

namespace quicksort
{
	public class QuickSort<T>
	{
		public QuickSort ()
		{
		}

		private void swap( T[] list, int a, int b )
		{
			T temp = list [a];
			list [a] = list [b];
			list [b] = temp;
		}

		private int partition( T[] list, int left, int right, int pivotidx )
		{
			T pivot = list [pivotidx];
			swap (list, right, pivotidx);

			for (int i = left; i < right; i++) {
				if (System.Collections.Generic.Comparer<T>.Default.Compare(list [i], pivot) < 0) {
					swap (list, i, left);
					left++;
				}
			}

			swap (list, left, right);
			return left;
		}

		private void _quickSort( T[] list, int left, int right )
		{
			if (right > left) {
				int pivotidx = left;
				pivotidx = partition (list, left, right, pivotidx);
				_quickSort (list, left, pivotidx);
				_quickSort (list, pivotidx + 1, right);
			}
		}

		public T[] quicksort( T[] list )
		{
			_quickSort (list, 0, list.Length - 1);
			return list;
		}
	}
}