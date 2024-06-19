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
    public class CsvReaderServiceTestsTempCSV
    {
        private readonly string _testFilePath = "testData.csv";
        private CSVReaderService _csvReaderService;

        [SetUp]
        public void Setup()
        {
            _csvReaderService = new CSVReaderService(_testFilePath);


            //make a csv file, save it to the testfilepath
            //im not actually putting through the read csv cos i should be able to DI any csv into this function
            File.WriteAllLines(_testFilePath, new[]
            {
                "Color,Size,SKU,RRP",
                "White,18mm,25027,$0.23",
                "White,25mm,25028,$0.33"
            });

        }

        [Test]
        public void TestingReadCsvFileWithTEMPCsv()
        {
            //arrange

            //act
            var result = _csvReaderService.ReadCsvFile().ToList();
            result[0].Should().Equal(new[] { "Color", "Size", "SKU", "RRP" });


            //assert
        }

        [TearDown]
        public void TearDown()
        {
            // delete the test file
            if (File.Exists(_testFilePath))
            {
                File.Delete(_testFilePath);
            }
        }
    }
}