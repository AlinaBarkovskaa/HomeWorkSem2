Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

void CheckDayWeek (int dayWeek) {
  if (dayWeek == 6 || dayWeek == 7) 
  {
  Console.WriteLine("Да! Это выходной день");
  }
  if(dayWeek >= 1 && dayWeek <= 5)
  {
    Console.WriteLine("Нет! Этот день не выходной");
  }else
  if (dayWeek > 7) 
  {
    Console.WriteLine("Это не день недели");
  }  
}
CheckDayWeek(dayWeek);