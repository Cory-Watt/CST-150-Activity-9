using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_9
{
    internal class Activity9MethodStubs
    {
        private int q1Int1;
        private int q1Int2;
        private double q2Dbl1;
        private double q2Dbl2;
        private double q2Dbl3;
        private double q2Dbl4;
        private double q2Dbl5;
        private int q3RandInt1;
        private int q3RandInt2;
        private int q4Int1;
        private int q4Int2;
        private int q4Int3;
        private string q5Str1;
        private string q5Str2;
        private double[] q6Arr;
        private int[] q7Arr;
        private bool q8Bool1;
        private bool q8Bool2;
        private int q9Num1;
        private double q9Num2;
        private int[,] q10Arr;

        public Activity9MethodStubs()
        {
            this.q1Int1 = q1Int1;
            this.q1Int2 = q1Int2;
            this.q2Dbl1 = q2Dbl1;
            this.q2Dbl2 = q2Dbl2;
            this.q2Dbl3 = q2Dbl3;
            this.q2Dbl4 = q2Dbl4;
            this.q2Dbl5 = q2Dbl5;
            this.q3RandInt1 = q3RandInt1;
            this.q3RandInt2 = q3RandInt2;
            this.q4Int1 = q4Int1;
            this.q4Int2 = q4Int2;
            this.q4Int3 = q4Int3;
            this.q5Str1 = q5Str1;
            this.q5Str2 = q5Str2;
            this.q6Arr = q6Arr;
            this.q7Arr = q7Arr;
            this.q8Bool1 = q8Bool1;
            this.q8Bool2 = q8Bool2;
            this.q9Num1 = q9Num1;
            this.q9Num2 = q9Num2;
            this.q10Arr = q10Arr;
        }

        //Write a method that takes two integers and displays their sum.
        public static int Q1(int q1Int1, int q1Int2)
        {
            return q1Int2 + q1Int2;
        }

        //Write a method that takes five doubles and returns their average.
        public static double Q2(double q2Dbl1, double q2Dbl2, double q2Dbl3, double q2Dbl4, double q2Dbl5)
        {
            return ((q2Dbl1 + q2Dbl2 + q2Dbl3 + q2Dbl4 + q2Dbl5) / 5);
        }

        //Write a method that returns the sum of two randomly generated integers.
        public static int Q3(int q3RandInt1, int q3RandInt2)
        {
            Random rand = new Random();
            q3RandInt1 = rand.Next(100);
            q3RandInt2 = rand.Next(100);
            return q3RandInt1 + q3RandInt2;
        }

        //Write a method that takes three integers and returns true if their sum is divisible by 3, false otherwise.
        public static bool Q4(int q4Int1, int q4Int2, int q4Int3)
        {
            if ((q4Int1 + q4Int2 + q4Int3) % 3 == 0)
            {
                return true;
            }
            return false;
        }

        //Write a method that takes two strings and displays the string that has fewer characters.
        public static string Q5(string q5Str1, string q5Str2)
        {
            if (q5Str1.Length < q5Str2.Length)
            {
                return q5Str2;
            }
            else
            {
                return q5Str1;
            }
        }

        //Write a method that takes an array of doubles and returns the largest value in the array.
        public static double Q6(double[] q6Arr)
        {
            double largest = q6Arr[0];
            for (int i = 0; i < q6Arr.Length; i++)
            {
                if (q6Arr[i] > largest)
                {
                    largest = q6Arr[i];
                }
            }
            return largest;
        }

        //Write a method that generates and returns an array of fifty integer values.
        public static int[] Q7(int[] q7Arr)
        {
            for (int i = 0; i < 50; i++)
            {
                int[] q8Arr = new int[50];
            }
            return q7Arr;
        }

        //Write a method that takes two bool variables and returns true if they have the same value, false otherwise.
        public static bool Q8(bool q8Bool1, bool q8Bool2)
        {
            if (q8Bool1.Equals(q8Bool2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method that takes an int and a double and returns their product.
        public static double Q9(int q9Num1, double q9Num2)
        {
            return q9Num1 + q9Num2;
        }

        //Write a method that takes a two-dimensional array of integers and returns the average of the entries.
        public int Q10(int[,] q10Arr)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < q10Arr.GetLength(0); i++)
            {
                for(int x = 0; x < q10Arr.GetLength(1); x++)
                {
                    sum += q10Arr[i, x];
                    count++;
                }
            }
            return sum / count;
        }
    }
}
