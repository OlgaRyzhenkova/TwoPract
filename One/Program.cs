using System;
using System.Data;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine($"Масив:");
            int[,] arr = RandomInput();
            ShowArr(arr);
            Console.WriteLine($"Кількість чисел в діапазоні:{CountNum(arr)}");
            Console.WriteLine($"Числа кратні 5:{Kratni(arr)}");
        }
    }
    static int[,] RandomInput()
    {
        Random rand = new Random();
        int[,] arr = new int[10,10];
        for ( int i = 0; i < 10; i++)
        {
            for ( int j = 0; j < 10; j++)
            {
                arr[i, j] = rand.Next(10, 100);
            }
        }
        return arr;
    }
    static void ShowArr( int[,] arr)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write( arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static int CountNum( int[,] arr )
    {
        Console.WriteLine("Введіть нижню межу:");
        int min = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Введіть верхню межу:");
        int max = Convert.ToInt32( Console.ReadLine() );
        int count = 0;
        for (int i = 0; i < 10; i ++)
        {
            for(int j = 0; j < 10; j++)
            {
                if( arr[i, j] >= min && arr[i, j] <= max)
                {
                    count++;
                }
            }
        }
        return count;
    }
    static int Kratni(int[,] arr)
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (arr[i, j] % 5 == 0)
                {
                    count++;
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
        return count;
    }
}