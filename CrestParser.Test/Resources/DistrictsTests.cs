using System;
using System.Threading.Tasks;
using CrestParser.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrestParser.Test.Resources
{
    [TestClass]
    public class DistrictsTests
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var a = new Districts();
            var d = await a.GetDistricts();

            Assert.IsTrue(d.Count > 100);
        }
    }
}
