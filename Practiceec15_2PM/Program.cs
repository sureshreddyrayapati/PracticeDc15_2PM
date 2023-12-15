using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practieec15_2pm
{
    internal class Program
    {
        static void evenNum(int s, int e)
        {
            for (int i = s; i <= e; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void oddNum(int s, int e)
        {
            for (int i = s; i <= e; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void fibNum(int s, int e)
        {
            int a = 0, b = 1;
            for (int i = s; i <= e; i++)
            {
                Console.WriteLine(a);
                int c = a + b;
                a = b;
                b = c;
                if (a >= 50)
                {
                    break;
                }
            }

        }
        static void fibNumWhile(int s, int e)
        {
            int a = 0, b = 1;
            while (a < e)
            {
                if (a >= s)
                {
                    Console.WriteLine(a);
                }
                int c = a + b;
                a = b;
                b = c;
            }
        }
        static void alterAplh()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void arryMin()
        {
            Console.WriteLine("Enter Array Size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the Array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int M1 = int.MaxValue;
            int M2 = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < M1)
                {
                    M1 = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > M2)
                {
                    M2 = arr[i];
                }
            }
            Console.WriteLine("Minimum Number in Array is: " + M1);
            Console.WriteLine("Maximum Number in Array is: " + M2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Print even number from 0-50\n2 for print Odd number from 0-50\n3 for print fibonacci number from 0-50\n4 for print alternative alphabets from a-z" +
            "\n5 for get min and max number from an Array");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    {
                        evenNum(0, 50);
                        break;
                    }
                case 2:
                    {
                        oddNum(0, 50);
                        break;
                    }
                case 3:
                    {
                        fibNumWhile(0, 50);
                        break;
                    }
                case 4:
                    {
                        alterAplh();
                        break;
                    }
                case 5:
                    {
                        arryMin();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Please Choose Valid input");
                        Main(args);
                        break;
                    }
            }
        }
    }
}
