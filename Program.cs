﻿using System;
using System.Collections.Generic;
using Lab3.SortingAlgorithms;
using System.Diagnostics;
using Lab3.Sorting_Algorithms;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = GenerateRandomIntList(10_000_000, 5000);

            //List<double> doubleList = GenerateRandomDoubleList(100, 500);

            Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray());

        

        /*BubbleSort<int> bubbleSort = new BubbleSort<int>();
            bubbleSort.Sort(ref intList);
            for (int i = 0; i < intList.Count * 0.025; i++)
            {
                var rand = new Random();
                var rand1 = rand.Next(0, intList.Count);
                var rand2 = rand.Next(0, intList.Count);
                var temp = rand1;
                intList[rand1] = rand2;
                intList[rand2] = temp;
            }
            Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));

            double totalTime = 0;
            Console.WriteLine("BUBBLE SORT");
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);
                totalTime += TimeSort<int>(bubbleSort, intListCopy);
            }

            Console.WriteLine($" Average: {totalTime / 11}");*/

            /*InsertionSort<int> insertionSort = new InsertionSort<int>();
            insertionSort.Sort(ref intList);
            for (int i = 0; i < intList.Count * 0.025; i++)
            {
                var rand = new Random();
                var rand1 = rand.Next(0, intList.Count);
                var rand2 = rand.Next(0, intList.Count);
                var temp = rand1;
                intList[rand1] = rand2;
                intList[rand2] = temp;
            }
            double totalTime = 0;
            Console.WriteLine("INSERTION SORT");
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);
                totalTime += TimeSort<int>(insertionSort, intListCopy);
            }

            Console.WriteLine($"Average: {totalTime / 11}");*/

            /*QuickSort<int> quickSort = new QuickSort<int>();
            quickSort.Sort(ref intList);
            for (int i = 0; i < intList.Count * 0.025; i++)
            {
                var rand = new Random();
                var rand1 = rand.Next(0, intList.Count);
                var rand2 = rand.Next(0, intList.Count);
                var temp = rand1;
                intList[rand1] = rand2;
                intList[rand2] = temp;
            }
            double totalTime = 0;
            Console.WriteLine("QUICK SORT");
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);
                totalTime += TimeSort<int>(quickSort, intListCopy);
            }

            Console.WriteLine($"Average: {totalTime / 11}");*/


            /*HeapSort<int> heapSort = new HeapSort<int>();
            heapSort.Sort(ref intList);
            for (int i = 0; i < intList.Count * 0.025; i++)
            {
                var rand = new Random();
                var rand1 = rand.Next(0, intList.Count);
                var rand2 = rand.Next(0, intList.Count);
                var temp = rand1;
                intList[rand1] = rand2;
                intList[rand2] = temp;
            }
            double totalTime = 0;
            Console.WriteLine("HEAP SORT");
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);
                totalTime += TimeSort<int>(heapSort, intListCopy);
            }

            Console.WriteLine($"Average: {totalTime / 11}");*/

            /*RadixSort radixSort = new RadixSort();
            var sorted = radixSort.Sort(intList.ToArray());
            sorted.ToList();
            for (int i = 0; i < intList.Count * 0.025; i++)
            {
                var rand = new Random();
                var rand1 = rand.Next(0, intList.Count);
                var rand2 = rand.Next(0, intList.Count);
                var temp = rand1;
                sorted[rand1] = rand2;
                sorted[rand2] = temp;
            }
            double totalTime = 0;
            Console.WriteLine("RADIX SORT");
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(sorted);
                totalTime += TimeSort(radixSort, intListCopy);
            }

            Console.WriteLine($"Average: {totalTime / 11}");*/

            PigeonholeSort pigeonholeSort = new PigeonholeSort();
            var sorted = pigeonholeSort.Sort(intList.ToArray());
            sorted.ToList();
            Console.WriteLine("[{0}]", string.Join(", ", sorted.ToArray()));
            /*for (int i = 0; i < intList.Count * 0.025; i++)
            {
                var rand = new Random();
                var rand1 = rand.Next(0, intList.Count);
                var rand2 = rand.Next(0, intList.Count);
                var temp = rand1;
                sorted[rand1] = rand2;
                sorted[rand2] = temp;
            }
            double totalTime = 0;
            Console.WriteLine("PIGEONHOLE SORT");
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(sorted);
                totalTime += TimeSort(pigeonholeSort, intListCopy);
            }
            Console.WriteLine($"Average: {totalTime / 11}");*/


            //TreeSort<int> treeSort = new TreeSort<int>();
            //treeSort.Sort(ref intList);

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray()));

            /*Console.WriteLine("QUICKSORT");
            QuickSort<int> quickSort = new QuickSort<int>();
            for( int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(quickSort, intListCopy);
            }

            MergeSort<int> mergeSort = new MergeSort<int>();
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(mergeSort, intListCopy);
            }*/

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(mergeSort, intListCopy);

            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(insertionSort, intListCopy);

            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(bubbleSort, intListCopy);





        }

        public static double TimeSort<T>(ISortable<T> sortable, List<T> items) where T : IComparable<T>
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(ref items);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;
        }

        public static double TimeSort(ISortableInt sortable, List<int> items)
        {
            int[] array = items.ToArray();
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var sorted = sortable.Sort(array);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;
        }


        public static List<int> GenerateRandomIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for(int i=0; i < length; i++)
            {
                list.Add(random.Next(maxValue));               
            }

            return list;
        }

        public static List<double> GenerateRandomDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.NextDouble()* maxValue);
            }

            return list;
        }
    }
}
