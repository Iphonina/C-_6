﻿// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int i = 2;
array[0] = 0;
array[1] = 1;
Console.Write("0 1 ");
while (i < n)
{
    array[i] = array[i - 1] + array[i - 2];
    Console.Write($"{array[i]} ");
    i++;
}
