using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sort
{
    class MainProgram
    {
        public delegate int[] StrToSorted(int[] a);
        public static void Main()
        {
            Console.WriteLine("=============================================== \n" +
                "Please enter the size of an array that you want to sort:");

            Int32.TryParse(Console.ReadLine(), out int n);
            if(n<=0)
            {
                Console.WriteLine("Invalid Input");
                System.Threading.Thread.Sleep(10000);
                return;
            }
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 1000000);
                //Console.Write(array[i]);
                //Console.Write(' ');
            }

            List<Sort> list = new List<Sort>
            {
                new InsertionSort(),
                new BubbleSort(),
                new QuickSort(),
                new MergeSort()
            };
            Console.Write("Select which algorithm you want to perform:\n" +
                "1. Insertion sort\n" +
                "2. Bubble sort\n" +
                "3. Quick sort\n" +
                "4. Merge sort\n" +
                "5. All\n");
            //Int32.TryParse(Console.ReadLine(), out int number);
            Parsed exp = Parser.Parse(Console.ReadLine());
            if(exp.Op == "-")
            {
                exp.Arg1--;exp.Arg2--;
                if(exp.Arg1 > exp.Arg2 || exp.Arg2 > 3)
                {
                    Console.WriteLine("Invalid Input");
                    System.Threading.Thread.Sleep(10000);
                    return;
                }
            }
            else if(exp.Op == "")
            {
                exp.Arg1--;
                if (exp.Arg1 == 4)
                {
                    exp.Arg1 = 0;
                    exp.Arg2 = 3;
                }
                else exp.Arg2 = exp.Arg1;
                if(exp.Arg2 > 3)
                {
                    Console.WriteLine("Invalid Input");
                    System.Threading.Thread.Sleep(10000);
                    return;
                }
            }
            else if(exp.Op == ",")
            {
                if (exp.Arg1 > 0 && exp.Arg1 <= 4 && exp.Arg2 > 0 && exp.Arg2 <= 4)
                {
                    int i = --exp.Arg1;
                    int j = 0;
                    while (j < 2)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        var mem = GC.GetTotalMemory(false);
                        list[i].Invoke(array);
                        watch.Stop();
                        var elapsedms = watch.ElapsedMilliseconds;

                        list[i].Name();
                        list[i].Print(list[i].Invoke(array));

                        if (i == 2)
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("running time: ");
                        Console.WriteLine($"{elapsedms}ms");
                        Console.WriteLine($"memory used: {mem}");
                        Console.ResetColor();
                        Console.WriteLine();
                        i = --exp.Arg2;
                        j++;
                    }
                    System.Threading.Thread.Sleep(10000);
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    System.Threading.Thread.Sleep(10000);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
                System.Threading.Thread.Sleep(10000);
                return;
            }
            //list[exp.Arg1].Invoke(array);
            //Console.ReadLine();
            //number--;
            //int n1 = number;
            //if (n1 == 4)
            //{
            //    number = 0;
            //    n1--;
            //}
            for (int i = exp.Arg1; i <= exp.Arg2; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var mem = GC.GetTotalMemory(false);
                list[i].Invoke(array);
                watch.Stop();
                var elapsedms = watch.ElapsedMilliseconds;

                list[i].Name();
                list[i].Print(list[i].Invoke(array));

                if (i == 2)
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("running time: ");
                Console.WriteLine($"{elapsedms}ms");
                Console.WriteLine($"memory used: {mem}");
                Console.ResetColor();
                Console.WriteLine();
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}