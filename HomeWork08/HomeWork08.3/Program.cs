//3.Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення
//(у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1,
//у другому – на 2, ..., в останньому – на 9).
//Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.
int[,] multTable = new int[9, 9];
int rowMultiplier = 1;
int columnMultiplier = 1;

for (int row = 0; row < multTable.GetLength(0); row++) //рядок
{
	for (int column = 0; column < multTable.GetLength(1); column++) //стовпець
	{
		multTable[row, column] = rowMultiplier * columnMultiplier;
		columnMultiplier++;

		Console.Write($"{multTable[row, column]}\t");
	}

	rowMultiplier++;
	columnMultiplier = 1;

	Console.WriteLine();
}