namespace Sort
{
    public class Sort
    {
        public virtual int[] Invoke(int[] array)
        {
            return array;
        }
        public virtual void Name()
        {
            System.Console.WriteLine("Sort");
        }
        public void Print(int[] array)
        {
            foreach (var item in array)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();
        }
    }
}
