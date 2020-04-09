using System;

namespace Homework8_ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int 
            int[] array1 = { 11, 22, 33, 44, 55, 66 };
            foreach (int i in array1) Console.WriteLine(i);
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
    }

}
