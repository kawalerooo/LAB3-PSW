using System;

namespace ConsoleApp3
{
	public static class Task3
	{
		public static void Run()
		{
			Console.Write("Podaj wymiar macierzy:");
			string dimention = Console.ReadLine();
			int parsedDimention = int.Parse(dimention);

			int[,] firstArray = CreateRandomArray(parsedDimention);
			int[,] secondArray = CreateRandomArray(parsedDimention);

			int[,] sumMatrix = Sum(parsedDimention, firstArray, secondArray);
			int[,] differenceMatrix = Subtract(parsedDimention, firstArray, secondArray);
			int[,] multiplierMatrix = Multiply(parsedDimention, firstArray, secondArray);

			Console.WriteLine("Pierwsza macierz:");
			WriteMatrix(parsedDimention, firstArray);

			Console.WriteLine("Druga macierz:");
			WriteMatrix(parsedDimention, secondArray);

			Console.WriteLine("Dodane macierze: ");
			WriteMatrix(parsedDimention, sumMatrix);

			Console.WriteLine("Odjęte macierze: ");
			WriteMatrix(parsedDimention, differenceMatrix);

			Console.WriteLine("Pomnożone macierze: ");
			WriteMatrix(parsedDimention, multiplierMatrix);

			Console.ReadKey();
		}

		public static int[,] CreateRandomArray(int dimention)
		{
			Random rand = new Random();
			int[,] result = new int[dimention, dimention];
			for (int rowIndex = 0; rowIndex < dimention; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < dimention; columnIndex++)
				{
					result[rowIndex, columnIndex] = rand.Next(-10, 10);
				}
			}

			return result;
		}

		public static int[,] Sum(int dimention, int[,] firstArray, int[,] secondArray)
		{
			int[,] result = new int[dimention, dimention];
			for (int rowIndex = 0; rowIndex < dimention; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < dimention; columnIndex++)
				{
					result[rowIndex, columnIndex] = firstArray[rowIndex, columnIndex] + secondArray[rowIndex, columnIndex];
				}
			}

			return result;
		}

		public static int[,] Subtract(int dimention, int[,] firstArray, int[,] secondArray)
		{
			int[,] result = new int[dimention, dimention];
			for (int rowIndex = 0; rowIndex < dimention; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < dimention; columnIndex++)
				{
					result[rowIndex, columnIndex] = firstArray[rowIndex, columnIndex] - secondArray[rowIndex, columnIndex];
				}
			}

			return result;
		}

		public static int[,] Multiply(int dimention, int[,] firstArray, int[,] secondArray)
		{
			int[,] result = new int[dimention, dimention];
			for (int rowIndex = 0; rowIndex < dimention; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < dimention; columnIndex++)
				{
					int sum = 0;
					for (int sumIndex = 0; sumIndex < dimention; sumIndex++)
					{
						sum += (firstArray[rowIndex, sumIndex] * secondArray[sumIndex, columnIndex]);
					}
					result[rowIndex, columnIndex] = sum;
				}
			}

			return result;
		}

		public static void WriteMatrix(int dimention, int[,] array)
		{
			for (int i = 0; i < dimention; i++)
			{
				for (int j = 0; j < dimention; j++)
				{
					Console.Write(array[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}
