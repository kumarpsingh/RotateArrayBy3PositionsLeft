namespace RotateArrayBy3PositionsLeft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 10, 11, 12, 15 };
            int positions = 3;
            int n = arr.Length;
            positions = positions % n;
            Console.WriteLine("Actual array is is " + string.Join(",", arr));
            if (positions > 0)
            {
                int[] temp = new int[positions];

                for (int i = 0; i < positions; i++)
                {
                    temp[i] = arr[i];
                }
                Console.WriteLine(string.Join(",", temp));
                for (int i = positions; i < n; i++)
                {
                    arr[i - positions] = arr[i];
                }
                for (int i = 0; i < positions; i++)
                {
                    arr[n - positions + i] = temp[i];
                }


                Console.WriteLine("Roted arrray by 3 (Left) is " + string.Join(",", arr));

                Console.Read();
                //Nothing 2

            }

        }
    }
}
