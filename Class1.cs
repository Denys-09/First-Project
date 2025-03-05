using System;

class Stairs
{
    static void PrintStairs(int times, int length, char symbol)
    {
        for (int i = 0; i < times; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        PrintStairs(5, 4, '*');
    }
}
