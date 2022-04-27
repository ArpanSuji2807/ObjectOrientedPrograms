using System;
using OOPS;
using OOPS.InventoryDataManagement;
using OOPS.InventoryManagement;

public class Program
{
    public static void Main(string[] args)
    {
        const string path = @"D:\PracticeProblem\ObjectOrientedPrograms\OOPS\OOPS\InventoryDataManagement\Inventory.json";
        InventoryManagement management = new InventoryManagement();
        const string fullPath = @"D:\PracticeProblem\ObjectOrientedPrograms\OOPS\OOPS\InventoryManagement\InventoryList.json";
        InventoryManager manager = new InventoryManager();
        bool end = true;
        Console.WriteLine("1.Display Inventory\n2.Manupulate Data");
        while (end)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    management.DisplayInventory(path);
                    break;
                case 2:
                    InventoryMain main = new InventoryMain();
                    main.ManupulateData(fullPath);
                    break ;
                case 4:
                    Console.WriteLine("enter a valid choice");
                    break;
            }
        }
    }
}