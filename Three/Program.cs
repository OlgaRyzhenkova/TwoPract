using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок анлгійською мовою:");
        string text = Console.ReadLine();
        int[] counts = CountLetters(text);
        PrintCounts(counts);

    }
    static int[] CountLetters(string text)
    {
        int[] count = new int[26];
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char letter = char.ToLower(c);
                int index = letter - 'a';
                if (index >= 0 && index < 26)
                {
                    count[index]++;
                }
            }
        }
        return count;
    }
    static void PrintCounts(int[] counts)
    {
        Console.WriteLine("Кількість кожної букви:");
        for (int i = 0; i < 26; i++)
        {
            if (counts[i] > 0)
            {
                char letter = (char)('a' + i);
                Console.WriteLine($"{letter} : {counts[i]}");
            }
        }
    }
    
}