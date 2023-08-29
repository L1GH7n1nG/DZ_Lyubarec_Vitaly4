int SumDigits(int num)
{
	if (num < 0) num *= -1;
	int sum = 0;
	for (; num > 0;)
	{
		int digit = num % 10;
		sum += digit;
		num /= 10;
	}
	return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} = {SumDigits(number)}");