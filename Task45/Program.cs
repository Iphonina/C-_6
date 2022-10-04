// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью 
//поэлементного копирования.

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);

int[] copy = new int[array.Length];
int i = 0;
while(i < array.Length)
{
    copy[i] = array[i];
    i++;
}
Console.WriteLine();
PrintArray(copy);