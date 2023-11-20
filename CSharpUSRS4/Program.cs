// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numbers = new int[10]
{
	1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};
int forSumOfSquares = 0;
for (int i = 0; i < numbers.Length; i++)
{
	if (numbers[i] % 2 == 0)
	{
		forSumOfSquares += numbers[i] * numbers[i];
	}
}
Console.WriteLine("for: " + forSumOfSquares);

int foreachSumOfSquares = 0;
foreach (var number in numbers)
{
	if (number % 2 == 0)
	{
		foreachSumOfSquares += number * number;
	}
}
Console.WriteLine("foreach: " + forSumOfSquares);

int linqMethodSumOfSquares = 0;
var linqMethod = numbers.Where(x => x % 2 == 0).Select(x => x * x);
foreach (var item in linqMethod)
{
	linqMethodSumOfSquares += item;
}
Console.WriteLine("linq method: " + linqMethodSumOfSquares);

int linqRequestSumOfSquares = 0;
var linqRequest = from p in numbers
				  where p % 2 == 0
				  select p * p;
foreach (var item in linqRequest)
{
	linqRequestSumOfSquares += item;
}
Console.WriteLine("linq request: " + linqRequestSumOfSquares);