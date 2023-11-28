using Codewars.Lib;

namespace Codewars.Tests;

internal class Kyu5_Tests
{
	// I am all alone (poor me)
	[Test]
	public void Ex1()
	{
		char[][] house =
		{
			"  o                o        #######".ToCharArray(),
			"###############             #     #".ToCharArray(),
			"#             #        o    #     #".ToCharArray(),
			"#  X          ###############     #".ToCharArray(),
			"#                                 #".ToCharArray(),
			"###################################".ToCharArray()
		};
		Assert.That(Kyu5.AllAlone(house), Is.EqualTo(true));
	}

	[Test]
	public void Ex2()
	{
		char[][] house =
		{
			"#################             ".ToCharArray(),
			"#     o         #   o         ".ToCharArray(),
			"#          ######        o    ".ToCharArray(),
			"####       #                  ".ToCharArray(),
			"   #       ###################".ToCharArray(),
			"   #                         #".ToCharArray(),
			"   #                  X      #".ToCharArray(),
			"   ###########################".ToCharArray()
		};
		Assert.That(Kyu5.AllAlone(house), Is.EqualTo(false));
	}
}