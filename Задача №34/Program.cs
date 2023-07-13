Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void quantity(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(100,999);
        Console.Write(randomArray[i] + " ");
    }

}

int sum (int[] randomArray)
{
    int sum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
        sum++;
    }
    return sum;
}

quantity(a);
Console.Write($"Количество чётных чисел в массиве: {sum(randomArray)}");