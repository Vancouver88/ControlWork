using System;

class Program
{
	static void Main()
	{
		string[] originalArray = { "Hello", "2", "world", ":-)" };
		string[] newArray = GetShortStrings(originalArray);

		Console.WriteLine("Исходный массив строк:");
		foreach (string str in originalArray)
		{
			Console.WriteLine(str);
		}

		Console.WriteLine("\nНовый массив строк (длина <= 3 символов):");
		foreach (string str in newArray)
		{
			Console.WriteLine(str);
		}

		Console.ReadLine();
	}

	static string[] GetShortStrings(string[] originalArray)
	{
		int count = 0;
		foreach (string str in originalArray)
		{
			if (str.Length <= 3)
			{
				count++;
			}
		}

		string[] newArray = new string[count];
		int index = 0;
		foreach (string str in originalArray)
		{
			if (str.Length <= 3)
			{
				newArray[index] = str;
				index++;
			}
		}

		return newArray;
	}
}