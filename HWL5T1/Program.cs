int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < 8; i++)
array[i] = rand.Next(100 , 999); 
var str = string.Join(" ", array);


int evenM(int[] array)
{
    int even = 0; 
    for (int i = 0; i < 8; i++ )
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}

Console.WriteLine($"Сгенерированный массив из 8 чисел - {str}");
Console.WriteLine($"Количество четных чисел в массиве - {evenM(array)}");
