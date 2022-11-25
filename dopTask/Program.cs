Console.Clear();
Console.WriteLine("Введите числo от 0 до 100: ");
int number = Convert.ToInt32(Console.ReadLine());
int max = number;
int previousMax = 0;
{
    do
    {
        number = Convert.ToInt32(Console.ReadLine());
        if(max < number)
        {
            previousMax = max;
            max = number;
        }
        else if(number > previousMax )
        {
            previousMax = number;
        }
    } while (number != 0);
    Console.WriteLine( $"Предыдущее максимальное = {previousMax}");
    Console.Write("end");
}

