using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.Contracts;
using Verivox.Services;
using Verivox.Services.Models;

namespace Verivox.Tests.UnitTests
{
    [TestFixture]
    public class ConsumptionServiceTests
    {
        private IConsumptionService _consumptionService;

        [SetUp]
        public void SetUp()
        {
            _consumptionService = new ConsumptionService();
        }

        [Test]
        [TestCase(3500, 830, 800)]
        [TestCase(4500, 1050, 950)]
        [TestCase(6000, 1380, 1400)]
        public void ConsumptionServiceShouldReturnExpectedValues(int consumption, double basicExpected, double packagedExpected)
        {
            var result = _consumptionService.GetProducts(consumption);

            Assert.That(result, Is.Not.Null);

            var package = result.First(e => e.GetType() == typeof(PackagedElectricity));
            var basic = result.First(e => e.GetType() == typeof(BasicElectricity));

            Assert.AreEqual(package.AnnualCost, packagedExpected);
            Assert.AreEqual(basic.AnnualCost, basicExpected);
        }
    }
}
