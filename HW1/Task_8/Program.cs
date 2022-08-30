Console.WriteLine("Введите число A");
int numN = Convert.ToInt32(Console.ReadLine());

string evenNumbers = "";
int numI = 1;

while (numI <= numN)
{
    if (numI % 2 == 0) {
        evenNumbers = evenNumbers + numI + ", ";
    }
     numI += 1;
}

Console.WriteLine(evenNumbers);