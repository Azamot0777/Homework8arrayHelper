using System;

namespace Homework8_ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int 
            // int[] array1 = { 11, 22, 33, 44, 55, 66 };
            // foreach (int i in array1) Console.Write($"{i}\t");
            // System.Console.WriteLine($"\nDeleted last element: {ArrayHelper.Pop(ref array1)}");
            // System.Console.Write("New massive after Pop:");
            // foreach (int i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd an element:");
            // int peremen1 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine($"\nNew  massives size: {ArrayHelper.Push(ref array1, peremen1)}");
            // System.Console.Write("Massive after push:");
            // foreach (int i in array1) Console.Write($"{i}\t");

            // System.Console.WriteLine($"\nDeleted first element:{ArrayHelper.Shift(ref array1)}");
            // System.Console.Write("Massive after shift:");
            // foreach (int i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd a first element:");
            // int peremen2 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine($"\nNew massive size:{ArrayHelper.UnShift(ref array1, peremen2)}");
            // System.Console.WriteLine("Massive after UnShift:");

            // string
            // string[] array1 = { "Дерево", "Cнег", "Яблоко", "Машина" };
            // foreach (string i in array1) Console.Write($"{i}\t");
            // System.Console.WriteLine($"\nDeleted last element: {ArrayHelper.Pop(ref array1)}");
            // System.Console.Write("New massive after Pop:");
            // foreach (string i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd an element:");
            // string peremen1 = Console.ReadLine();
            // System.Console.WriteLine($"\nNew  massives size: {ArrayHelper.Push(ref array1, peremen1)}");
            // System.Console.Write("Massive after push:");
            // foreach (string i in array1) Console.Write($"{i}\t");

            // System.Console.WriteLine($"\nDeleted first element:{ArrayHelper.Shift(ref array1)}");
            // System.Console.Write("Massive after shift:");
            // foreach (string i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd a first element:");
            // string peremen2 = Console.ReadLine();
            // System.Console.WriteLine($"\nNew massive size:{ArrayHelper.UnShift(ref array1, peremen2)}");
            // System.Console.WriteLine("Massive after UnShift:");

            //double
            // double[] array1 = { 2.3, 1.6, 9.9, 0.6 };
            // foreach (double i in array1) Console.Write($"{i}\t");
            // System.Console.WriteLine($"\nDeleted last element: {ArrayHelper.Pop(ref array1)}");
            // System.Console.Write("New massive after Pop:");
            // foreach (double i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd an element:");
            // double peremen1 = double.Parse(Console.ReadLine());
            // System.Console.WriteLine($"\nNew  massives size: {ArrayHelper.Push(ref array1, peremen1)}");
            // System.Console.Write("Massive after push:");
            // foreach (double i in array1) Console.Write($"{i}\t");

            // System.Console.WriteLine($"\nDeleted first element:{ArrayHelper.Shift(ref array1)}");
            // System.Console.Write("Massive after shift:");
            // foreach (double i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd a first element:");
            // double peremen2 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine($"\nNew massive size:{ArrayHelper.UnShift(ref array1, peremen2)}");
            // System.Console.WriteLine("Massive after UnShift:");

            //float
            // float[] array1 = { 22.3f, 11.6f, 9.39f, 0.56f };
            // foreach (float i in array1) Console.Write($"{i}\t");
            // System.Console.WriteLine($"\nDeleted last element: {ArrayHelper.Pop(ref array1)}");
            // System.Console.Write("New massive after Pop:");
            // foreach (float i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd an element:");
            // float peremen1 = float.Parse(Console.ReadLine());
            // System.Console.WriteLine($"\nNew  massives size: {ArrayHelper.Push(ref array1, peremen1)}");
            // System.Console.Write("Massive after push:");
            // foreach (float i in array1) Console.Write($"{i}\t");

            // System.Console.WriteLine($"\nDeleted first element:{ArrayHelper.Shift(ref array1)}");
            // System.Console.Write("Massive after shift:");
            // foreach (float i in array1) Console.Write($"{i}\t");

            // System.Console.Write("\nAdd a first element:");
            // float peremen2 = float.Parse(Console.ReadLine());
            // System.Console.WriteLine($"\nNew massive size:{ArrayHelper.UnShift(ref array1, peremen2)}");
            // System.Console.WriteLine("Massive after UnShift:");

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
        public static int Shift(ref int[] array)
        {
            int n = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static string Shift(ref string[] array)
        {
            string n = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static double Shift(ref double[] array)
        {
            double n = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static decimal Shift(ref decimal[] array)
        {
            decimal n = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static float Shift(ref float[] array)
        {
            float n = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            return n;
        }
        public static int UnShift(ref int[] array, int peremen)
        {
            int a, b, c = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Array.Resize(ref array, array.Length + 1);
                    a = array[i];
                    array[i] = peremen;
                    for (int j = i + 1; j < array.Length - 1; j = j + 2)
                    {
                        b = array[j];
                        array[j] = a;
                        a = array[j + 1];
                        array[j + 1] = b;
                    }
                    array[array.Length - 1] = c;
                }
            }
            return array.Length;
        }
        public static string UnShift(ref string[] array, string peremen)
        {
            string a, b, c = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Array.Resize(ref array, array.Length + 1);
                    a = array[i];
                    array[i] = peremen;
                    for (int j = i + 1; j < array.Length - 1; j = j + 2)
                    {
                        b = array[j];
                        array[j] = a;
                        a = array[j + 1];
                        array[j + 1] = b;
                    }
                    array[array.Length - 1] = c;
                }
            }
            return Convert.ToString(array.Length);
        }
        public static double UnShift(ref double[] array, double peremen)
        {
            double a, b, c = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Array.Resize(ref array, array.Length + 1);
                    a = array[i];
                    array[i] = peremen;
                    for (int j = i + 1; j < array.Length - 1; j = j + 2)
                    {
                        b = array[j];
                        array[j] = a;
                        a = array[j + 1];
                        array[j + 1] = b;
                    }
                    array[array.Length - 1] = c;
                }
            }
            return array.Length;
        }
        public static decimal UnShift(ref decimal[] array, decimal peremen)
        {
            decimal a, b, c = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Array.Resize(ref array, array.Length + 1);
                    a = array[i];
                    array[i] = peremen;
                    for (int j = i + 1; j < array.Length - 1; j = j + 2)
                    {
                        b = array[j];
                        array[j] = a;
                        a = array[j + 1];
                        array[j + 1] = b;
                    }
                    array[array.Length - 1] = c;
                }
            }
            return array.Length;
        }
        public static float UnShift(ref float[] array, float peremen)
        {
            float a, b, c = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Array.Resize(ref array, array.Length + 1);
                    a = array[i];
                    array[i] = peremen;
                    for (int j = i + 1; j < array.Length - 1; j = j + 2)
                    {
                        b = array[j];
                        array[j] = a;
                        a = array[j + 1];
                        array[j + 1] = b;
                    }
                    array[array.Length - 1] = c;
                }
            }
            return array.Length;
        }


    }

}
