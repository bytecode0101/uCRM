using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ucrm;

namespace TestUcrm
{
    [TestFixture]
    public class TestCountry
    {
        [Test]
        public string ChooseCountry()
        {     

        Address firstaddress = new Address();
            firstaddress.SelectCountry();
    }
}
}