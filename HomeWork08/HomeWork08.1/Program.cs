//1.Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10,
//використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
//Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
using System.Reflection.Metadata;

int[] arr = new int[10];
const int MIN = -10;
const int MAX = 10;
var random = new Random();

for (int i = 0; i < arr.Length; i++)
{
	arr[i] = random.Next(MIN, MAX);

	if(i % 2 == 0 && i != 0)
		Console.WriteLine(arr[i]);
}