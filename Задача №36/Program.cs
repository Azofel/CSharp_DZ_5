Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void action(int a)
{
	for (int i = 0; i < a; i++)
	{
	randomArray[i] = new Random().Next();
	Console.Write(randomArray[i] + " ");
	}

}

int quantity(int[] randomArray)
{
	int sum = 0;
	int i = 0;
	while (i < randomArray.Length)
	{
		sum = sum + randomArray[i];
		i = i + 2;
	}
	return sum;
}

action(a);
Console.Write($"Cумма элементов, стоящих на нечётных позициях: {quantity(randomArray)}");