// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1)
{    
    int GetSumNums(int number)
    {
        int result = 0;
        for (int i = 1; i <= number; i++)
        {
            result += i;
        }
        return result;
    }
    Console.WriteLine($"Cумма цифр от 1 до {num} = {GetSumNums(num)}");
}
else 
{
    Console.WriteLine($"Ошибка! Число должно быть > 1 !");
}
