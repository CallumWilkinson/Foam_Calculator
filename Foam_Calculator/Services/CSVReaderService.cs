using System.Collections.Generic;
using System.IO;

namespace Foam_Calculator.Services
{
    public class CSVReaderService
    {
        public IEnumerable<string[]> ReadCsvFile(string filePath)
        {
            List<string[]> records = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
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
