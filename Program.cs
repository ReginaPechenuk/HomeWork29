// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] getArrayRandom (int length)
{
    int [] arr = new int[length];
    for(int i=0;i<length;i++)
    {
        arr[i] = new Random().Next(0,99);
    }
    return arr;
}
void PrintArray (int [] array)
{
    Console.Write($"[");
    int count = array.Length;
    for(int i=0; i<count;i++)
    {
        if (i != count -1)
        {
        Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
    Console.WriteLine();
}
int [] array = getArrayRandom(8);
PrintArray(array);

