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
		Assert.AreEqual(true, Kyu5.AllAlone(house));
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
		Assert.AreEqual(false, Kyu5.AllAlone(house));
	}
}
