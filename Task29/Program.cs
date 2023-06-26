// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void PrintArray(int[] print)
    {
        int current = print.Length;
        int index = 0;
        while (index < current)
        {
            Console.Write(print[index] + " ");
            index++;
        }
    } 


int[] array = new int [8 ];
Console.WriteLine("Input unit 1 ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input unit 2 ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input unit 3 ");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input unit 4 ");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input unit 5 ");
array[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input unit 6 ");
array[5] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input unit 7 ");
array[6] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input unit 8 ");
array[7] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintArray(array);