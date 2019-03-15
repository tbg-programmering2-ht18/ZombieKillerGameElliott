using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_solution
{
    public class DataSample<T>
    {
        private T theData;

        public DataSample(T theData)
        {
            this.theData = theData;
        }

        public T GetData()
        {
            return theData;
        }

        public string MyToString()
        {
            return theData.ToString();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DataSample<String> dss = new DataSample<string>("Forty-two");
            DataSample<int> dsi = new DataSample<int>(42);

            string s = dss.GetData();
            int i = dsi.GetData();

            Console.WriteLine(String.Format("s={0}, i={1}"));
            Console.ReadKey();
        }
    }
}
