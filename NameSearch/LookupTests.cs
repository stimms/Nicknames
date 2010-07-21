using System;
using NUnit.Framework;
namespace NameSearch
{
	[TestFixture()]
	internal class LookupTests
	{
		[Test()]
		public void VictoriaFindsVicky ()
		{
			Assert.IsTrue(NameSearch.GetSimilarNames("Victoria").Contains("Vicky"));
		}

        [Test()]
        public void victoriaFindsVicky()
        {
            Assert.IsTrue(NameSearch.GetSimilarNames("victoria").Contains("Vicky"));
        }

        [Test()]
        public void BillDoesNotFindFrank()
        {
            Assert.IsFalse(NameSearch.GetSimilarNames("Bill").Contains("Frank"));
        }

        [Test()]
        public void FeliciaFindsFelicity()
        {
            Assert.IsTrue(NameSearch.GetSimilarNames("Felicia").Contains("Felicity"));
        }

        [Test()]
        public void FeliciaAndFeliciaAreTheSame()
        {
            Assert.IsTrue(NameSearch.AreTheSameName("Felicia", "Felicia"));
        }

        [Test()]
        public void FeliciaAndFelicityAreTheSame()
        {
            Assert.IsTrue(NameSearch.AreTheSameName("Felicia", "Felicity"));
        }

        [Test()]
        public void FelicityAndFeliciaAreTheSame()
        {
            Assert.IsTrue(NameSearch.AreTheSameName("Felicity", "Felicia"));
        }

        [Test()]
        public void FelicityAndfeliciaAreTheSame()
        {
            Assert.IsTrue(NameSearch.AreTheSameName("Felicity", "felicia"));
        }

        [Test()]
        public void felicityAndFeliciaAreTheSame()
        {
            Assert.IsTrue(NameSearch.AreTheSameName("felicity", "Felicia"));
        }
	}
}

