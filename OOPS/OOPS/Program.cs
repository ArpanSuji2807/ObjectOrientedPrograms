using System;
using OOPS;
using OOPS.InventoryDataManagement;
using OOPS.InventoryManagement;
using OOPS.StockAccount;

public class Program
{
    public static void Main(string[] args)
    {
        const string path1 = @"D:\PracticeProblem\ObjectOrientedPrograms\OOPS\OOPS\InventoryDataManagement\Inventory.json";
        InventoryManagement management = new InventoryManagement();
        const string path2 = @"D:\PracticeProblem\ObjectOrientedPrograms\OOPS\OOPS\InventoryManagement\InventoryList.json";
        InventoryManager manager = new InventoryManager();
        const string path3 = @"D:\PracticeProblem\ObjectOrientedPrograms\OOPS\OOPS\StockAccount\MyStockAccount.json";
        MyStockManagement stockManagement = new MyStockManagement();
        bool end = true;
        Console.WriteLine("1.Display Inventory\n2.Manupulate Data\n3.Stock Account details");
        while (end)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    management.DisplayInventory(path1);
                    break;
                case 2:
                    InventoryMain main = new InventoryMain();
                    main.ManupulateData(path2);
                    break ;
                case 3:
                    stockManagement.DisplayStockDetails(path3);
                    break;
                case 4:
                    Console.WriteLine("enter a valid choice");
                    break;
            }
        }
    }
}