using System.Collections.Generic;

namespace WcfWebHttpIISHostingSample
{
    public class TestService : ITestService
    {
        List<string> _data = null;
        public TestService()
        {
            _data = new List<string>() {"Gibberish", "Wadknot", "TacoTime", "Nibsox"};
        }

        public List<string> GetData(string data)
        {
            _data.Add(data);
            return _data;
        }
    }
}