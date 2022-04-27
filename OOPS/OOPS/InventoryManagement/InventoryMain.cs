using OOPS.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryManagement
{
    public class InventoryMain
    {
        public void ManupulateData(string path)
        {
            InventoryManager inventoryManager = new InventoryManager();
            Console.WriteLine("1.Browse Json File\n2.Add Inventory\n3.Edit Inventory");
            InventoryData data = new InventoryData();
            bool check = true;
            while(check)
            {
                Console.WriteLine("Choose an option: ");
                int option= Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        inventoryManager.BrowseInventoryData(path);
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of Inventory");
                        string inventoryName = Console.ReadLine();
                        Console.WriteLine("Enter the Name, weight and Price per Kg");
                        data.Name =Console.ReadLine();
                        data.Weight = Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg=Convert.ToInt32(Console.ReadLine());
                        inventoryManager.AddInventory(data,inventoryName,path);
                        break ;
                    case 3:
                        Console.WriteLine("Enter Inventory name: ");
                        string nameOfInventory = Console.ReadLine();
                        inventoryManager.InventoryEdit(nameOfInventory,data,path);
                        break;
                }
            }
        }
    }
}
