// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов для будущего массива:");
int numZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Создаем массив из {numZ} элементов");

int [] myArr = new int [numZ];
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = new Random().Next( -99, 100);
    Console.Write($"{myArr[i]} ");
} 

int SumOfOddPositionNumbers (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( i % 2 > 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
Console.WriteLine();
int result = SumOfOddPositionNumbers(myArr);
Console.WriteLine(result);