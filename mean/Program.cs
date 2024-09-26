using System;
Console.WriteLine($"Введите несколько чисел через пробел");
try
{
    string? numInput = Console.ReadLine();
    double[] array = numInput!.Split(' ').Select(Double.Parse).ToArray();
    double sum = 0;
    double mean = 0;
    if (array.Length >= 3 && array.Length <= 7)
    {
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        mean = Math.Round(sum / array.Length,2);
        Console.WriteLine($"среднее арифметическое значение всех введённых чисел {sum}/{array.Length} = {mean}");
    }
    else
    {
        Console.WriteLine($"Количество цифр должно быть от 3 до 7");
    }
}
catch ( Exception ex )
{
    Console.WriteLine("Неправильный ввод данных");
    Console.WriteLine(ex.Message);
}