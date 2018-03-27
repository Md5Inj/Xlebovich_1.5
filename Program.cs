using System;

namespace lab1._5
{
    class Program
    {
        static void SetRandom(double[] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-10, 10) * 0.1;
            }
        }
        static void SetRandom(int[] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-10, 10);
            }
        }
        static void Print<T>(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        static double Task1(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 && arr[i] < 0)
                    sum += arr[i];
            }
            return sum;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        static void Task2(int[] arr, int K)
        {
            for (int i = 0; i < K; ++i)
            {
              int aLast = arr[0];
              for (int j = 0; j < arr.Length-1; j++)
                  arr[j] = arr[j+1];
              arr[arr.Length - 1] = aLast;
            }
        }

        static void Print<T>(T[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        static void SetRandom(int[,] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(-10, 10);
                }
            }
        }

        static void Task3(int[,] a)
        {
            int len = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                len = a.GetLength(1)-1;
                if (len % 2 != 0)
                    len -= 1;
                
                a[i, len] -= 1;

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == 0) 
                    {
                        a[i, j] -=  1;
                        break;
                    }
                }
            }
        }

        public static int Task4(int a, int b) {
        
        if (a > b + 1) {
            return 0;
        }
        
        if (a == 0 || b == 0) {
            return 1;
        }

        return Task4(a, b - 1) + Task4(a - 1, b - 1);
    }
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            SetRandom(arr);
            Print(arr);
            Console.WriteLine("Sum is: " + Task1(arr));

            int[] array = new int[10];
            int K = 0;
            SetRandom(array);
            Print(array);
            Console.Write("Input k: "); K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-" + K);
            Task2(array, K);
            Print(array);

            int[,] dvArr = new int[5, 5];
            SetRandom(dvArr);
            Print(dvArr);
            Console.WriteLine("Task3: ");
            Task3(dvArr);
            Print(dvArr);

            Console.WriteLine("Task4: " + Task4(5, 8));

            Console.ReadKey();
        }
    }
}
