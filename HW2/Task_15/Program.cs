Console.WriteLine("Введите номер дня недели:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek >= 1 && dayOfWeek <= 5)
{
    Console.WriteLine("Сегодня будний день...");
}
else if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("Сегодня выходной!");
}
else if (dayOfWeek < 1 || dayOfWeek > 7)
{
    Console.WriteLine("У нас в неделе всего 7 дней)");
}