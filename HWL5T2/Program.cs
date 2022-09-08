// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int GetSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum = sum + array[i];
        i++;
    }
    return sum;
}
int[] arr = GetArray(6, -100, 100);
Console.WriteLine($"Сгенерированный массив - ");
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"Cумма элементов массива стоящих на нечетных позициях - {GetSumOdd(arr)}");

