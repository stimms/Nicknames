using System;
using NUnit.Framework;
namespace NameSearch
{
	[TestFixture()]
	public class LookupTests
	{
		[Test()]
		public void VictoriaFindsVicky ()
		{
			Assert.IsTrue(NameSearch.GetSimilarNames("Victoria").Contains("Vicky"));
		}
	}
}

