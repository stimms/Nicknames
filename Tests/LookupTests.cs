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
			Assert.IsTrue(NameSearch.GetOtherFormsOfNames("Victoria").Contains("Vicky"));
		}

        [Test()]
        public void victoriaFindsVicky()
        {
            Assert.IsTrue(NameSearch.GetOtherFormsOfNames("victoria").Contains("Vicky"));
        }

        [Test()]
        public void BillDoesNotFindFrank()
        {
            Assert.IsFalse(NameSearch.GetOtherFormsOfNames("Bill").Contains("Frank"));
        }

        [Test()]
        public void FeliciaFindsFelicity()
        {
            Assert.IsTrue(NameSearch.GetOtherFormsOfNames("Felicia").Contains("Felicity"));
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

