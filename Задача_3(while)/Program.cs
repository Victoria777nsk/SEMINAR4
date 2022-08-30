// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = 1;

while (i <= number)
{
    result = result * i;
    i++;
}

Console.Write($"Произведение цифр от 1 до {number} = {result}");
