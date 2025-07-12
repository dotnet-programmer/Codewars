using Codewars.Lib;

namespace Codewars.Tests;

internal class Kyu8_Tests
{
	// Multiply
	[Test]
	public void ShouldMultiple()
	{
		Assert.That(Kyu8.multiply(2, 1), Is.EqualTo(2));
		Assert.That(Kyu8.multiply(2, 4), Is.EqualTo(8));
	}

	// Function 1 - hello world
	[Test]
	public void ShouldReturnHelloWorld()
		=> Assert.That(Kyu8.greet(), Is.EqualTo("hello world!"));

	// Training JS #7: if..else and ternary operator
	[Test]
	public void SampleTest()
	{
		Assert.That(Kyu8.SaleHotDogs(1), Is.EqualTo(100));
		Assert.That(Kyu8.SaleHotDogs(4), Is.EqualTo(400));
		Assert.That(Kyu8.SaleHotDogs(5), Is.EqualTo(475));
		Assert.That(Kyu8.SaleHotDogs(9), Is.EqualTo(855));
		Assert.That(Kyu8.SaleHotDogs(10), Is.EqualTo(900));
		Assert.That(Kyu8.SaleHotDogs(100), Is.EqualTo(9000));
	}

	// Convert a Number to a String!
	private static IEnumerable<TestCaseData> TestCases
	{
		get
		{
			yield return new TestCaseData(67).Returns("67");
			yield return new TestCaseData(79585).Returns("79585");
			yield return new TestCaseData(1 + 2).Returns("3");
			yield return new TestCaseData(1 - 2).Returns("-1");
		}
	}

	[Test, TestCaseSource(nameof(TestCases))]
	public string Test(int num)
		=> Kyu8.NumberToString(num);

	// Reversed Words
	[Test]
	public void ReversedWords()
	{
		Assert.That(Kyu8.ReverseWords("hello world!"), Is.EqualTo("world! hello"));
		Assert.That(Kyu8.ReverseWords("yoda doesn't speak like this"), Is.EqualTo("this like speak doesn't yoda"));
		Assert.That(Kyu8.ReverseWords("foobar"), Is.EqualTo("foobar"));
		Assert.That(Kyu8.ReverseWords("editor kata"), Is.EqualTo("kata editor"));
		Assert.That(Kyu8.ReverseWords("row row row your boat"), Is.EqualTo("boat your row row row"));
		Assert.That(Kyu8.ReverseWords(""), Is.EqualTo(""));
	}

	// Reversed Words 2
	[Test]
	public void ReversedWords2()
	{
		Assert.That(Kyu8.ReverseWords2("hello world!"), Is.EqualTo("world! hello"));
		Assert.That(Kyu8.ReverseWords2("yoda doesn't speak like this"), Is.EqualTo("this like speak doesn't yoda"));
		Assert.That(Kyu8.ReverseWords2("foobar"), Is.EqualTo("foobar"));
		Assert.That(Kyu8.ReverseWords2("editor kata"), Is.EqualTo("kata editor"));
		Assert.That(Kyu8.ReverseWords2("row row row your boat"), Is.EqualTo("boat your row row row"));
		Assert.That(Kyu8.ReverseWords2(""), Is.EqualTo(""));
	}
}