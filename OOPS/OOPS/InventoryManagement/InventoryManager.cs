using OOPS.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryManagement
{
    public class InventoryManager
    {
        InventoryFactory factory=new InventoryFactory();
        List<InventoryData> riceList = new List<InventoryData>();
        List<InventoryData> wheatList = new List<InventoryData>();
        List<InventoryData> pulseList = new List<InventoryData>();
        public void BrowseInventoryData(string path)
        {
            InventoryFeatures features = factory.ReadJson(path);
            this.riceList = features.RiceList;
            this.wheatList = features.WheatList;
            this.pulseList = features.PulseList;
        }
        public void AddInventory(InventoryData data,string nameOfInventory, string path)
        {
            if (nameOfInventory.Equals("RiceList"))
            {
                riceList.Add(data);
            }
            if (nameOfInventory.Equals("WheatList"))
            {
                wheatList.Add(data);
            }
            if (nameOfInventory.Equals("PulsesList"))
            {
                pulseList.Add(data);
            }
            SavingInventory(path);
        }
        public void SavingInventory(string path)
        {
            InventoryFeatures features=new InventoryFeatures();
            features.RiceList = riceList;
            features.WheatList = wheatList;
            features.PulseList = pulseList;
            factory.WriteToJson(path,features);
        }
        public void InventoryEdit(string nameOfInventory,InventoryData name, string path)
        {
            BrowseInventoryData(path);
            InventoryData inventory = new InventoryData();
            if (nameOfInventory.Equals("RiceList"))
            {
                foreach(var data in this.riceList)
                {
                    if (data.Name.Equals(name))
                    {
                        Console.WriteLine("choose am option to edit:1.Name\n2.Weight\n3.Price per kg");
                        int option=Convert.ToInt32(Console.ReadLine());
                        switch(option)
                        {
                            case 1:
                                Console.WriteLine("Enter the name: ");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the weight: ");
                                data.Weight=Convert.ToInt32(Console.ReadLine());
                                break;
                             case 3:
                                Console.WriteLine("Enter the price per kg");
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (nameOfInventory.Equals("WheatList"))
            {
                foreach(var data in this.wheatList)
                {
                    if (data.Name.Equals(name))
                    {
                        Console.WriteLine("Choose an option to edit: 1.Name\n2Weight\n3.PricePerKg");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch( option)
                        {
                            case 1:
                                Console.WriteLine("Enter the name: ");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the weight: ");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the Price per kg: ");
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (nameOfInventory.Equals("PulsesList"))
            {
                foreach (var data in this.pulseList)
                {
                    if (data.Name.Equals(name))
                    {
                        Console.WriteLine("Choose an option to edit: 1.Name\n2.Weight\n3.PricePerKg");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter the name: ");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the weight: ");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the Price per kg: ");
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            SavingInventory(path);
        }
    }
}
