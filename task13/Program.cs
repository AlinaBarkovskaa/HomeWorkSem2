Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number >= 999)
    {
        number = number / 10;
    }
    int n = number % 10;
    Console.WriteLine($"Третья цифра этого числа = {n}");
}
else
{
    Console.WriteLine("Tретьей цифры нет");
}

