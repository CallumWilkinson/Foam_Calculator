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
            var csvReaderService = new CSVReaderService("C:\\Users\\callu\\Documents\\GitHub\\Foam_Calculator\\Foam_Calculator\\FoamPrice.csv");

            //act
            var result = csvReaderService.ReadCsvFile().ToList();

            //Id,Color,Thickness(mm),SKU,RRP($)

            //assert
            result.Should().HaveCount(24);
            result[23].Should().Equal("24","Yellow", "150", "25043", "3.39");
        }
    }
}
