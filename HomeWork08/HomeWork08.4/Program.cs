//4.Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: 
//а) максимальний елемент масиву; б) мінімальний елемент масиву; в) координати мінімального елемента масиву. 
//г) координати максимального елемента масиву.

const int rows = 5;
const int columns = 5;
const int MIN = -50;
const int MAX = 50;

int[,] arr = new int[rows, columns];

int maxNumberArr = int.MinValue;
int minNumberArr = int.MaxValue;
int[] maxCoord = new int[2];
int[] minCoord = new int[2];

var random = new Random();

for (int row = 0; row < arr.GetLength(0); row++) 
{
	for (int column = 0; column < arr.GetLength(1); column++)
	{
		arr[row, column] = random.Next(MIN, MAX);

		if (arr[row, column] >= maxNumberArr)
		{
			maxNumberArr = arr[row, column];
			maxCoord[0] = row;
			maxCoord[1] = column;
		}
		if (arr[row, column] <= minNumberArr)
		{
			minNumberArr = arr[row, column];
			minCoord[0] = row;
			minCoord[1] = column;
		}
		Console.Write($"{arr[row, column]}\t");
	}
	Console.WriteLine();
}

Console.WriteLine($"\nMax: {maxNumberArr}  Coordinate: ({maxCoord[0]}, {maxCoord[1]})");
Console.WriteLine($"Min: {minNumberArr} Coordinate: ({minCoord[0]}, {minCoord[1]})");