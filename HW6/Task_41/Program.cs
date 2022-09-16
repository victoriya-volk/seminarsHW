// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void PositiveNumbers (int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Bведите число:");
        int newNum = Convert.ToInt32(Console.ReadLine());
        if (newNum > 0) count += 1;
    }
    Console.WriteLine($"{count} чисел больше 0");
}

Console.WriteLine("Введите количетсво чисел для проверки:");
int numM = Convert.ToInt32(Console.ReadLine());
PositiveNumbers(numM);