// using System;
using Xunit;
// using csvdata;

namespace csvdata.tests
{
    public class UnitTestLoad
    {
        private readonly CSVData _csvData;

        public UnitTestLoad()
        {
            string inputFileName = "/home/dmitry/mycsharp/csvdata_test/csvdata/data2.csv";
            _csvData = new CSVData(inputFileName); ;
        }

        [Fact]
        public void TestLoadOk()
        {
            int result = _csvData.Load();
            int expected = 0;

            Assert.Equal(expected, result);
        }
    }

    // Попытка загрузки из несуществующего файла
    public class UnitTestLoadFail
    {
        private readonly CSVData _csvData;
        public UnitTestLoadFail()
        {
            string inputFileName = "/home/dmitry/mycsharp/csvdata_test/csvdata/data_fake.csv";
            _csvData = new CSVData(inputFileName); ;
        }
        [Fact]
        public void TestLoadFail()
        {
            int result = _csvData.Load();
            int expected = 1;

            Assert.Equal(expected, result);
        }
    }
}
