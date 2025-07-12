namespace Codewars.Lib;

public static class Kyu5
{
	// I am all alone (poor me) - https://www.codewars.com/kata/5c230f017f74a2e1c300004f
	public static bool AllAlone(char[][] house)
	{
		Point potus = default;
		for (int i = 0; i < house.GetLength(0); i++)
		{
			for (int j = 0; j < house[i].Length; j++)
			{
				if (house[i][j] == 'X')
				{
					potus = new(i, j);
				}
			}
		}

		List<Point> scannedPoints = [];
		return !Scan(potus, house, scannedPoints);
	}

	private struct Point(int x, int y)
	{
		public int X { get; set; } = x;
		public int Y { get; set; } = y;
	}

	private static bool Scan(Point point, char[][] house, List<Point> scannedPoints)
	{
		if (scannedPoints.Contains(point))
		{
			return false;
		}
		scannedPoints.Add(point);
		if (house[point.X][point.Y] == 'o')
		{
			return true;
		}
		if (house[point.X][point.Y] == '#')
		{
			return false;
		}
		Point pointUp = new(point.X, point.Y - 1);
		Point pointDown = new(point.X, point.Y + 1);
		Point pointLeft = new(point.X - 1, point.Y);
		Point pointRight = new(point.X + 1, point.Y);
		return (Scan(pointUp, house, scannedPoints))
			|| (Scan(pointDown, house, scannedPoints))
			|| (Scan(pointLeft, house, scannedPoints))
			|| (Scan(pointRight, house, scannedPoints));
	}
}