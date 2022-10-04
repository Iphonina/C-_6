// *Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if((a + b) > c && (a + c) > b && (b + c) > a)
{
    Console.WriteLine("Треугольник со сторонами такой длины существует");
}
else Console.WriteLine("Такого треугольника не существует!");
