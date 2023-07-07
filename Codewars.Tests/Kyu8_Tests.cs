using Codewars.Lib;

namespace Codewars.Tests;

internal class Kyu8_Tests
{
	// Multiply
	[Test]
	public void ShouldMultiple()
	{
		Assert.AreEqual(2, Kyu8.multiply(2, 1));
		Assert.AreEqual(8, Kyu8.multiply(2, 4));
	}

	// Function 1 - hello world
	[Test]
	public void ShouldReturnHelloWorld() => Assert.AreEqual("hello world!", Kyu8.greet());

	// Training JS #7: if..else and ternary operator
	[Test]
	public void SampleTest()
	{
		Assert.AreEqual(100, Kyu8.SaleHotDogs(1));
		Assert.AreEqual(400, Kyu8.SaleHotDogs(4));
		Assert.AreEqual(475, Kyu8.SaleHotDogs(5));
		Assert.AreEqual(855, Kyu8.SaleHotDogs(9));
		Assert.AreEqual(900, Kyu8.SaleHotDogs(10));
		Assert.AreEqual(9000, Kyu8.SaleHotDogs(100));
	}

	// Convert a Number to a String!
	private static IEnumerable<TestCaseData> testCases
	{
		get
		{
			yield return new TestCaseData(67).Returns("67");
			yield return new TestCaseData(79585).Returns("79585");
			yield return new TestCaseData(1 + 2).Returns("3");
			yield return new TestCaseData(1 - 2).Returns("-1");
		}
	}

	[Test, TestCaseSource("testCases")]
	public string Test(int num) => Kyu8.NumberToString(num);

	// Reversed Words
	[Test]
	public void ReversedWords()
	{
		Assert.AreEqual("world! hello", Kyu8.ReverseWords("hello world!"));
		Assert.AreEqual("this like speak doesn't yoda", Kyu8.ReverseWords("yoda doesn't speak like this"));
		Assert.AreEqual("foobar", Kyu8.ReverseWords("foobar"));
		Assert.AreEqual("kata editor", Kyu8.ReverseWords("editor kata"));
		Assert.AreEqual("boat your row row row", Kyu8.ReverseWords("row row row your boat"));
		Assert.AreEqual("", Kyu8.ReverseWords(""));
	}

	// Reversed Words 2
	[Test]
	public void ReversedWords2()
	{
		Assert.AreEqual("world! hello", Kyu8.ReverseWords2("hello world!"));
		Assert.AreEqual("this like speak doesn't yoda", Kyu8.ReverseWords2("yoda doesn't speak like this"));
		Assert.AreEqual("foobar", Kyu8.ReverseWords2("foobar"));
		Assert.AreEqual("kata editor", Kyu8.ReverseWords2("editor kata"));
		Assert.AreEqual("boat your row row row", Kyu8.ReverseWords2("row row row your boat"));
		Assert.AreEqual("", Kyu8.ReverseWords2(""));
	}
}