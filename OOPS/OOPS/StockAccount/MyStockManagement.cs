using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS.StockAccount
{
    public class MyStockManagement
    {
        public void DisplayStockDetails(string path)
        {
            using StreamReader reader = new StreamReader(path) ;
            {
                var jsonFile = reader.ReadToEnd();
                var stock= JsonConvert.DeserializeObject<List<MyStockData>>(jsonFile);
                Console.WriteLine("StockName"+"\t"+"Stock Price"+"\t"+"No. Of Shares");
                foreach(MyStockData data in stock)
                {
                    Console.WriteLine(data.StockName+"\t\t"+data.StockPrice+"\t"+data.Shares+"\t"+(data.StockPrice*data.Shares));
                }
            }
        }
    }
}
