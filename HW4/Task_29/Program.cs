Console.WriteLine("Введите количество элементов для будущего массива:");
int numZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Создаем массив из {numZ} элементов");
int [] ourArray = new int[numZ];
for(int i = 0; i < numZ; i++)
{
    ourArray[i] = new Random().Next(0,100);
}

for (int j = 0; j < ourArray.Length; j++)
{
    Console.Write($"{ourArray[j]} ");
}