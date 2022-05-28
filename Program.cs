using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
        int sum = 0;
        int product = 1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[1, i];
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            product *= array[i, 0];
        }

        Console.WriteLine("Произведение первого столбца равно - " + product);
        Console.WriteLine("Сумма второй строки равна - " + sum);
    }
}
