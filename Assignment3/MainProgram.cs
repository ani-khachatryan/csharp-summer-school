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
            Int32.TryParse(Console.ReadLine(), out int number);
            //Parsed exp = Parser.Parse(expression);
            //Console.Write($"{exp.Op}");
            //list[exp.Arg1].Invoke(array);
            //Console.ReadLine();
            number--;
            int n1 = number;
            if (n1 == 4)
            {
                number = 0;
                n1--;
            }
            for (int i = number; i <= n1; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var mem = GC.GetTotalMemory(false);
                list[number].Invoke(array);
                
                watch.Stop();
                list[i].Name();
                if (i == 2)
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Running time: ");
                var elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine($"{elapsedMs}ms");
                Console.WriteLine($"Memory used: {mem}");
                Console.ResetColor();
            }
            System.Threading.Thread.Sleep(3000);
        }
    }
}