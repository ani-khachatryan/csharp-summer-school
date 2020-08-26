namespace Sort
{
    public class BubbleSort : Sort
    {
        public override void Name()
        {
            System.Console.WriteLine("BubbleSort");
        }
        public override int[] Invoke(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
    }
}
