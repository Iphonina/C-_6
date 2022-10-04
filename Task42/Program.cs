// // **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// // 2 -> 10

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int x = num;
// int count = 0;
// int num1 = 0;
// while (num > 0)
// {
//     num1 = num % 2;
//     num = num / 2;
//     count++;
//     Console.Write($"{num1}");
// }

// int[] arr = new int[count];
// int i = 1;
// while(x > 0)
// {
//     arr[count-i] =x%2;
//     x = x/2;
//     i++;
// }

// Console.WriteLine();
// void PrintArray(int[] col)
// {
//     int index = 0;
//     int count = col.Length;
//     while (index < count)
//     {
//         Console.Write($"{col[index]}");
//         index++;
//     }
// }

// PrintArray(arr);


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string y = string.Empty;

while (num > 0)
{
    y = Convert.ToString(num % 2) + y;
    num = num/2;
}
Console.WriteLine(y);
