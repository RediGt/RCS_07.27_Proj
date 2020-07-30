using System;

namespace RCS_07._27_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskMD();
        }

        static void TaskMD()
        {            
            Console.WriteLine("The program raises base to power.");
            Console.Write("Input integer base: ");
            int nBase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input integer power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            if (nBase == 0 && power == 0)
                Console.WriteLine("{0} ^ {1} = {2}\n", nBase, power, "Result is undefined");
            else
            {
                double result = RaiseToPower(Convert.ToDouble(nBase), power);
                Console.WriteLine("{0} ^ {1} = {2}\n", nBase, power, result);
            }          
        }

        static double RaiseToPower(double nBase, int power)
        {
            double result = 1;            
            if (power < 0)
            {
                nBase = 1 / nBase;
                power = -power;
            }
            
            for (int i = 0; i < power; i++)
            {
                result *= nBase;
            }

            return result;
        }

        static void Task5()
        {
            int[] intArr = new int[20];
            RandomizeArr(intArr);
            Console.WriteLine("Random Array:");
            PrintArray(intArr);
            Console.WriteLine("\nSorted Array:");
            SortToLargest(intArr);
            PrintArray(intArr);
            Console.WriteLine("");
        }

        static void RandomizeArr(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr[i] = rand.Next(0, 31);
            }
        }

        static void SortToLargest(int[] arr)
        {
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                int temp;
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item.ToString() + " ");
        }

        static void Task4()
        {            
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <=i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 4; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
     
        static void Task3()
        {          
            int input = 0;
            
            Console.Write("Input integer number 1: ");
            input = Convert.ToInt32(Console.ReadLine());
            int max = input;
            int min = input;

            for (int i = 2; i < 11; i++)
            {
                Console.Write("Input integer number {0}: ", i);             
                input = Convert.ToInt32(Console.ReadLine());

                if (input > max)
                    max = input;
                if (input < min)
                    min = input;
            }
            Console.WriteLine("Max number is {0}", max);
            Console.WriteLine("Min number is {0}", min);
        }

        static void Task2()
        {
            int result = 0;
            for (int i = 1; i < 7; i++)
            {
                Console.Write("Input integer number {0}: ", i);
                result += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Sum of 6 is {0}", result);
        }

        static void Task1()
        {
            int result = 0;
            for (int i = 1; i < 11; i++)
            {
                result += i;
            }

            Console.WriteLine("Sum from 1 to 10 is {0}", result);
        }      
    }
}
