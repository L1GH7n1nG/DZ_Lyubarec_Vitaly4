void FillArray(int[] array)
{
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(-100, 100);
	}
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i]);

		if (i < array.Length - 1)
		{
			Console.Write(", ");
		}
	}
	Console.Write(" -> [");
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i]);

		if (i < array.Length - 1)
		{
			Console.Write(", ");
		}
	}
	Console.Write("]");
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
