// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

int[] binaryArray = new int[8]; // двоичный (бинарный) массив: 0 и 1
{
    for (int i = 0; i < 8; i++)
    {
        binaryArray[i] = new Random().Next(2);
    }
}
Console.WriteLine($"Массив: [{String.Join(", ", binaryArray)}]");
