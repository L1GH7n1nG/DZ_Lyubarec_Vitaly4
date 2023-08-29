double Degree(double numA, int numB)
{
	double sum = 1;
	for (int i = 0; i < numB; i++)
	{
		sum *= numA;
	}
	return sum;
}

bool Check(int numB)
{
	return numB >= 0;
}

Console.Write("Введите число А: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (Check(numberB))
{
	Console.WriteLine($"Результат числа {numberA} в степени {numberB} = {Degree(numberA, numberB)}.");
}
else
{
	Console.WriteLine("Введено неверное натуральное число B.");
}