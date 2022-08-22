using System;
class Programm
{
    static int Input()
    {
        Console.Write("Input s ");
        int s = Convert.ToInt32(Console.ReadLine());
        return s;
    }
    static int[] CreateArray(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 100);
        }
        return array;
    }
    static void WriteArray(int[] array)
    {
        foreach (int n in array)
        {
            Console.Write(n + "  ");
        }
    }
    static int[] Shuffle(int[] array)
    {
        for(int i = 1; i <array.Length; i++)
        {
            int j = new Random().Next(0, i + 1);
            int n = array[i];
            array[i] = array[j];
            array[j] = n;
        }
        return array;
    }
    static void Main(string[] args)
    {
        int s = Input();
        int[] array = CreateArray(s);
        array = Shuffle(array);
        WriteArray(array);
    }
}