// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов для будущего массива:");
int numZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Создаем массив из {numZ} элементов");

int [] myArr = new int [numZ];
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = new Random().Next( 0, 100);
    Console.Write($"{myArr[i]} ");
} 

int DiffrentMinMax (int [] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        else if (arr[i] > max) max = arr[i];
    }
    return max - min;
}

Console.WriteLine();
int result = DiffrentMinMax(myArr);
Console.WriteLine(result);