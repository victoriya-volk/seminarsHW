// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите количество элементов для будущего массива:");
int numZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Создаем массив из {numZ} элементов");

int [] myArr = new int [numZ];
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = new Random().Next( 100, 1000);
    Console.Write($"{myArr[i]} ");
} 

int CountPositiveNumbers (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
Console.WriteLine();
Console.WriteLine("Ищем количество полодительных чисел в массиве");

int result = CountPositiveNumbers(myArr);
Console.WriteLine(result);