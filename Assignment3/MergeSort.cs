namespace Sort
{
    public class MergeSort : Sort
    {
        public override void Name()
        {
            System.Console.WriteLine("MergeSort");
        }
        public override int[] Invoke(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            if (array.Length <= 1)
                return array;

            int mid = array.Length / 2;
            left = new int[mid];

            if (array.Length % 2 == 0)
                right = new int[mid];
            else
                right = new int[mid + 1];

            for (int i = 0; i < mid; i++)
                left[i] = array[i];

            int x = 0;

            for (int i = mid; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            left = Invoke(left);
            right = Invoke(right);
            result = merge(left, right);
            return result;
        }

        public int[] merge(int[] left, int[] right)
        {
            int Length = right.Length + left.Length;
            int[] result = new int[Length];
 
            int indexLeft = 0, indexRight = 0, indexResult = 0;
        
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}