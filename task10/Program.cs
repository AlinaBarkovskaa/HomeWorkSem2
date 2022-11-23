// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// string a = Convert.ToString(input);
// Console.WriteLine("вторая цифра этого числа = "+a[1]);


Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вторая цифра этого числа = " +input /10 % 10);

