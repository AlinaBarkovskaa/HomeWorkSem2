// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string numberText =  Convert.ToString(number);
// if (numberText.Length > 2)
// {
//    Console.WriteLine("Третья цифра этого числа = "+ numberText[2]);
// }else 
// {
//   Console.WriteLine("Tретьей цифры нет");
// }

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText =  Convert.ToString(number);
if(number > 99)
   {
   Console.WriteLine("Третья цифра этого числа = " + numberText[2]);
   } else 
   {
     Console.WriteLine("Tретьей цифры нет");
   }
