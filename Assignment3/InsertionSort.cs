namespace Sort
{
    public class InsertionSort : Sort
    {
        public override void Name()
        {
            System.Console.WriteLine("InsertionSort");
        }
        public override int[] Invoke(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0 && array[j - 1] > array[j])
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
            return array;
        }
    }
}
