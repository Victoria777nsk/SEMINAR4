// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    int numberMultiply(int number)
    {
        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
    Console.WriteLine($"Произведение цифр от 1 до {number} = {numberMultiply(number)}");
}
else 
{
    Console.WriteLine($"Ошибка! Число должно быть > 1 !");
}
