using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Масив:");
        int[] arr = RandomInput(); 
        ShowArr(arr); 
        Console.WriteLine("\nВідсортований масив:");
        int[] sorted = SortArr(arr); 
        ShowArr(sorted); 
        TwoMin(sorted);
    }
    static int[] RandomInput()
    {
        Random rand = new Random();
        int[] arr = new int[100];
        for(int i = 0; i < 100; i ++)
        {
            arr[i] = rand.Next(100, 901);
        }
        return arr;
    }
    static void ShowArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
           Console.Write(arr[i] + " ");
        }
    }
    static int[] SortArr(int[] arr)
    {
        int[] newArr = (int[])arr.Clone(); 
        Array.Sort(newArr);  
        return newArr;
    }
    static void TwoMin(int[] newArr)
    {
        Console.WriteLine($"\nНайменше друге число: {newArr[1]}");
    }
}