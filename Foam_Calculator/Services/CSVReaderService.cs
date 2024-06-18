using System.Collections.Generic;
using System.IO;

namespace Foam_Calculator.Services
{
    public class CSVReaderService
    {
        private string _csvFilePath;

        public CSVReaderService(string filePath)
        {
            _csvFilePath = filePath;
        }

        public IEnumerable<string[]> ReadCsvFile()
        {
            List<string[]> records = new List<string[]>();

            using (StreamReader reader = new StreamReader(_csvFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    records.Add(values);
                }
            }

            return records;
        }
    }
}
