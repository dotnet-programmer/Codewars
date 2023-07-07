namespace Codewars.Lib;

public static class Kyu8
{
	public static void Multiply()
	{
		static int multiply(int a, int b) => a * b;
	}

	public static void Function_1_hello_world()
	{
		static string greet() => "hello world!";
	}

	public static void Training_JS_7_if_else_and_ternary_operator()
	{
		static int SaleHotDogs(int n) => n * (n < 5 ? 100 : n < 10 ? 95 : 90);

		#region First version
		//const int _pricePerUnit = 100;
		//static int SaleHotDogs(int n)
		//{
		//	int price = n * _pricePerUnit;
		//	return n < 5 ? price : (n is >= 5 and < 10) ? (int)(price * 0.95) : (int)(price * 0.90);
		//}
		#endregion First version
	}

	public static void Convert_a_Number_to_a_String()
	{
		static string NumberToString(int num) => num.ToString();
	}
}