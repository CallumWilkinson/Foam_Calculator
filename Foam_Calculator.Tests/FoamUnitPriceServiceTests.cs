using FluentAssertions;
using Foam_Calculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foam_Calculator.Tests
{
    [TestFixture]

    public class FoamUnitPriceServiceTests
    {

        [Test]
        public void TestingLookupFunctions()
        {

            //arrange
            FoamUnitPriceService foamPriceService = new FoamUnitPriceService("C:\\Users\\callu\\Documents\\GitHub\\Foam_Calculator\\Foam_Calculator\\FoamPrice.csv");


            //act
            decimal green50mmUnitPrice = foamPriceService.GetUnitPriceByColourAndThickness("Green", 50);
            int green50mmSKU = foamPriceService.GetSkuByColourAndThickness("Green", 50);

            //assert
            green50mmUnitPrice.Should().Be(0.9m);
            green50mmSKU.Should().Be(25085);
        }

    }
}
