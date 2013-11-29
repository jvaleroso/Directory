using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Directory.Dao;
using Directory.Service;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Directory.Tests
{
    [TestClass]
    public class ProvinceServiceTest
    {
        [TestMethod]
        public void TestAddProvince()
        {
            var provinceService = A.Fake<IProvinceService>();

            var province = new Province
            {
                Code = "LGN",
                Name = "Laguna",
            };

            A.CallTo(() => provinceService.Save(province)).Returns(province);


        }
    }
}
