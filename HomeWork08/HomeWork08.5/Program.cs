//5.За допомогою enum створити програму, що буде запитувати у користувача кількість днів, 
//а потім рахувати який буде день через введену кількість, 
//якщо рахувати від понеділка і виводити результат. Наприклад: 
//Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday
//Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday

int numberOfDays = 0;
bool isInt = false;
bool isFindDay = false;

while (!isInt)
{
	Console.Write("Enter number of days: ");
	isInt = int.TryParse(Console.ReadLine(), out numberOfDays);

	isInt &= (numberOfDays >= 0);
}

while (!isFindDay)
{
	if (numberOfDays > (int)DaysOfWeek.Sunday)
		numberOfDays -= 7;

	switch (numberOfDays)
	{
		case 0:
			Console.WriteLine(DaysOfWeek.Monday);
			isFindDay = true;
			break;
		case 1:
			Console.WriteLine(DaysOfWeek.Tuesday);
			isFindDay = true;
			break;
		case 2:
			Console.WriteLine(DaysOfWeek.Wednesday);
			isFindDay = true;
			break;
		case 3:
			Console.WriteLine(DaysOfWeek.Thursday);
			isFindDay = true;
			break;
		case 4:
			Console.WriteLine(DaysOfWeek.Friday);
			isFindDay = true;
			break;
		case 5:
			Console.WriteLine(DaysOfWeek.Saturday);
			isFindDay = true;
			break;
		case 6:
			Console.WriteLine(DaysOfWeek.Sunday);
			isFindDay = true;
			break;
	}
}

enum DaysOfWeek
{
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}