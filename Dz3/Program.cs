/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76

*/

float[] InitArray(int length)
{
    Random rnd = new Random();
    float[] arr = new float[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(float[] arr)
{
    foreach (var item in arr)
        System.Console.Write($"{item} ");
    System.Console.WriteLine("");
}

float MaxNumber(float[] arr)
{
    float max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

float MinNumber(float[] arr)
{
    float min = 100;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}


Console.Clear();
System.Console.Write("Введите размер массива ");
int lengthArray = int.Parse(System.Console.ReadLine());
float[] arr = InitArray(lengthArray);
System.Console.WriteLine("");
PrintArray(arr);
float minNumber = MinNumber(arr);
float maxNumber = MaxNumber(arr);
float result = maxNumber - minNumber;
System.Console.WriteLine("");
System.Console.WriteLine($"Разница между максимальным {maxNumber} и минимальным значением {minNumber} массива = {result}");
System.Console.ReadKey();


