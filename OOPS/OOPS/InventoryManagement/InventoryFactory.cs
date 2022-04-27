using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryManagement
{
    public class InventoryFactory
    {
        public InventoryFeatures ReadJson(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                var json=reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<InventoryFeatures>(json);
                return inventory;
            }
        }
        public void WriteToJson(string path, InventoryFeatures features)
        {
            var jsonFile=JsonConvert.SerializeObject(features);
            File.WriteAllText(path, jsonFile);
        }
    }
}
