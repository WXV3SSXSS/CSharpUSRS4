internal class Program
{
	delegate int Calc(int[] n);
	private static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
		int[] numbers = new int[10]
		{
	1, 2, 3, 4, 5, 6, 7, 8, 9, 10
		};
        Console.WriteLine("For:");
        Timer(CalcFor, numbers);
		Console.WriteLine("Foreach:");
		Timer(CalcForeach, numbers);
		Console.WriteLine("LINQ Method:");
		Timer(CalcLINQMethod, numbers);
		Console.WriteLine("LINQ Request:");
		Timer(CalcLINQRequest, numbers);

		static int CalcFor(int[] numbers)
		{
			int forSumOfSquares = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] % 2 == 0)
				{
					forSumOfSquares += numbers[i] * numbers[i];
				}
			}
			return forSumOfSquares;
		}

		static int CalcForeach(int[] numbers)
		{
			int foreachSumOfSquares = 0;
			foreach (var number in numbers)
			{
				if (number % 2 == 0)
				{
					foreachSumOfSquares += number * number;
				}
			}
			return foreachSumOfSquares;
		}

		static int CalcLINQMethod(int[] numbers)
		{
			int linqMethodSumOfSquares = 0;
			var linqMethod = numbers.Where(x => x % 2 == 0).Select(x => x * x);
			foreach (var item in linqMethod)
			{
				linqMethodSumOfSquares += item;
			}
			return linqMethodSumOfSquares;
		}

		static int CalcLINQRequest(int[] numbers)
		{
			int linqRequestSumOfSquares = 0;
			var linqRequest = from p in numbers
							  where p % 2 == 0
							  select p * p;
			foreach (var item in linqRequest)
			{
				linqRequestSumOfSquares += item;
			}
			return linqRequestSumOfSquares;
		}

		static void Timer(Calc calc, int[] numbers)
		{
			DateTime start = DateTime.Now;
			Console.WriteLine(calc(numbers));
			DateTime end = DateTime.Now;
			Console.WriteLine((end - start).TotalSeconds + " секунд");
        }
	}
}

