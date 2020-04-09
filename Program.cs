using System;

namespace Homework8_ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int 
            int[] array1 = { 11, 22, 33, 44, 55, 66 };
            foreach (int i in array1) Console.Write($"{i}\t");
            System.Console.WriteLine($"\nDeleted : {ArrayHelper.Pop(ref array1)}");
            System.Console.Write("New massive after Pop:");
            foreach (int i in array1) Console.Write($"{i}\t");

            System.Console.Write("\nAdd an element:");
            int peremen1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"\nNew  massives size: {ArrayHelper.Push(ref array1, peremen1)}");
            System.Console.Write("Massive after push:");
            foreach (int i in array1) Console.Write($"{i}\t");






        }

    }


    static class ArrayHelper
    {
        public static int Pop(ref int[] array)
        {
            int n = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static string Pop(ref string[] array)
        {
            string n = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static double Pop(ref double[] array)
        {
            double n = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static decimal Pop(ref decimal[] array)
        {
            decimal n = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static float Pop(ref float[] array)
        {
            float n = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static int Push(ref int[] array, int peremen)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = peremen;
            return array.Length;
        }
        public static string Push(ref string[] array, string peremen)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = peremen;
            return Convert.ToString(array.Length);
        }
        public static double Push(ref double[] array, double peremen)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = peremen;
            return array.Length;
        }
        public static decimal Push(ref decimal[] array, decimal peremen)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = peremen;
            return array.Length;
        }
        public static float Push(ref float[] array, float peremen)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = peremen;
            return array.Length;
        }

    }

}
