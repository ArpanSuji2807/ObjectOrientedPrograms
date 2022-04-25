using System;
using OOPS;
using OOPS.InventoryDataManagement;

public class Program
{
    public static void Main(string[] args)
    {
        const string path = @"D:\PracticeProblem\ObjectOrientedPrograms\OOPS\OOPS\InventoryDataManagement\Inventory.json";
        InventoryManagement management = new InventoryManagement();
        bool end = true;
        Console.WriteLine("1.Display Inventory");
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
                    Console.WriteLine("enter a valid choice");
                    break;
            }
        }
    }
}