using System.Reflection;
using Codewars.Lib;

Console.ForegroundColor = ConsoleColor.Green;

Action[] _kyu8 = typeof(Kyu8).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _kyu7 = typeof(Kyu7).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _kyu6 = typeof(Kyu6).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _kyu5 = typeof(Kyu5).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _kyu4 = typeof(Kyu4).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _kyu3 = typeof(Kyu3).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _kyu2 = typeof(Kyu2).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _kyu1 = typeof(Kyu1).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

string[] menuItems = new[] { "Easy", "Medium", "Hard", "Very Hard" };

while (true)
{
	ShowMenuPositions(menuItems);
	Console.Write("Choose a number: ");
	char keyChar = Console.ReadKey(true).KeyChar;
	switch (keyChar)
	{
		case '1':
			DoWork(_kyu8);
			break;
		case '2':
			DoWork(_kyu7);
			break;
		case '3':
			DoWork(_kyu6);
			break;
		case '4':
			DoWork(_kyu5);
			break;
		case '5':
			DoWork(_kyu4);
			break;
		case '6':
			DoWork(_kyu3);
			break;
		case '7':
			DoWork(_kyu2);
			break;
		case '8':
			DoWork(_kyu1);
			break;
		default:
			return;
	}
}

static void ShowMenuPositions(string[] menuItems)
{
	Console.Clear();
	for (int i = 0; i < menuItems.Length; i++)
	{
		Console.WriteLine($"{i + 1}. {menuItems[i]}");
	}
}

static void DoWork(Action[] functions, string header = "")
{
	bool isWorking = true;
	while (isWorking)
	{
		ShowMenuPositions(functions, header);
		Console.Write("Choose a number: ");
		isWorking = ExecuteMethod(Console.ReadLine(), functions);
	}

	static void ShowMenuPositions(Action[] functions, string header)
	{
		Console.Clear();

		if (!string.IsNullOrEmpty(header))
		{
			Console.WriteLine(header);
		}

		for (int i = 0; i < functions.Length; i++)
		{
			Console.WriteLine($"{i + 1}. {functions[i].Method.Name}");
		}
	}

	static bool ExecuteMethod(string input, Action[] functions)
	{
		if (int.TryParse(input, out int menuNumber) && menuNumber > 0 && menuNumber <= functions.Length)
		{
			functions[menuNumber - 1]();
			Console.ReadLine();
			return true;
		}
		else
		{
			return false;
		}
	}
}