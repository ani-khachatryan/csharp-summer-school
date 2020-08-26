namespace Sort
{
    public class QuickSort : Sort
    {
        public override void Name()
        {
            System.Console.WriteLine("QuickSort");
        }
        public override int[] Invoke(int[] array)
        {
            Quick_Sort(array, 0, array.Length - 1);
            return array;
        }
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(arr, left, right);
                if (p > 1)
                {
                    Quick_Sort(arr, left, p - 1);
                }
                if (p + 1 < right)
                {
                    Quick_Sort(arr, p + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int p = arr[left];
            while (true)
            {
                while (arr[left] < p)
                {
                    left++;
                }

                while (arr[right] > p)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right])
                        return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else return right;
            }
        }
    }
}