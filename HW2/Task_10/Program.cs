Console.WriteLine("Введите 3-хзначное число для проверки");
int numZ = Convert.ToInt32(Console.ReadLine());

int result = numZ / 10 % 10;

Console.WriteLine(result);
