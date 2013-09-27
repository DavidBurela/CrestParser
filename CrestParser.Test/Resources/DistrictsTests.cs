using System;
using System.IO;
using System.Threading.Tasks;
using CrestParser.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrestParser.Test.Resources
{
    [TestClass]
    public class DistrictsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var a = new FileStream(@"SampleData\Districts-201309252350.json", FileMode.Open);
            var filereader = new System.IO.StreamReader(a);
            var str = filereader.ReadToEnd();
            

            // Act
            var d = Districts.ParseDistricts(str);

            // Assert
            Assert.IsTrue(d.Count > 100);
        }
    }
}
