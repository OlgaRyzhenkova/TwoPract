using System;
class Program
{
    static void Main()
    {
        int[] arr = CreateArray();
        RandArray(arr);
        PrintArray(arr);
        int startIndex = FindMaxSum(arr, out int maxSum);
        PrintResult(startIndex, maxSum);
    }
    static int[] CreateArray()
    {
        return new int[20];
    }
    static void RandArray(int[] arr)
    {
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(10, 100);
        }

    }
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Масив:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static int FindMaxSum(int[] arr, out int maxSum)
    {
        maxSum = -1;
        int bestIndex = 0;
        for (int i = 0; i < arr.Length - 2; ++i)
        {
            int sum = arr[i] + arr[i + 1] + arr[i + 2];
            if (sum > maxSum)
            {
                maxSum = sum;
                bestIndex = i;
            }
        }
        return bestIndex;
    }
    static void PrintResult(int startIndex, int maxSum)
    {
        Console.WriteLine("Підмасив з найбільшою сумою:");
        Console.WriteLine($"Індекси: {startIndex}, {startIndex + 1}, {startIndex + 2}");
        Console.WriteLine($"Сума = {maxSum}");
    }
}