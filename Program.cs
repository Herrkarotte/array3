using System;
namespace array3
{
    class Program
    {
        public static int[] InitRand(int[] Arr)
        {

            Random rnd = new Random();
            Console.Write("\nEnter array size ");
            int N = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref Arr, N);
            for (int i = 0; i != Arr.Length; i++)
            {
                Arr[i] = rnd.Next(0, 100);
            }
            return Arr;
        }
        public static void PrintA(int[] Arr)
        {
            Console.WriteLine("\nResult: ");
            for (int i = 0; i != Arr.Length; i++)
            {
                Console.Write(Arr[i].ToString() + " ");
            }
        }
        public static int[] SumArr(int[] Arr1, int[] Arr2)
        {
            int[] Arr3 = new int[Arr1.Length];
            if (Arr1.Length == Arr2.Length)
            {
                for (int i = 0; i != Arr1.Length; i++)
                {
                    Arr3[i] = Arr1[i] + Arr2[i];
                }
            }
            else
            {
                Console.WriteLine("\nArray sizes do not match ");
            }
            return Arr3;
        }
        public static int[] MultiArr(int[] Arr, int M)
        {
            int[] Arr3 = new int[Arr.Length];
            for (int i = 0; i != Arr.Length; i++)
            {
                Arr3[i] = Arr[i] * M;
            }
            return Arr3;
        }
        public static void Sort(int[] Arr)
        {
            int tmp;
            for (int i = 0; i != Arr.Length; i++)
            {
                for (int j = i + 1; j != Arr.Length; j++)
                    if (Arr[i] < Arr[j])
                    {
                        tmp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = tmp;
                    }
            }
        }
        public static string MV(int[] Arr1, int[] Arr2)
        {
            string res = " ";
            for (int i = 0; i < Arr1.Length; i++)
            {
                for (int j = 0; j < Arr2.Length; j++)
                {
                    if (Arr1[i] == Arr2[j])
                    {
                        res += Arr1[i] + " ";
                    }
                }
            }
            return res;
        }
        public static int MinA(int[] Arr)
        {
            int min = 999;
            for (int i = 0; i != Arr.Length; i++)
            {
                if (Arr[i] < min)
                    min = Arr[i];
            }
            return min;
        }
        public static int MaxA(int[] Arr)
        {
            int max = -999;
            for (int i = 0; i != Arr.Length; i++)
            {
                if (Arr[i] > max)
                    max = Arr[i];
            }
            return max;
        }
        public static double AvgA(int[] Arr)
        {
            double Sum = 0;
            for (int i = 0; i != Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            Sum = Sum / Arr.Length;
            return Sum;
        }
        static void Main()
        {
            int[] A1 = new int[2];
            int[] A2 = new int[2];
            int cod = 0;
            while (true)
            {
                Console.WriteLine("\nSelect operation:");
                Console.WriteLine("1- Initialize array");
                Console.WriteLine("2- Sum of arrays");
                Console.WriteLine("3- Multiplay array by number");
                Console.WriteLine("4- Searching fot matching values in arrays");
                Console.WriteLine("5- Array sorting");
                Console.WriteLine("6- Search for min");
                Console.WriteLine("7- Search for max");
                Console.WriteLine("8- Search for avg");
                Console.WriteLine("9- Print");
                Console.WriteLine("0- Exit");
                cod = Convert.ToInt32(Console.ReadLine());
                switch (cod)
                {

                    case 1:
                        {
                            Console.WriteLine("Select array to initialize: ");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            if (ch == 1)
                                A1 = InitRand(A1);
                            if (ch == 2)
                                A2 = InitRand(A2);
                            break;
                        }
                    case 2:
                        {
                            int[] Total = SumArr(A1, A2);
                            PrintA(Total);
                            break;
                        }
                    case 3:
                        {
                            int[] Total = null;
                            Console.WriteLine("Select array to multiplay");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the multiplication factor");
                            int mf = Convert.ToInt32(Console.ReadLine());

                            if (ch == 1)
                                Total = MultiArr(A1, mf);
                            if (ch == 2)
                                A2 = MultiArr(A2, mf);
                            PrintA(Total);
                            break;
                        }
                    case 4:
                        {
                            string Total = MV(A1, A2);
                            Console.WriteLine($"Matches found: {Total}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Select array to Sort: ");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            if (ch == 1)
                            {
                                PrintA(A1);
                                Sort(A1);
                                PrintA(A1);
                            }
                            if (ch == 2)
                            {
                                PrintA(A2);
                                Sort(A2);
                                PrintA(A2);
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Select an array to find min: ");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            if (ch == 1)
                            {
                                PrintA(A1);
                                Console.Write("\nmin=" + MinA(A1));
                            }
                            if (ch == 2)
                            {
                                PrintA(A2);
                                Console.Write("\nmin=" + MinA(A2));
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Select an array to find max: ");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            if (ch == 1)
                            {
                                PrintA(A1);
                                Console.Write("\nmax=" + MaxA(A1));
                            }
                            if (ch == 2)
                            {
                                PrintA(A2);
                                Console.Write("\nmax=" + MaxA(A2));
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Select an array to find avg: ");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            if (ch == 1)
                            {
                                PrintA(A1);
                                Console.Write("\navg=" + AvgA(A1));
                            }
                            if (ch == 2)
                            {
                                PrintA(A2);
                                Console.Write("\navg=" + AvgA(A2));
                            }
                            break;
                        }
                    case 9:
                        {
                            PrintA(A1);
                            PrintA(A2);
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("invalid command input!");
                            break;
                        }
                }
            }
        }
    }
}
