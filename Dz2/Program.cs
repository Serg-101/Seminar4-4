/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitArray(int length)
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-length, length);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
        System.Console.Write($"{item} ");
    System.Console.WriteLine("");
}

int SummOddNumber(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)  // Прибавляем по 2 сразу
    {
        result += arr[i];
    }
    return result;
}

Console.Clear();
System.Console.Write("Введите размер массива ");
int lengthArray = int.Parse(System.Console.ReadLine());
int [] arr = InitArray(lengthArray);
System.Console.WriteLine("");
PrintArray(arr);
int result = SummOddNumber(arr);
System.Console.WriteLine("");
System.Console.WriteLine($"Сумма чисел на нечетных позициях в массиве {result}"); 
// Счет в массиве начинается с нулевого элемента массива 
// Ноль - четный а значит начинаем счет с элемента с индексом 1
System.Console.ReadKey();
