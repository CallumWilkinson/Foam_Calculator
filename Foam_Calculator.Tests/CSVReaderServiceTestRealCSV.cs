using FluentAssertions;
using NUnit.Framework;
using Moq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using Foam_Calculator.Services;

namespace FoamCalculator.Tests
{
    [TestFixture]
    public class CSVReaderServiceTestRealCSV
    {
        [Test]
        public void TestingWithActualCSVFile()
        {
            //arrange
            var csvReaderService = new CSVReaderService();
            string actualCsvFile = "C:\\Users\\callu\\Documents\\GitHub\\FoamCalculator\\FoamPrice.csv";

            //act
            var result = csvReaderService.ReadCsvFile(actualCsvFile).ToList();


            //assert
            result.Should().HaveCount(25);
            result[0].Should().Equal("Color", "Size", "SKU", "RRP");
            result[24].Should().Equal("Yellow", "150mm", "25043", "$3.39");
        }
    }
}
