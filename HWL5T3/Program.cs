// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] GetArray(int size, int leftRange, int rightRange) // создание массива размером size от LeftRang до RightRange
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    
    return array;
}

int GetMaxArray(int[] array)
{
    int Max = array[0];
    for (int i = 0; i < 8; i++ )
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
    }
    return Max;
}

int GetMinArray(int[] array)
{
    int Min = array[0];
    for (int i = 0; i < 8; i++ )
    {
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    return Min;
}

int[] arr = GetArray(8, -100, 100);
int result = GetMaxArray(arr) - GetMinArray(arr);
Console.WriteLine($"Сгенерированный массив - ");
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"Разница между максимальным и минимальным значениеями массива = {result}");