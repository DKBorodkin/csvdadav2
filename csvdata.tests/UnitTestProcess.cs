using Xunit;
using csvdata;

namespace csvdata.tests
{
    public class UnitTestProcess
    {
        private readonly CSVData _csvData;

        public UnitTestProcess()
        {
            // 
            string fileName = "/home/dmitry/mycsharp/csvdata_test/csvdata/datatest01.csv";
            _csvData = new CSVData(fileName);

        }
        [Fact]
        public void TestProcessRow()
        {
            int r = _csvData.Load();
            r = _csvData.ProcessData();

            int result = _csvData.GetPriceData(0);
            int expected = 1200;

            Assert.Equal(expected, result);
        }
    }
}