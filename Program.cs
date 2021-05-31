using System;

namespace Milestone2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInventory myInventory = new MyInventory();

            storeItem item1 = new storeItem();
            item1.name = "apple";
            item1.color = "red";
            item1.weight = 0.5;
            item1.brand = "krogers";
            item1.price = 0.75;

            myInventory.inventoryList.Add(item1);
            
            storeItem item2 = new storeItem();
            item2.name = "orange";
            item2.color = "orange";
            item2.weight = 0.75;
            item2.brand = "costco";
            item2.price = 1.00;

            myInventory.inventoryList.Add(item2);

            storeItem item3 = new storeItem();
            item3.name = "banana";
            item3.color = "yellow";
            item3.weight = 0.2;
            item3.brand = "costco";
            item3.price = 0.18;

            myInventory.inventoryList.Add(item3);

            storeItem item4 = new storeItem();
            item4.name = "grapes";
            item4.color = "purple";
            item4.weight = 1.2;
            item4.brand = "safeway";
            item4.price = 2.99;

            myInventory.inventoryList.Add(item4);

            storeItem item5 = new storeItem();
            item5.name = "dragonfruit";
            item5.color = "pink";
            item5.weight = 1.5;
            item5.brand = "wholefoods";
            item5.price = 5.50;

            myInventory.inventoryList.Add(item5);
        }

    }
    }

