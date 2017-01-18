using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NameSearch.Tests
{
    public class When_looking_up_other_form_of_names
    {
        [Fact]
        public void VictoriaFindsVicky()
        {
            Assert.True(NameSearch.GetOtherFormsOfNames("Victoria").Contains("Vicky"));
        }

        [Fact]
        public void victoriaFindsVicky()
        {
            Assert.True(NameSearch.GetOtherFormsOfNames("victoria").Contains("Vicky"));
        }

        [Fact]
        public void BillDoesNotFindFrank()
        {
            Assert.False(NameSearch.GetOtherFormsOfNames("Bill").Contains("Frank"));
        }

        [Fact]
        public void FeliciaFindsFelicity()
        {
            Assert.True(NameSearch.GetOtherFormsOfNames("Felicia").Contains("Felicity"));
        }

        [Fact]
        public void FeliciaAndFeliciaAreTheSame()
        {
            Assert.True(NameSearch.AreTheSameName("Felicia", "Felicia"));
        }

        [Fact]
        public void FeliciaAndFelicityAreTheSame()
        {
            Assert.True(NameSearch.AreTheSameName("Felicia", "Felicity"));
        }

        [Fact]
        public void FelicityAndFeliciaAreTheSame()
        {
            Assert.True(NameSearch.AreTheSameName("Felicity", "Felicia"));
        }

        [Fact]
        public void FelicityAndfeliciaAreTheSame()
        {
            Assert.True(NameSearch.AreTheSameName("Felicity", "felicia"));
        }

        [Fact]
        public void felicityAndFeliciaAreTheSame()
        {
            Assert.True(NameSearch.AreTheSameName("felicity", "Felicia"));
        }
    }
}
