//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
int index = 0;
for(index = 0; index < M; index++)
{
    Console.Write("Введите числo: "); 
    array[index] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] col)
{
    int index = 0;
    int count = col.Length;
    while (index < count)
    {
        Console.Write($"{col[index]}, ");
        index++;
    }
}
PrintArray(array);

int Result(int[] col)
{
int i = 0; 
int count = col.Length;
int result = 0;
while(i < count)
{
    if(col[i] > 0) result++;
    i++;
}
return result;
}
Console.WriteLine();
int count = Result(array);
Console.WriteLine($"Количество чисел больше 0 равняется {count}");
