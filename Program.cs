using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void NumberOne()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void NumberTwo()
        {
            for (int i = 1; i <= 255; i = i+2)
            {
                Console.WriteLine(i);
            }
        }
        public static void Sum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(sum+=i);
            }
        }
        public static void iterate(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
        public static void max(int[] x)
        {
            int max = x[0];
            for(int i = 1; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
            }
        }
        public static void average(int[] x)
        {
            int sum = x[0];
            for(int i = 1; i < x.Length; i++)
            {
                sum+=x[i];
            }
            int avg = sum/x.Length;
            Console.WriteLine(avg);
        }
        public static void odds(int[] x)
        {
            int odd = 1;
            for(int i = 0; i <x.Length; i++)
            {
                x[i] = odd;
                odd+=2;
            }
        }
        public static int GreaterThan(int[] x, int y)
        {
            int NumsGreater = 0;
            for(int i = 0; i <x.Length; i++)
            {
                if(x[i] > y)
                {
                    NumsGreater+=1;
                }
            }
            return NumsGreater;
        }
        public static void square(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * x[i];
            }
        }
        public static void negative(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] < 0)
                {
                    x[i] = 0;
                }
            }
        }
        public static void MinMaxAvg(int[] x)
        {
            int min = x[0];
            int max = x[0];
            int sum = x[0];
            for(int i = 1; i < x.Length; i++)
            {
                if(x[i] < min)
                {
                    min = x[i];
                }
                if(x[i] > max)
                {
                    max = x[i];
                }
                sum +=x[i];
            }
            int avg = sum/x.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
        }
        public static void ShiftVals(int[] x)
        {
            Array.Copy(x, 1, x, 0, x.Length - 1);
            x[x.Length - 1] = 0;
        }
        public static object NumString(int[] x)
        {
            object[] newarr = new object[x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] < 0)
                {
                    newarr[i] = "Dojo";
                }
                else
                {
                    newarr[i] = x[i];
                }
            }
            for(int j = 0; j < newarr.Length; j++)
            {
                Console.WriteLine(newarr[j]);
            }
            return newarr;
        }
        static void Main(string[] args)
        {
            NumberOne();
            NumberTwo();
            Sum();
            int[] iteration = new int[] {1,3,5,7,9,13};
            iterate(iteration);
            int[] maxed = new int[] {-3,-5,-7};
            max(maxed);
            int[] nums = new int[] {-3,-5,-7};
            average(nums);
            int[] oddnums = new int[128];
            odds(oddnums);
            int[] greater = new int[] {1,3,5,7};
            int NumsGreater = GreaterThan(greater, 4);
            int[] vals = new int[] {1,5,10,-2};
            square(vals);
            int[] nums2 = new int[] {1,5,10,-2};
            negative(nums2);
            int[] nums3 = new int[] {1,5,10,-2};
            MinMaxAvg(nums3);
            int[] Shift = new int[] {1,5,10,7,-2};
            ShiftVals(Shift);
            int[] nums5 = new int[] {1,5,10,-2};
            object NumberString = NumString(nums5);
        }
    }
}