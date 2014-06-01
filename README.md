# C# QuickSort

QuickSort implementation in C#. It's significantly faster than Java, as expected:

    $ mcs Main.cs QuickSort.cs
    $ time mono Main.exe IntArray.txt 100000

    real    0m1.389s
    user    0m0.127s
    sys	    0m0.010s
