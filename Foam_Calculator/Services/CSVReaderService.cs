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


        //turns the csv into a list of string arrays
        public List<string[]> ReadCsvFile()
        {
            List<string[]> data = new List<string[]>();

            using (StreamReader reader = new StreamReader(_csvFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine();
                    var values = row.Split(',');
                    data.Add(values);
                }

                //foreach (var row in data)
                //{
                //    this.TypeCastAllValuesInRow(row);
                //}
            }

            return data;
        }


     
    }
}
