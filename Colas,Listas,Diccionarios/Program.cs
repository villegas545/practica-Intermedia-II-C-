using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Colas_Listas_Diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            //Instanciar stopWatch
            Stopwatch stopwatch = new Stopwatch();
            //Fill Data   
            var array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = i+1;
            }
            //Call ReverseWithDictionary
                stopwatch.Start();
            var arr1=ReverseWithDictionary(array);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed ReverseWithDictionary: {0}",
            stopwatch.Elapsed);
            stopwatch.Reset();
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            //Call ReverseWithList
            stopwatch.Start();
            var arr2=ReverseWithList(array);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed ReverseWithList: {0}",
            stopwatch.Elapsed);
            stopwatch.Reset();
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            //Call ReverseWithQueue
            stopwatch.Start();
            var arr3=ReverseWithQueue(array);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed ReverseWithQueue: {0}",
            stopwatch.Elapsed);
            stopwatch.Reset();
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] ReverseWithQueue(int[] arr)
        {
            var queue = new Queue<int>();
            foreach (var item in arr)
            {
                queue.Enqueue(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = queue.Dequeue();
            }
          return arr;
        }
        public static int[] ReverseWithList(int[] arr)
        {
            var list = new List<int>();
            foreach (var item in arr)
            {
                list.Add(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[list.Count - 1 - i];
            }
         return arr;
        }
        public static int[] ReverseWithDictionary(int[] arr)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                dictionary.Add(i, arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = dictionary[arr.Length - 1 - i];
            }
            return arr;
        }
    }
}
