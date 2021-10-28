class Program
{
    public static void BucketSort(float[] arr, int n)
    {
        if (n <= 0)
            return;

        List<float>[] Buckets = new List<float>[n];

        for (int i = 0; i < n; i++)
        {
            Buckets[i] = new List<float>();
        }

        for (int i = 0; i < n; i++)
        {
            float idx = arr[i] * n;
            Buckets[(int)idx].Add(arr[i]);
        }

        for (int i = 0; i < n; i++)
        {
            Buckets[i].Sort();
        }

        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < Buckets[i].Count; j++)
            {
                arr[index++] = Buckets[i][j];
            }
        }
    }
    static void Main(string []args)
    {
        float[] arr = { (float)0.211,
                        (float)0.365,
                        (float)0.426,
                        (float)0.2502,
                        (float)0.11,
                        (float)0.2022,
                        (float)0.2021 };

        int n = arr.Length;
        BucketSort(arr, n);

        Console.WriteLine("Отсортированный массив:");
        foreach (float el in arr)
        {
            Console.Write(el + " ");
        }
        Console.ReadLine();
    }
}