//2. Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
int[] arr = new int[10];
const int MIN = -10;
const int MAX = 10;
var random = new Random();
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
	arr[i] = random.Next(MIN, MAX);
	Console.WriteLine(arr[i]);
	sum += arr[i];
}

if (sum > 0)
	Console.WriteLine($"Sum of all array elements is greater than 0: {sum}");
else Console.WriteLine($"Sum of all array elements is less than 0: {sum}");
