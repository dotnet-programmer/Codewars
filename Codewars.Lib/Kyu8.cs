namespace Codewars.Lib;

public static class Kyu8
{
	// Multiply - https://www.codewars.com/kata/50654ddff44f800200000004
	public static int multiply(int a, int b) => a * b;

	// Function 1 - hello world - https://www.codewars.com/kata/523b4ff7adca849afe000035
	public static string greet() => "hello world!";

	// Training JS #7: if..else and ternary operator - https://www.codewars.com/kata/57202aefe8d6c514300001fd
	public static int SaleHotDogs(int n) => n * (n < 5 ? 100 : n < 10 ? 95 : 90);

	// Convert a Number to a String! - https://www.codewars.com/kata/5265326f5fda8eb1160004c8
	public static string NumberToString(int num) => num.ToString();

	// Reversed Words - https://www.codewars.com/kata/51c8991dee245d7ddf00000e
	public static string ReverseWords(string str) => string.Join(" ", str.Split(' ').Reverse());

	#region solution from YT

	public static string ReverseWords2(string str)
	{
		var splitWords = Split(str, ' ');
		var reverseWords = Reverse(splitWords);
		var result = Join(reverseWords, ' ');
		return result;
	}

	private static List<string> Split(string input, char separator)
	{
		int currentIndex = 0;
		List<string> result = new();
		for (int i = 0; i < input.Length; i++)
		{
			if (input[i] == separator)
			{
				string word = input.Substring(currentIndex, i - currentIndex);
				result.Add(word);
				currentIndex = i + 1;
			}
			else if (i == input.Length - 1)
			{
				string word = input.Substring(currentIndex, input.Length - currentIndex);
				result.Add(word);
			}
		}
		return result;
	}

	private static List<string> Reverse(List<string> list)
	{
		List<string> result = new();
		for (int i = list.Count - 1; i >= 0; i--)
		{
			result.Add(list[i]);
		}
		return result;
	}

	private static string Join(List<string> list, char separator)
	{
		System.Text.StringBuilder sb = new();
		for (int i = 0; i < list.Count; i++)
		{
			sb.Append(list[i]);
			if (i != list.Count - 1)
			{
				sb.Append(separator);
			}
		}
		return sb.ToString();
	}

	#endregion solution from YT
}